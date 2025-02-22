using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Lab6_ImageProcessor
{
    internal class ImageProcessor
    {
        // Класс для работы с изображением

        // расположение изображения
        public string ImagePath;

        // Метод замены цвета
        public Bitmap ReplacePixelByColor(string color)
        {
            // arg: color - цвет изображения
            // result: новое изображение

            Bitmap RawImage = new Bitmap(ImagePath, true);

            var result_image = new Bitmap(RawImage.Width, RawImage.Height);

            // перебираем все пиксели изображения
            for (int x = 0; x < RawImage.Width; x++)
            {
                for (int y = 0; y < RawImage.Height; y++)
                {
                    Color original_pixel = RawImage.GetPixel(x, y);

                    switch (color)
                    {
                        case "red":
                            original_pixel = Color.FromArgb(original_pixel.A, original_pixel.R, 0, 0);
                            break;
                        case "green":
                            original_pixel = Color.FromArgb(original_pixel.A, 0, original_pixel.G, 0);
                            break;
                        case "blue":
                            original_pixel = Color.FromArgb(original_pixel.A, 0, 0, original_pixel.B);
                            break;
                        case "rgb":
                            byte gray = (byte)(.299 * original_pixel.R + .587 * original_pixel.G + .114 * original_pixel.B);
                            original_pixel = Color.FromArgb(original_pixel.A, gray, gray, gray);
                            break;
                        default:
                            original_pixel = Color.FromArgb(original_pixel.A, 0, original_pixel.G, 0);
                            break;
                    }
                    result_image.SetPixel(x, y, original_pixel);
                }
            }

            return result_image;
        }

        // Метод быстрой замены цвета
        public Bitmap ReplacePixelByColorFast(string color)
        {
            // arg: color - цвет изображения
            // result: новое изображение

            Bitmap raw_image = new Bitmap(ImagePath, true);

            // блокируем в памяти
            BitmapData raw_image_bitmap = raw_image.LockBits(
                new Rectangle(0, 0, raw_image.Width, raw_image.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            // указатель на первый пиксель в памяти
            IntPtr raw_ptr = raw_image_bitmap.Scan0;

            // размер нового изображения
            // находим через модуль развертки (т.к. изображение выводим свеху вниз)
            int raw_image_true_size = Math.Abs(raw_image_bitmap.Stride) * raw_image.Height;

            // байтовый массив нового изображения
            byte[] result = new byte[raw_image_true_size];
            
            // копируем из памяти в массив
            Marshal.Copy(raw_ptr, result, 0, raw_image_true_size);

            int stride = raw_image_bitmap.Stride;

            for (int y = 0; y < raw_image.Height; y++)
            {
                for (int x = 0; x < raw_image.Width; x++)
                {
                    int index = y * stride + x * 3;

                    byte gray = (byte)(.299 * result[index] + .587 * result[index + 1] + .114 * result[index + 2]);

                    switch (color)
                    {
                        case "red":
                            result[index] = 0;
                            result[index + 1] = 0;
                            break;
                        case "green":
                            result[index] = 0;
                            result[index + 2] = 0;
                            break;
                        case "blue":
                            result[index + 1] = 0;
                            result[index + 2] = 0;
                            break;
                        case "rgb":
                            result[index] = gray;
                            result[index + 1] = gray;
                            result[index + 2] = gray;
                            break;
                        default:
                            break;
                    }
                }
            }

            // копируем массив в память
            Marshal.Copy(result, 0, raw_ptr, raw_image_true_size);

            // открываем изображение
            raw_image.UnlockBits(raw_image_bitmap);

            return raw_image;
        }

        // Метод быстрой установки яркости и контрастности
        public Bitmap SetBrightnessAndContrastFast(int brightness, int contrast)
        {
            // arg: brightness - индекс яркости изображения
            // arg: contrast - индекс контрастности изображения
            // result: новое изображение

            Bitmap raw_image = new Bitmap(ImagePath, true);

            // Вычисляем фактор контрастности
            double contrastFactor = CalculateContrastFactor(contrast);

            BitmapData raw_image_bitmap = raw_image.LockBits(
                new Rectangle(0, 0, raw_image.Width, raw_image.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            IntPtr raw_ptr = raw_image_bitmap.Scan0;

            int bytes = Math.Abs(raw_image_bitmap.Stride) * raw_image.Height;
            byte[] rgbValues = new byte[bytes];

            Marshal.Copy(raw_ptr, rgbValues, 0, bytes);

            int image_size = 3 * raw_image.Width * raw_image.Height;

            for (int i = 0; i < image_size; i += 3) // Предполагаем формат BGRA
            {
                double blue = rgbValues[i] / 255.0;
                double green = rgbValues[i + 1] / 255.0;
                double red = rgbValues[i + 2] / 255.0;

                // Приводим значения к диапазону [0, 255]
                rgbValues[i] = ClampByte(CalculateContrastedColor(blue, contrastFactor) + brightness);
                rgbValues[i + 1] = ClampByte(CalculateContrastedColor(green, contrastFactor) + brightness);
                rgbValues[i + 2] = ClampByte(CalculateContrastedColor(red, contrastFactor) + brightness);
            }

            Marshal.Copy(rgbValues, 0, raw_ptr, bytes);

            raw_image.UnlockBits(raw_image_bitmap);

            return raw_image;
        }

        // Метод установки яркости и контрастности
        public Bitmap SetBrightnessAndContrast(int brightness, int contrast)
        {
            // arg: brightness - индекс яркости изображения
            // arg: contrast - индекс контрастности изображения
            // result: новое изображение

            Bitmap raw_image = new Bitmap(ImagePath, true);

            // Вычисляем фактор контрастности
            double contrastFactor = CalculateContrastFactor(contrast);

            for (int i = 0; i < raw_image.Height; i++)
            {
                for (int j = 0; j < raw_image.Width; j++)
                {
                    Color color = raw_image.GetPixel(j, i);

                    double red = color.R / 255.0;
                    double green = color.G / 255.0;
                    double blue = color.B / 255.0;

                    int r = ClampByte(CalculateContrastedColor(red, contrastFactor) + brightness);
                    int g = ClampByte(CalculateContrastedColor(green, contrastFactor) + brightness);
                    int b = ClampByte(CalculateContrastedColor(blue, contrastFactor) + brightness);

                    raw_image.SetPixel(j, i, Color.FromArgb(255, r, g, b));
                }
            }

            return raw_image;
        }

        // Служебный метод перевода в byte
        private byte ClampByte(double color) => (byte)Math.Max(0, Math.Min(color, 255));

        // Служебный метод расчета фактора контраста
        private double CalculateContrastFactor(int contrast) => Math.Pow((100.0 + contrast) / 100.0, 2);

        // Служебный метод для вычисления нвоого контрастного цвета
        private double CalculateContrastedColor(double color, double factor)
        {
            return (((color - 0.5) * factor) + 0.5) * 255;
        }
    }
}

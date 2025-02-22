using System.Diagnostics;
using System;
using System.Drawing;

namespace Lab6_ImageProcessor.Presenter
{
    internal class ImageProcessorPresenter
    {
        public EditorView EditorView { get => _editorView; set => _editorView = value; }
        private EditorView _editorView;

        public ImageProcessor ImageProcessor { get => _imageProcessor; set => _imageProcessor = value; }
        private ImageProcessor _imageProcessor;

        // Конструктор презентераы
        public ImageProcessorPresenter(ImageProcessor imageProcessor, EditorView editorView)
        {
            _imageProcessor = imageProcessor;
            _editorView = editorView;
            ImageProcessor.ImagePath = EditorView.ImagePath;
        }

        // Презентер цвета
        public void SwitchImageColor(string color, bool fast = false)
        {
            Bitmap NewImage;

            if (!fast)
            {
                NewImage = MeasureExecutionTime(() => ImageProcessor.ReplacePixelByColor(color));
            }
            else
            {
                NewImage = MeasureExecutionTime(() => ImageProcessor.ReplacePixelByColorFast(color));
            }

            EditorView.UpdatePictureBox(NewImage);
        }

        // Презентер яркости и контраста
        public void SetBrightnessAndContrast(int brightness, int contrast, bool fast = false)
        {
            Bitmap NewImage;

            if (!fast)
            {
                NewImage = MeasureExecutionTime(() => ImageProcessor.SetBrightnessAndContrast(brightness, contrast));
            }
            else
            {
                NewImage = MeasureExecutionTime(() => ImageProcessor.SetBrightnessAndContrastFast(brightness, contrast));
            }

            EditorView.UpdatePictureBox(NewImage);
        }

        // Метод обёртка для вычисления времени выполнения функции
        private T MeasureExecutionTime<T>(Func<T> method)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                return method(); // Выполняем переданный метод и возвращаем результат
            }
            finally
            {
                stopwatch.Stop();
                EditorView.UpdateExecutionTime(stopwatch.Elapsed.TotalSeconds.ToString("0.000"));
            }
        }
    }
}

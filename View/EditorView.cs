using Lab6_ImageProcessor.Presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab6_ImageProcessor
{
    public partial class EditorView : Form
    {
        private ImageProcessorPresenter ImageProcessorPresenter;

        // Путь к изображению
        public string ImagePath;

        // Фильтр
        private const string _FILTER = "Изображения (*.bmp, *.png, *.jpg, *.jpeg)|*.bmp;*.png;*.jpg;*.jpeg;";

        // Словарь доступных цветов
        private readonly Dictionary<string, string> _COMMAND_DICT = new Dictionary<string, string>()
        {
            { "Красный", "red"},
            { "Зеленый", "green"},
            { "Синий", "blue"},
            { "Серый", "rgb"},
        };

        // Инициализация класса
        public EditorView()
        {
            InitializeComponent();

            SaveFileDialog.Filter = _FILTER;
            SaveFileDialog.InitialDirectory = "c:\\";
            SaveFileDialog.FileName = "Picture.png";
            OpenFileDialog.Filter = _FILTER;
            OpenFileDialog.InitialDirectory = "c:\\";
        }

        // При клике "Открыть"
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog)
                {
                    if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ImagePath = OpenFileDialog.FileName;
                        RecoverButton.PerformClick();
                        UpdatePictureBox(new Bitmap(ImagePath, true));
                    }
                }
            }
            catch (Exception ex) 
            {
                ShowErrorMessage(ex.Message + "\n" + ex.StackTrace);
            }
        }

        // При клике "Сохранить"
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog)
                {
                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap bitmap = new Bitmap(PictureBox.Image);
                        bitmap.Save(SaveFileDialog.FileName);

                        MessageBox.Show($"Файл сохранен в {SaveFileDialog.FileName}",
                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message + "\n" + ex.StackTrace);
            }
        }

        // При клике "О программе"
        private void AbotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Простой блокнот | Автор Никольский В.А. ЗЦИС-27",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Метод обновления картинки
        public void UpdatePictureBox(Bitmap image)
        {
            try
            {
                // Освобождаем старое изображение
                PictureBox.Image?.Dispose(); 

                PictureBox.Image = image;
                PictureBox.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // При клике на цает
        private void MakeNewColorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string color_option = _COMMAND_DICT[button.Text];

            if (CanChangeImage())
            {
                ImageProcessorPresenter = new ImageProcessorPresenter(new ImageProcessor(), this);

                if (UseFastCheckBox.Checked)
                {
                    ImageProcessorPresenter.SwitchImageColor(color_option, true);
                }
                else
                {
                    ImageProcessorPresenter.SwitchImageColor(color_option);
                }
            }
        }

        // При смене value яркости
        private void BrightnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (CanChangeImage())
            {
                ImageProcessorPresenter = new ImageProcessorPresenter(new ImageProcessor(), this);

                if (UseFastCheckBox.Checked)
                {
                    ImageProcessorPresenter.SetBrightnessAndContrast(BrightnessTrackBar.Value, ContrastTrackBar.Value, true);
                }
                else
                {
                    ImageProcessorPresenter.SetBrightnessAndContrast(BrightnessTrackBar.Value, ContrastTrackBar.Value);
                }
            }
        }

        // При смене value контраста
        private void ContrastTrackBar_ValueChanged(object sender, EventArgs e)
        {

            if (CanChangeImage())
            {
                ImageProcessorPresenter = new ImageProcessorPresenter(new ImageProcessor(), this);

                if (UseFastCheckBox.Checked)
                {
                    ImageProcessorPresenter.SetBrightnessAndContrast(BrightnessTrackBar.Value, ContrastTrackBar.Value, true);
                }
                else
                {
                    ImageProcessorPresenter.SetBrightnessAndContrast(BrightnessTrackBar.Value, ContrastTrackBar.Value);
                }
            }
        }

        // При клике "Восстановить"
        private void RecoverButton_Click(object sender, EventArgs e)
        {
            PictureBox.ImageLocation = ImagePath;
            InfoLabel.Visible = false;
            ExecutionTimeLabel.Text = "";
            BrightnessTrackBar.Value = 0;
            ContrastTrackBar.Value = 0;
        }

        // Метод обновления времени выполнения
        public void UpdateExecutionTime(string new_time)
        {
            InfoLabel.Visible = true;
            ExecutionTimeLabel.Text = new_time + " сек.";
        }

        // Служебный метод проверки изображения в PictureBox
        private bool CanChangeImage()
        {
            if (ImagePath != null)
                return true;

            return false;
        }

        // Служебный метод вывода ошибки
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(
                message, "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}

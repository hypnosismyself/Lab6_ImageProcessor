namespace Lab6_ImageProcessor
{
    partial class EditorView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.MakeGrayButton = new System.Windows.Forms.Button();
            this.MakeBlueButton = new System.Windows.Forms.Button();
            this.MakeRedButton = new System.Windows.Forms.Button();
            this.MakeGreenButton = new System.Windows.Forms.Button();
            this.RecoverButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ExecutionTimeLabel = new System.Windows.Forms.Label();
            this.UseFastCheckBox = new System.Windows.Forms.CheckBox();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.AbotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.OpenFileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // AbotToolStripMenuItem
            // 
            this.AbotToolStripMenuItem.Name = "AbotToolStripMenuItem";
            this.AbotToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AbotToolStripMenuItem.Text = "О программе";
            this.AbotToolStripMenuItem.Click += new System.EventHandler(this.AbotToolStripMenuItem_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.ErrorImage")));
            this.PictureBox.ImageLocation = "/Images/noimage.png";
            this.PictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.InitialImage")));
            this.PictureBox.Location = new System.Drawing.Point(166, 27);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(622, 475);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // MakeGrayButton
            // 
            this.MakeGrayButton.BackColor = System.Drawing.Color.Silver;
            this.MakeGrayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeGrayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeGrayButton.Location = new System.Drawing.Point(12, 27);
            this.MakeGrayButton.Name = "MakeGrayButton";
            this.MakeGrayButton.Size = new System.Drawing.Size(148, 38);
            this.MakeGrayButton.TabIndex = 2;
            this.MakeGrayButton.Text = "Серый";
            this.MakeGrayButton.UseVisualStyleBackColor = false;
            this.MakeGrayButton.Click += new System.EventHandler(this.MakeNewColorButton_Click);
            // 
            // MakeBlueButton
            // 
            this.MakeBlueButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MakeBlueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeBlueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeBlueButton.Location = new System.Drawing.Point(12, 159);
            this.MakeBlueButton.Name = "MakeBlueButton";
            this.MakeBlueButton.Size = new System.Drawing.Size(148, 38);
            this.MakeBlueButton.TabIndex = 3;
            this.MakeBlueButton.Text = "Синий";
            this.MakeBlueButton.UseVisualStyleBackColor = false;
            this.MakeBlueButton.Click += new System.EventHandler(this.MakeNewColorButton_Click);
            // 
            // MakeRedButton
            // 
            this.MakeRedButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.MakeRedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeRedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeRedButton.Location = new System.Drawing.Point(12, 71);
            this.MakeRedButton.Name = "MakeRedButton";
            this.MakeRedButton.Size = new System.Drawing.Size(148, 38);
            this.MakeRedButton.TabIndex = 4;
            this.MakeRedButton.Text = "Красный";
            this.MakeRedButton.UseVisualStyleBackColor = false;
            this.MakeRedButton.Click += new System.EventHandler(this.MakeNewColorButton_Click);
            // 
            // MakeGreenButton
            // 
            this.MakeGreenButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.MakeGreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeGreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeGreenButton.Location = new System.Drawing.Point(12, 115);
            this.MakeGreenButton.Name = "MakeGreenButton";
            this.MakeGreenButton.Size = new System.Drawing.Size(148, 38);
            this.MakeGreenButton.TabIndex = 5;
            this.MakeGreenButton.Text = "Зеленый";
            this.MakeGreenButton.UseVisualStyleBackColor = false;
            this.MakeGreenButton.Click += new System.EventHandler(this.MakeNewColorButton_Click);
            // 
            // RecoverButton
            // 
            this.RecoverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RecoverButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RecoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecoverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecoverButton.Location = new System.Drawing.Point(12, 464);
            this.RecoverButton.Name = "RecoverButton";
            this.RecoverButton.Size = new System.Drawing.Size(148, 38);
            this.RecoverButton.TabIndex = 6;
            this.RecoverButton.Text = "Восстановить";
            this.RecoverButton.UseVisualStyleBackColor = false;
            this.RecoverButton.Click += new System.EventHandler(this.RecoverButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(12, 421);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(137, 16);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "Время выполнения: ";
            this.InfoLabel.Visible = false;
            // 
            // ExecutionTimeLabel
            // 
            this.ExecutionTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExecutionTimeLabel.AutoSize = true;
            this.ExecutionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecutionTimeLabel.Location = new System.Drawing.Point(12, 437);
            this.ExecutionTimeLabel.Name = "ExecutionTimeLabel";
            this.ExecutionTimeLabel.Size = new System.Drawing.Size(0, 24);
            this.ExecutionTimeLabel.TabIndex = 8;
            // 
            // UseFastCheckBox
            // 
            this.UseFastCheckBox.AutoSize = true;
            this.UseFastCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UseFastCheckBox.Location = new System.Drawing.Point(12, 318);
            this.UseFastCheckBox.Name = "UseFastCheckBox";
            this.UseFastCheckBox.Size = new System.Drawing.Size(148, 20);
            this.UseFastCheckBox.TabIndex = 3;
            this.UseFastCheckBox.Text = "Быстрый алгоритм";
            this.UseFastCheckBox.UseVisualStyleBackColor = true;
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.Location = new System.Drawing.Point(12, 219);
            this.BrightnessTrackBar.Maximum = 255;
            this.BrightnessTrackBar.Minimum = -255;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(148, 45);
            this.BrightnessTrackBar.SmallChange = 35;
            this.BrightnessTrackBar.TabIndex = 10;
            this.BrightnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BrightnessTrackBar.ValueChanged += new System.EventHandler(this.BrightnessTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Яркость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Контраст";
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.LargeChange = 1;
            this.ContrastTrackBar.Location = new System.Drawing.Point(12, 267);
            this.ContrastTrackBar.Maximum = 100;
            this.ContrastTrackBar.Minimum = -100;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(148, 45);
            this.ContrastTrackBar.TabIndex = 1;
            this.ContrastTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ContrastTrackBar.ValueChanged += new System.EventHandler(this.ContrastTrackBar_ValueChanged);
            // 
            // EditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.ContrastTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrightnessTrackBar);
            this.Controls.Add(this.UseFastCheckBox);
            this.Controls.Add(this.ExecutionTimeLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.RecoverButton);
            this.Controls.Add(this.MakeGreenButton);
            this.Controls.Add(this.MakeRedButton);
            this.Controls.Add(this.MakeBlueButton);
            this.Controls.Add(this.MakeGrayButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 553);
            this.Name = "EditorView";
            this.Text = "Обработка изображений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button MakeGrayButton;
        private System.Windows.Forms.Button MakeBlueButton;
        private System.Windows.Forms.Button MakeRedButton;
        private System.Windows.Forms.Button MakeGreenButton;
        private System.Windows.Forms.Button RecoverButton;
        private System.Windows.Forms.ToolStripMenuItem AbotToolStripMenuItem;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label ExecutionTimeLabel;
        private System.Windows.Forms.CheckBox UseFastCheckBox;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
    }
}


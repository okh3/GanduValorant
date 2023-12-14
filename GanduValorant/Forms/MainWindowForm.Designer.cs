namespace GanduValorant
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CloseApplicationButton = new Button();
            NameLabel = new Label();
            StartTriggerButton = new Button();
            PauseTriggerButton = new Button();
            StatusLabel = new Label();
            TriggerDelayTimeNumeric = new NumericUpDown();
            PixleSensNumeric = new NumericUpDown();
            PixleWidthNumeric = new NumericUpDown();
            PixleHeightNumeric = new NumericUpDown();
            label1TriggerDelayTimeLabel = new Label();
            PixleSensLabel = new Label();
            PixleWidthLabel = new Label();
            PixleHeightLabel = new Label();
            ConfirmChangesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TriggerDelayTimeNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PixleSensNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PixleWidthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PixleHeightNumeric).BeginInit();
            SuspendLayout();
            // 
            // CloseApplicationButton
            // 
            CloseApplicationButton.BackColor = Color.White;
            CloseApplicationButton.BackgroundImageLayout = ImageLayout.None;
            CloseApplicationButton.FlatAppearance.BorderSize = 0;
            CloseApplicationButton.FlatStyle = FlatStyle.Flat;
            CloseApplicationButton.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CloseApplicationButton.Location = new Point(12, 191);
            CloseApplicationButton.Name = "CloseApplicationButton";
            CloseApplicationButton.Size = new Size(148, 31);
            CloseApplicationButton.TabIndex = 0;
            CloseApplicationButton.Text = "Close";
            CloseApplicationButton.UseVisualStyleBackColor = false;
            CloseApplicationButton.Click += CloseApplicationButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(1, 11);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(242, 37);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Gandu Valorant";
            // 
            // StartTriggerButton
            // 
            StartTriggerButton.BackColor = Color.White;
            StartTriggerButton.BackgroundImageLayout = ImageLayout.None;
            StartTriggerButton.FlatAppearance.BorderSize = 0;
            StartTriggerButton.FlatStyle = FlatStyle.Flat;
            StartTriggerButton.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            StartTriggerButton.Location = new Point(12, 74);
            StartTriggerButton.Name = "StartTriggerButton";
            StartTriggerButton.Size = new Size(148, 31);
            StartTriggerButton.TabIndex = 0;
            StartTriggerButton.Text = "Start";
            StartTriggerButton.UseVisualStyleBackColor = false;
            StartTriggerButton.Click += StartTriggerButton_Click;
            // 
            // PauseTriggerButton
            // 
            PauseTriggerButton.BackColor = Color.White;
            PauseTriggerButton.BackgroundImageLayout = ImageLayout.None;
            PauseTriggerButton.FlatAppearance.BorderSize = 0;
            PauseTriggerButton.FlatStyle = FlatStyle.Flat;
            PauseTriggerButton.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PauseTriggerButton.Location = new Point(12, 129);
            PauseTriggerButton.Name = "PauseTriggerButton";
            PauseTriggerButton.Size = new Size(148, 31);
            PauseTriggerButton.TabIndex = 0;
            PauseTriggerButton.Text = "Pause";
            PauseTriggerButton.UseVisualStyleBackColor = false;
            PauseTriggerButton.Click += PauseTriggerButton_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLabel.ForeColor = Color.Red;
            StatusLabel.Location = new Point(236, 25);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(77, 20);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Stopped";
            // 
            // TriggerDelayTimeNumeric
            // 
            TriggerDelayTimeNumeric.Location = new Point(229, 94);
            TriggerDelayTimeNumeric.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            TriggerDelayTimeNumeric.Name = "TriggerDelayTimeNumeric";
            TriggerDelayTimeNumeric.Size = new Size(120, 23);
            TriggerDelayTimeNumeric.TabIndex = 3;
            // 
            // PixleSensNumeric
            // 
            PixleSensNumeric.Location = new Point(409, 94);
            PixleSensNumeric.Name = "PixleSensNumeric";
            PixleSensNumeric.Size = new Size(120, 23);
            PixleSensNumeric.TabIndex = 3;
            // 
            // PixleWidthNumeric
            // 
            PixleWidthNumeric.Location = new Point(229, 164);
            PixleWidthNumeric.Name = "PixleWidthNumeric";
            PixleWidthNumeric.Size = new Size(120, 23);
            PixleWidthNumeric.TabIndex = 3;
            // 
            // PixleHeightNumeric
            // 
            PixleHeightNumeric.Location = new Point(409, 164);
            PixleHeightNumeric.Name = "PixleHeightNumeric";
            PixleHeightNumeric.Size = new Size(120, 23);
            PixleHeightNumeric.TabIndex = 3;
            // 
            // label1TriggerDelayTimeLabel
            // 
            label1TriggerDelayTimeLabel.AutoSize = true;
            label1TriggerDelayTimeLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1TriggerDelayTimeLabel.ForeColor = Color.White;
            label1TriggerDelayTimeLabel.Location = new Point(229, 71);
            label1TriggerDelayTimeLabel.Name = "label1TriggerDelayTimeLabel";
            label1TriggerDelayTimeLabel.Size = new Size(84, 16);
            label1TriggerDelayTimeLabel.TabIndex = 2;
            label1TriggerDelayTimeLabel.Text = "Delay (MS)";
            // 
            // PixleSensLabel
            // 
            PixleSensLabel.AutoSize = true;
            PixleSensLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PixleSensLabel.ForeColor = Color.White;
            PixleSensLabel.Location = new Point(409, 71);
            PixleSensLabel.Name = "PixleSensLabel";
            PixleSensLabel.Size = new Size(80, 16);
            PixleSensLabel.TabIndex = 2;
            PixleSensLabel.Text = "Pixle Sens";
            // 
            // PixleWidthLabel
            // 
            PixleWidthLabel.AutoSize = true;
            PixleWidthLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PixleWidthLabel.ForeColor = Color.White;
            PixleWidthLabel.Location = new Point(229, 145);
            PixleWidthLabel.Name = "PixleWidthLabel";
            PixleWidthLabel.Size = new Size(80, 16);
            PixleWidthLabel.TabIndex = 2;
            PixleWidthLabel.Text = "Pixle width";
            // 
            // PixleHeightLabel
            // 
            PixleHeightLabel.AutoSize = true;
            PixleHeightLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PixleHeightLabel.ForeColor = Color.White;
            PixleHeightLabel.Location = new Point(409, 145);
            PixleHeightLabel.Name = "PixleHeightLabel";
            PixleHeightLabel.Size = new Size(87, 16);
            PixleHeightLabel.TabIndex = 2;
            PixleHeightLabel.Text = "Pixle height";
            // 
            // ConfirmChangesButton
            // 
            ConfirmChangesButton.BackColor = Color.White;
            ConfirmChangesButton.BackgroundImageLayout = ImageLayout.None;
            ConfirmChangesButton.FlatAppearance.BorderSize = 0;
            ConfirmChangesButton.FlatStyle = FlatStyle.Flat;
            ConfirmChangesButton.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmChangesButton.Location = new Point(304, 210);
            ConfirmChangesButton.Name = "ConfirmChangesButton";
            ConfirmChangesButton.Size = new Size(148, 31);
            ConfirmChangesButton.TabIndex = 0;
            ConfirmChangesButton.Text = "Confirm";
            ConfirmChangesButton.UseVisualStyleBackColor = false;
            ConfirmChangesButton.Click += ConfirmChangesButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(598, 284);
            Controls.Add(PixleHeightNumeric);
            Controls.Add(PixleWidthNumeric);
            Controls.Add(PixleSensNumeric);
            Controls.Add(TriggerDelayTimeNumeric);
            Controls.Add(PixleHeightLabel);
            Controls.Add(PixleWidthLabel);
            Controls.Add(PixleSensLabel);
            Controls.Add(label1TriggerDelayTimeLabel);
            Controls.Add(StatusLabel);
            Controls.Add(NameLabel);
            Controls.Add(StartTriggerButton);
            Controls.Add(PauseTriggerButton);
            Controls.Add(ConfirmChangesButton);
            Controls.Add(CloseApplicationButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "#";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TriggerDelayTimeNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)PixleSensNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)PixleWidthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)PixleHeightNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseApplicationButton;
        private Label NameLabel;
        private Button StartTriggerButton;
        private Button PauseTriggerButton;
        private Label StatusLabel;
        private NumericUpDown TriggerDelayTimeNumeric;
        private NumericUpDown PixleSensNumeric;
        private NumericUpDown PixleWidthNumeric;
        private NumericUpDown PixleHeightNumeric;
        private Label label1TriggerDelayTimeLabel;
        private Label PixleSensLabel;
        private Label PixleWidthLabel;
        private Label PixleHeightLabel;
        private Button ConfirmChangesButton;
    }
}
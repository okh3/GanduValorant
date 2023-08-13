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
            SuspendLayout();
            // 
            // CloseApplicationButton
            // 
            CloseApplicationButton.BackColor = Color.White;
            CloseApplicationButton.BackgroundImageLayout = ImageLayout.None;
            CloseApplicationButton.FlatAppearance.BorderSize = 0;
            CloseApplicationButton.FlatStyle = FlatStyle.Flat;
            CloseApplicationButton.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CloseApplicationButton.Location = new Point(139, 220);
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
            NameLabel.Location = new Point(91, 18);
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
            StartTriggerButton.Location = new Point(139, 92);
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
            PauseTriggerButton.Location = new Point(139, 154);
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
            StatusLabel.Location = new Point(339, 32);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(76, 20);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Running";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(434, 289);
            Controls.Add(StatusLabel);
            Controls.Add(NameLabel);
            Controls.Add(StartTriggerButton);
            Controls.Add(PauseTriggerButton);
            Controls.Add(CloseApplicationButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseApplicationButton;
        private Label NameLabel;
        private Button StartTriggerButton;
        private Button PauseTriggerButton;
        private Label StatusLabel;
    }
}
namespace GanduValorant.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            BackgroundPanel = new Panel();
            ForeGroundPanel = new Panel();
            LoginButton = new Button();
            PasswordInput = new TextBox();
            EmailInput = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            CloseButton = new Button();
            MinimizeButton = new Button();
            BackgroundPanel.SuspendLayout();
            ForeGroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.BackColor = Color.FromArgb(39, 41, 42);
            BackgroundPanel.Controls.Add(ForeGroundPanel);
            BackgroundPanel.Location = new Point(69, 71);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.Size = new Size(684, 398);
            BackgroundPanel.TabIndex = 0;
            BackgroundPanel.Paint += panel1_Paint;
            // 
            // ForeGroundPanel
            // 
            ForeGroundPanel.BackgroundImage = (Image)resources.GetObject("ForeGroundPanel.BackgroundImage");
            ForeGroundPanel.Controls.Add(LoginButton);
            ForeGroundPanel.Controls.Add(PasswordInput);
            ForeGroundPanel.Controls.Add(EmailInput);
            ForeGroundPanel.Controls.Add(label4);
            ForeGroundPanel.Controls.Add(label2);
            ForeGroundPanel.Controls.Add(label3);
            ForeGroundPanel.Controls.Add(label1);
            ForeGroundPanel.Location = new Point(53, 33);
            ForeGroundPanel.Name = "ForeGroundPanel";
            ForeGroundPanel.Size = new Size(569, 327);
            ForeGroundPanel.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DarkGreen;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = SystemColors.Control;
            LoginButton.Location = new Point(200, 237);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(169, 46);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordInput
            // 
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordInput.Location = new Point(163, 177);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.RightToLeft = RightToLeft.No;
            PasswordInput.Size = new Size(241, 16);
            PasswordInput.TabIndex = 1;
            PasswordInput.TextAlign = HorizontalAlignment.Center;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // EmailInput
            // 
            EmailInput.BorderStyle = BorderStyle.None;
            EmailInput.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EmailInput.Location = new Point(163, 109);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(241, 16);
            EmailInput.TabIndex = 1;
            EmailInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(2, 46, 2);
            label4.Location = new Point(163, 155);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(133, 231, 94);
            label2.Location = new Point(77, 13);
            label2.Name = "label2";
            label2.Size = new Size(75, 26);
            label2.TabIndex = 0;
            label2.Text = "Gandu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(2, 46, 2);
            label3.Location = new Point(163, 87);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(76, 26);
            label1.TabIndex = 0;
            label1.Text = "Login, ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 49);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(237, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(39, 41, 42);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.ForeColor = SystemColors.Control;
            CloseButton.Location = new Point(759, 11);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(58, 33);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(39, 41, 42);
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizeButton.ForeColor = SystemColors.Control;
            MinimizeButton.Location = new Point(695, 11);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(58, 33);
            MinimizeButton.TabIndex = 2;
            MinimizeButton.Text = "↓";
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 33, 34);
            ClientSize = new Size(829, 489);
            Controls.Add(MinimizeButton);
            Controls.Add(CloseButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BackgroundPanel);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            MouseDown += Form1_MouseDown;
            BackgroundPanel.ResumeLayout(false);
            ForeGroundPanel.ResumeLayout(false);
            ForeGroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BackgroundPanel;
        private PictureBox pictureBox1;
        private Panel ForeGroundPanel;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox PasswordInput;
        private TextBox EmailInput;
        private Label label4;
        private Label label3;
        private Button LoginButton;
        private Button CloseButton;
        private Button MinimizeButton;
    }
}
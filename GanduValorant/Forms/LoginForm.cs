using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using GanduValorant.Services.AccountManagement.Login;
using GanduValorant.Models;


namespace GanduValorant.Forms
{
    public partial class LoginForm : Form
    {
        private IGanduCheatsLogin _login;
        private bool _isProcessingLogin = false;
        private Color _previousLoginButtonColor;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public LoginForm(IGanduCheatsLogin login)
        {
            InitializeComponent();
            _login = login;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            BackgroundPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, BackgroundPanel.Width, BackgroundPanel.Height, 20, 20));
            ForeGroundPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ForeGroundPanel.Width, ForeGroundPanel.Height, 20, 20));
            CloseButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, CloseButton.Width, CloseButton.Height, 20, 20));
            MinimizeButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, MinimizeButton.Width, MinimizeButton.Height, 20, 20));

            EmailInput.AutoSize = false;
            EmailInput.Size = new System.Drawing.Size(241, 30);

            PasswordInput.AutoSize = false;
            PasswordInput.Size = new System.Drawing.Size(241, 30);

            EmailInput.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, EmailInput.Width, EmailInput.Height, 7, 7));
            PasswordInput.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, PasswordInput.Width, PasswordInput.Height, 7, 7));

            LoginButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginButton.Width, LoginButton.Height, 20, 20));

            EmailInput.Focus();

            _previousLoginButtonColor = LoginButton.BackColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SetLoginButtonStatus(bool isUsing)
        {
            if (isUsing)
            {
                LoginButton.BackColor = Color.DarkSeaGreen;
                LoginButton.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
                LoginButton.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
                return;
            }
            else
            {
                LoginButton.BackColor = _previousLoginButtonColor;
            }
        }
        private async void LoginButton_Click(object sender, EventArgs e)
        {
            SetLoginButtonStatus(true);
            
            if (string.IsNullOrWhiteSpace(EmailInput.Text) || string.IsNullOrWhiteSpace(PasswordInput.Text))
            {
                label2.Text = "FILL IN ALL FIELD";
                SetLoginButtonStatus(false);
                return;
            }
            if (_isProcessingLogin) return;

            _isProcessingLogin = true;

            string responseJson = await _login.Login(EmailInput.Text, PasswordInput.Text); 

            if ( responseJson != "-1" ) 
            {
                var deserializedResponse = JsonConvert.DeserializeObject<FirebaseAuthenticationResponseBody>(responseJson);
                if( deserializedResponse != null )
                {
                    if (deserializedResponse.Registered == true)
                    {
                        label2.Text = "LOGGED IN";
                        EmailInput.Text = "";
                        PasswordInput.Text = "";
                    }
                    else
                    {
                        label2.Text = "ERROR LOGGING IN";
                    }
                }
            }
            else
            {
                label2.Text = "ERROR LOGGING IN";
            }

            SetLoginButtonStatus(false);
            _isProcessingLogin = false;
        }

        private void CloseButton_Click(object sender, EventArgs args)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs args)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

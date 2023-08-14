using GanduValorant.Services.ApplicationStatus;
using GanduValorant.Services.ColorCapturing;
using GanduValorant.Services.InputManagement.KeyboardControl;
using GanduValorant.Services.InputManagement.MouseControl;
using GanduValorant.Models.App;
using GanduValorant.Models.Constants;

using System.Drawing;

namespace GanduValorant
{
    public partial class MainWindow : Form
    {
        private Thread MainThread;

        private IPixleColorCapture _pixleColorCapture;
        private IMouseController _mouseController;
        private IKeyboardInputCapture _keyboardInputCapture;
        private IApplicationStatusManager _applicationStatusManager;

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public MainWindow(IPixleColorCapture IpixleColorCapture, IMouseController ImouseController, IKeyboardInputCapture IkeyboardInputCapture, IApplicationStatusManager ImanageApplicationStatus)
        {
            InitializeComponent();
            _pixleColorCapture = IpixleColorCapture;
            _mouseController = ImouseController;
            _keyboardInputCapture = IkeyboardInputCapture;
            _applicationStatusManager = ImanageApplicationStatus;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainThread = new Thread(MainLoop);
            MainThread.Start();

            StartTriggerButton.Focus();
            _applicationStatusManager.SetApplicationStatus(AppStates.States.Running);
        }

        private void UpdateStatusLabel(AppStates.States status)
        {
            if (NameLabel.InvokeRequired)
            {
                // BeginInvoke to asynchronously execute the update on the UI thread
                NameLabel.BeginInvoke((Action)(() => UpdateStatusLabel(status)));
            }
            else
            {
                if (status == AppStates.States.Running)
                {
                    StatusLabel.Text = status.ToString();
                    StatusLabel.ForeColor = Color.Chartreuse;
                }
                else if (status == AppStates.States.Paused)
                {
                    StatusLabel.Text = status.ToString();
                    StatusLabel.ForeColor = Color.Red;
                }
            }
        }

        private void MainLoop()
        {
            while (_applicationStatusManager.GetApplicationStatus() != AppStates.States.Stopped)
            {
                UpdateStatusLabel(_applicationStatusManager.GetApplicationStatus());

                if (_applicationStatusManager.GetApplicationStatus() == AppStates.States.Running)
                {
                    if (_pixleColorCapture.IsColorPresentAtCenter())
                    {
                        if (_keyboardInputCapture.isHoldingButton(Keys.Shift))
                        {
                            _mouseController.PressButton(MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP);     
                        }
                    }
                    
                }

                Thread.Sleep(TriggerConstants.DelayTimeMS);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainThread.Join(); 
        }

        private void StartTriggerButton_Click(object sender, EventArgs e)
        {
            _applicationStatusManager.SetApplicationStatus(AppStates.States.Running);
        }

        private void PauseTriggerButton_Click(object sender, EventArgs e)
        {
            _applicationStatusManager.SetApplicationStatus(AppStates.States.Paused);
        }

        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            _applicationStatusManager.SetApplicationStatus(AppStates.States.Stopped);
            Application.Exit();
        }
    }
}
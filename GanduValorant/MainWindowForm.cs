using GanduValorant.Services.ApplicationStatus;
using GanduValorant.Services.ColorCapturing;
using GanduValorant.Services.InputManagement.KeyboardControl;
using GanduValorant.Services.InputManagement.MouseControl;
using GanduValorant.Services.ConfigManager;
using GanduValorant.Models;
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

        private IConfigManager _configManager;
        private Config _currentConfig;
        

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public MainWindow(IPixleColorCapture IpixleColorCapture, IMouseController ImouseController, IKeyboardInputCapture IkeyboardInputCapture, IApplicationStatusManager ImanageApplicationStatus, IConfigManager configManager)
        {
            InitializeComponent();
            _pixleColorCapture = IpixleColorCapture;
            _mouseController = ImouseController;
            _keyboardInputCapture = IkeyboardInputCapture;
            _applicationStatusManager = ImanageApplicationStatus;
            _configManager = configManager;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainThread = new Thread(MainLoop);
            MainThread.Start();

            StartTriggerButton.Focus();
            _applicationStatusManager.SetApplicationStatus(AppStates.States.Running);

            _configManager.Init();
            _currentConfig = _configManager.Load();
            if (!_currentConfig.IsEmpty())
            {
                TriggerValues.SetTriggerConfig(_currentConfig);
            }

            TriggerDelayTimeNumeric.Value = TriggerValues.DelayTimeMS;
            PixleSensNumeric.Value = TriggerValues.PixleSensitivity;
            PixleWidthNumeric.Value = TriggerValues.TriggerPixleWidth;
            PixleHeightNumeric.Value = TriggerValues.TriggerPixleHeight;
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
                    if (_pixleColorCapture.IsColorFoundInScreenCenterSquare())
                    {
                        if (_keyboardInputCapture.isHoldingButton(Keys.Shift))
                        {
                            _mouseController.PressButton(MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP);
                            Thread.Sleep(TriggerValues.DelayTimeMS);
                        }
                    }

                }
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

        private void ConfirmChangesButton_Click(Object sender, EventArgs e)
        {
            _currentConfig = new Config((int)TriggerDelayTimeNumeric.Value, (int)PixleSensNumeric.Value, (int)PixleWidthNumeric.Value, (int)PixleHeightNumeric.Value);
            _configManager.Save(_currentConfig);
            TriggerValues.SetTriggerConfig(_currentConfig);
        }
    }
}
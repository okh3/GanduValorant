using GanduValorant.Services.InputManagement.MouseControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.InputManagement.KeyboardControl
{
    public class WinformKeyboardInputCapture : IKeyboardInputCapture
    {
        private bool _isButtonHeld = false;

        public bool isPressingButton(object sender, KeyEventArgs e, Keys button)
        {
            return e.KeyCode == button ? true : false;
        }

        public bool isHoldingButton(Keys button)
        {
            if (Control.ModifierKeys.HasFlag(button))
            {
                if (!_isButtonHeld)
                {
                    _isButtonHeld = true;
                }
            }
            else
            {
                _isButtonHeld = false;
            }
            return _isButtonHeld;
        }
    }
}

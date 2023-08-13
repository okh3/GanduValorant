using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.InputManagement.KeyboardControl
{
    public interface IKeyboardInputCapture
    {
        bool isPressingButton(object sender, KeyEventArgs e, Keys button);
        bool isHoldingButton(Keys button);
    }
}

using GanduValorant.Services.InputManagement.MouseControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.InputManagement.MouseControl
{
    public class MouseController : IMouseController
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public void PressButton(uint buttonDown, uint buttonUp)
        {
            mouse_event(buttonDown, 0, 0, 0, 0);

            mouse_event(buttonUp, 0, 0, 0, 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.InputManagement.MouseControl
{
    public interface IMouseController
    {
        void PressButton(uint buttonDown, uint buttonUp);
    }
}

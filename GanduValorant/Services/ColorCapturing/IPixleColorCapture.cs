using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.ColorCapturing
{
    public interface IPixleColorCapture
    {
        bool IsColorPresentAtCenter(Color color);
    }
}

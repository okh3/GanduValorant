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
        bool ISColorFoundAtPosition(Bitmap bitmap, Rectangle searchArea, Color targetColor, int pixelSensitivity);
        bool IsColorFoundInScreenCenterSquare();
    }
}

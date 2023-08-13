using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GanduValorant.Models.Constants;

namespace GanduValorant.Services.ColorCapturing
{
    public class BitMapPixleColorCapture : IPixleColorCapture
    {

        private bool AreColorsEqual(Color color1, Color color2)
        {
            return color1.R == color2.R && color1.G == color2.G && color1.B == color2.B;
        }

        private bool CheckColorPresence(Bitmap bitmap, Color targetColor)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    if (AreColorsEqual(pixelColor, targetColor))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsColorPresentAtCenter(Color targetColor)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int captureX = (screenWidth - TriggerConstants.TriggerPixleWidth) / 2; 
            int captureY = (screenHeight - TriggerConstants.TriggerPixleHeight) / 2; 

            Bitmap screenCapture = new Bitmap(TriggerConstants.TriggerPixleWidth, TriggerConstants.TriggerPixleHeight);

            using (Graphics g = Graphics.FromImage(screenCapture))
            {
                g.CopyFromScreen(captureX, captureY, 0, 0, new Size(TriggerConstants.TriggerPixleWidth, TriggerConstants.TriggerPixleHeight));
            }

            var isFound = CheckColorPresence(screenCapture, targetColor);

            screenCapture.Dispose();

            return isFound;
        }
    }
}

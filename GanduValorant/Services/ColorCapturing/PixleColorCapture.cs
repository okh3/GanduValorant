using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GanduValorant.Models.Constants;

namespace GanduValorant.Services.ColorCapturing
{
    public class PixleColorCapture : IPixleColorCapture
    {

        private bool AreColorsEqual(Color color1, Color color2, int sensitivity)
        {
            int rDiff = Math.Abs(color1.R - color2.R);
            int gDiff = Math.Abs(color1.G - color2.G);
            int bDiff = Math.Abs(color1.B - color2.B);

            return rDiff <= sensitivity && gDiff <= sensitivity && bDiff <= sensitivity;
        }

        private bool ReadColorAtCenter(Bitmap bitmap, Rectangle searchArea, Color targetColor, int pixelSensitivity)
        {
            for (int x = Math.Max(0, searchArea.Left); x < Math.Min(bitmap.Width, searchArea.Right); x++)
            {
                for (int y = Math.Max(0, searchArea.Top); y < Math.Min(bitmap.Height, searchArea.Bottom); y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    if (AreColorsEqual(pixelColor, targetColor, pixelSensitivity))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsColorPresentAtCenter()
        {
            using (Bitmap screenCapture = new Bitmap(TriggerConstants.screenWidth, TriggerConstants.screenHeight))
            using (Graphics g = Graphics.FromImage(screenCapture))
            {
                g.CopyFromScreen(0, 0, 0, 0, new Size(TriggerConstants.screenWidth, TriggerConstants.screenHeight));

                bool isColorPresent = ReadColorAtCenter(screenCapture, TriggerConstants.searchArea, TriggerConstants.PlayerOutlineColor, TriggerConstants.pixelSensitivity);
                return isColorPresent;
            }
        }
    }
}

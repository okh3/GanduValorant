using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GanduValorant.Models;

namespace GanduValorant.Services.ColorCapturing
{
    public class PixleColorCapture : IPixleColorCapture
    {
        /// <summary>
        /// Checks if the two given colors are equal with a given sensitivity
        /// </summary>
        /// <param name="color1"></param>
        /// <param name="color2"></param>
        /// <param name="sensitivity"></param> higher sensitivity = wider range of colors that will be calculated equal. Less = opposite of that until reaching one to one color.
        /// 
        /// <returns>boolean</returns>
        private bool AreColorsEqual(Color color1, Color color2, int sensitivity)
        {
            int rDiff = Math.Abs(color1.R - color2.R);
            int gDiff = Math.Abs(color1.G - color2.G);
            int bDiff = Math.Abs(color1.B - color2.B);

            return rDiff <= sensitivity && gDiff <= sensitivity && bDiff <= sensitivity;
        }

        /// <summary>
        /// Returns true if the color is found at the given searchArea (Rectangle) with use of AreColorsEqual function
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="searchArea"></param>
        /// <param name="targetColor"></param>
        /// <param name="pixelSensitivity"></param>
        /// <returns>Boolean</returns>
        public bool IsColorFoundAtPosition(Bitmap bitmap, Rectangle searchArea, Color targetColor, int pixelSensitivity)
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

        /// <summary>
        /// This function is solely for triggerbot, it checks if the color is present in rectangle with the given sensitivity (using trigger constants) 
        /// </summary>
        /// <returns>Boolean</returns>      
        public bool IsColorFoundInScreenCenterSquare()
        {
            using (Bitmap screenCapture = new Bitmap(TriggerValues.screenWidth, TriggerValues.screenHeight))
            using (Graphics g = Graphics.FromImage(screenCapture))
            {
                g.CopyFromScreen(0, 0, 0, 0, new Size(TriggerValues.screenWidth, TriggerValues.screenHeight));

                bool isColorPresent = IsColorFoundAtPosition(screenCapture, TriggerValues.searchArea, TriggerValues.PlayerOutlineColor, TriggerValues.PixleSensitivity);
                return isColorPresent;
            }
        }
    }
}

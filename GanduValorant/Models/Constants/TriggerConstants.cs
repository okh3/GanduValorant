using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Models.Constants
{
    public static class TriggerConstants
    {
        public static Color PlayerOutlineColor = Color.FromArgb(255, 254, 64);

        public static int DelayTimeMS = 1;
        public static int TriggerPixleWidth = 5;
        public static int TriggerPixleHeight = 5;

        public static int pixelSensitivity = 56;

        public static int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        public static int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        public static int captureX = (screenWidth - TriggerConstants.TriggerPixleWidth) / 2;
        public static int captureY = (screenHeight - TriggerConstants.TriggerPixleHeight) / 2;

        public static Rectangle searchArea = new Rectangle(TriggerConstants.captureX, TriggerConstants.captureY, TriggerConstants.TriggerPixleWidth, TriggerConstants.TriggerPixleHeight);
    }
}

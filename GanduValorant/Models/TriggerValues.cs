using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Models
{
    public static class TriggerValues
    {
        public static Color PlayerOutlineColor = Color.FromArgb(255, 254, 64);

        public static int DelayTimeMS = 1;
        public static int TriggerPixleWidth = 9;
        public static int TriggerPixleHeight = 9;

        public static int PixleSensitivity = 70;

        public static int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        public static int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        public static int captureX = (screenWidth - TriggerPixleWidth) / 2;
        public static int captureY = (screenHeight - TriggerPixleHeight) / 2;

        public static Rectangle searchArea = new Rectangle(captureX, captureY,  TriggerPixleWidth, TriggerPixleHeight);


        public static void SetTriggerConfig(Config config)
        {
            DelayTimeMS = config.DelayTimeMS;
            PixleSensitivity = config.PixleSensitivity;
            TriggerPixleWidth = config.TriggerPixleWidth;
            TriggerPixleHeight = config.TriggerPixleHeight;
        }
    }
}

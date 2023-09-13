using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Models
{
    public class Config
    {
        public Config(int delayTimeMS, int pixelSensitivity, int triggerPixleWidth, int triggerPixleHeight)
        {
            DelayTimeMS = delayTimeMS;
            TriggerPixleWidth = triggerPixleWidth;
            TriggerPixleHeight = triggerPixleHeight;
            PixleSensitivity = pixelSensitivity;
        }

        public int DelayTimeMS = 1;
        public int TriggerPixleWidth = 9;
        public int TriggerPixleHeight = 9;

        public int PixleSensitivity = 70;

        public bool IsEmpty()
        {
            if (DelayTimeMS == 0 && PixleSensitivity == 0 && TriggerPixleWidth == 0 && TriggerPixleHeight == 0)
            {
                return true;
            }
            return false;
        }
    }
}

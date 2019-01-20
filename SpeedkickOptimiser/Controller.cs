using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedkickOptimiser
{
    class Controller
    {
        public float rawStickX { get; set; }
        public float rawStickY { get; set; }
        public float stickX { get; set; }
        public float stickY { get; set; }
        public float stickMag { get; set; }
        public double stickAngle { get; set; }

        public Controller(int rawstickX, int rawstickY)
        {
            rawStickX = rawstickX;
            rawStickY = rawstickY;

            // reset the controller's x and y floats.
            stickX = 0;
            stickY = 0;

            // modulate the rawStickX and rawStickY to be the new float values by adding/subtracting 6.
            if (rawstickX <= -8)
                stickX = rawstickX + 6;

            if (rawstickX >= 8)
                stickX = rawstickX - 6;

            if (rawstickY <= -8)
                stickY = rawstickY + 6;

            if (rawstickY >= 8)
                stickY = rawstickY - 6;

            // calculate float magnitude from the center by vector length.
            stickMag = (float)Math.Sqrt((stickX * stickX) + (stickY * stickY));

            // magnitude cannot exceed 64.0f: if it does, modify the values appropriately to
            // flatten the values down to the allowed maximum value.
            if (stickMag > 64)
            {
                stickX *= 64 / stickMag;
                stickY *= 64 / stickMag;
                stickMag = 64;
            }

            stickAngle = Math.Atan2(stickY, stickX);
        }
    }
}

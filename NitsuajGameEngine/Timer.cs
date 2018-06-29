using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    class Timer
    {
        double timeSpan;
        double interval;

        public Timer(long MilliSecondInterval)
        {
            timeSpan = 0;//new TimeSpan();
            interval = MilliSecondInterval;//new TimeSpan(5);
        }

        public bool HasTimerElapsed(GameTime gameTime)
        {
            if(gameTime.TotalGameTime.TotalMilliseconds < timeSpan)
            {
                return false;
            }

            timeSpan = gameTime.TotalGameTime.TotalMilliseconds;
            timeSpan += interval;
            return true;
        }
    }
}

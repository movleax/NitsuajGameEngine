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
        TimeSpan timeSpan;
        TimeSpan interval;

        public Timer(long MilliSecondInterval)
        {
            timeSpan = new TimeSpan();
            interval = new TimeSpan(MilliSecondInterval * 10000);
            timeSpan.Add(interval);
        }

        public bool HasTimerElapsed(GameTime gameTime)
        {
            if(gameTime.TotalGameTime.Milliseconds < timeSpan.Milliseconds)
            {
                return false;
            }

            timeSpan = gameTime.TotalGameTime;
            timeSpan.Add(interval);
            return true;
        }
    }
}

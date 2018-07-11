using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace NitsuajGameEngine
{
    class Animation
    {
        long MilliSecondInterval;
        int Row;

        private Animation()
        {
            // hide default constructor
        }

        public Animation(int Row, long MilliSecondInterval)
        {
            this.MilliSecondInterval = MilliSecondInterval;
            this.Row = Row;
        }

        public long GetMillisecondInterval()
        {
            return MilliSecondInterval;
        }

        public int GetRow()
        {
            return Row;
        }
    }
}

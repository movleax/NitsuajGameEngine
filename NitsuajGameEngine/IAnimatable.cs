﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    interface IAnimatable
    {
        void DefineAnimation(string animationName, int Row, long MilliSecondInterval);
        void SetAnimation(string animationName);
        void UpdateAnimation(GameTime gameTime);
    }
}

﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    interface IMovable
    {
        void UpdatePosition();
        void SetVelocity(Vector2 newVel);
    }
}

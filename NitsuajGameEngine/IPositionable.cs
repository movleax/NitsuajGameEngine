using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    interface IPositionable
    {
        void SetPosition(Vector2 newPosition);
        void SetPosition(float X, float Y);
        Vector2 GetPosition();
    }
}

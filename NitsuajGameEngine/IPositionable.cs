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
        void SetVectorPosition(Vector2 newPosition);
        void SetVectorPosition(float X, float Y);
        Vector2 GetVectorPosition();
    }
}

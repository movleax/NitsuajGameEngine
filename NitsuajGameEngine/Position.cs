﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace NitsuajGameEngine
{
    public class Position : IPositionable
    {
        Vector2 PositionVector;

        public Position()
        {
            PositionVector = new Vector2(0, 0);
        }

        public Position(Vector2 coordinates)
        {
            PositionVector = new Vector2(coordinates.X, coordinates.Y);
        }

        public Vector2 GetVectorPosition()
        {
            return PositionVector;
        }

        public void SetVectorPosition(Vector2 newPosition)
        {
            PositionVector.X = newPosition.X;
            PositionVector.Y = newPosition.Y;
        }

        public void SetVectorPosition(float X, float Y)
        {
            PositionVector.X = X;
            PositionVector.Y = Y;
        }

        public float X
        {
            get { return PositionVector.X; }
        }

        public float Y
        {
            get { return PositionVector.Y; }
        }
    }
}

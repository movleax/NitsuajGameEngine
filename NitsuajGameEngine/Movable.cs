using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace NitsuajGameEngine
{
    class Movable : IMovable, IPositionable
    {
        Position position;
        Vector2 Velocity;

        public Movable()
        {
            Velocity = new Vector2();
            position = new Position();
        }

        public Movable(Position Pos)
        {
            this.position = Pos;
            Velocity = new Vector2();
        }

        public Movable(Vector2 PosVector)
        {
            this.position = new Position(PosVector);
        }

        public void SetVelocity(Vector2 newVel)
        {
            throw new NotImplementedException();
        }

        public void UpdatePosition()
        {
            SetPosition(this.position.X + Velocity.X, this.position.Y + Velocity.Y);
        }

        public Vector2 GetPosition()
        {
            throw new NotImplementedException();
        }

        public void SetPosition(Vector2 newPosition)
        {
            this.position.SetPosition(newPosition);
        }

        public void SetPosition(float X, float Y)
        {
            this.position.SetPosition(X, Y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace NitsuajGameEngine
{
    public class Player : GameObject, IMovable
    {
        public Player(string SpriteName)
            :base(SpriteName)
        {
            
        }

        public Player(string SpriteName, Position position)
            : base(SpriteName, position)
        {
            
        }

        public void SetVelocity(Vector2 newVel)
        {
            throw new NotImplementedException();
        }

        public void UpdatePosition()
        {
            throw new NotImplementedException();
        }
    }
}

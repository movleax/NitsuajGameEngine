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
        private Vector2 velocity;

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
            this.velocity = newVel;
        }

        public void Update(GameTime gameTime)
        {
            this.SetVectorPosition(this.GetVectorPosition() + velocity);

            this.UpdateAnimation(gameTime);
        }
    }
}

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    class MoveLeft : ICommand
    {
        Player character;
        Vector2 velocityVector;

        public MoveLeft(Player player)
        {
            this.character = player;
            this.velocityVector = new Vector2(-1, 0);
        }

        public void Execute()
        {
            character.SetVelocity(velocityVector);
            character.SetAnimation("MoveLeft");
        }
    }
}

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    class MoveRight : ICommand
    {
        Player character;
        Vector2 velocityVector;

        public MoveRight(Player player)
        {
            this.character = player;
            this.velocityVector = new Vector2(2, 0);
        }

        public void Execute()
        {
            character.SetVelocity(velocityVector);
            character.SetAnimation("MoveRight");
        }
    }
}

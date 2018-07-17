using Microsoft.Xna.Framework;

namespace NitsuajGameEngine
{
    internal class IdleDown : ICommand
    {
        Player character;
        Vector2 velocityVector;

        public IdleDown(Player player)
        {
            this.character = player;
            this.velocityVector = new Vector2(0, 0);
        }

        public void Execute()
        {
            character.SetVelocity(velocityVector);
            character.SetAnimation("IdleDown");
        }
    }
}
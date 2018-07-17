using Microsoft.Xna.Framework;

namespace NitsuajGameEngine
{
    internal class IdleUp : ICommand
    {
        Player character;
        Vector2 velocityVector;

        public IdleUp(Player player)
        {
            this.character = player;
            this.velocityVector = new Vector2(0, 0);
        }

        public void Execute()
        {
            character.SetVelocity(velocityVector);
            character.SetAnimation("IdleUp");
        }
    }
}
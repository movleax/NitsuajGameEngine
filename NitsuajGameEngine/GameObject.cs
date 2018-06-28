using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NitsuajGameEngine
{
    public abstract class GameObject : IDrawable, IPositionable, IAnimatable
    {
        private Sprite gameSprite;
        private Position position;

        public GameObject(string SpriteName)
        {
            gameSprite = ResourceManager.GetSprite(SpriteName);
            this.position = new Position();
        }

        public GameObject(string SpriteName, Position position)
        {
            gameSprite = ResourceManager.GetSprite(SpriteName);
            this.position = position;
        }

        public void DefineAnimation(string animationName, int Row)
        {
            gameSprite.DefineAnimation(animationName, Row);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            gameSprite.Draw(spriteBatch);
        }

        public Vector2 GetVectorPosition()
        {
            return position.GetVectorPosition();
        }

        public void UpdateAnimation(GameTime gameTime)
        {
            gameSprite.UpdateAnimation(gameTime);
        }

        public void SetAnimation(string animationName)
        {
            gameSprite.SetAnimation(animationName);
        }

        public void SetVectorPosition(Vector2 newPosition)
        {
            position.SetVectorPosition(newPosition);
            gameSprite.SetVectorPosition(newPosition);
        }

        public void SetVectorPosition(float X, float Y)
        {
            position.SetVectorPosition(X, Y);
            gameSprite.SetVectorPosition(X, Y);
        }
    }
}

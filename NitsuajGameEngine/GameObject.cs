using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NitsuajGameEngine
{
    public abstract class GameObject : IDrawable, IPositionable
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

        public void Draw(SpriteBatch spriteBatch)
        {
            gameSprite.Draw(spriteBatch);
        }

        public Vector2 GetVectorPosition()
        {
            return position.GetVectorPosition();
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

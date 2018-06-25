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

        //public GameObject(string SpriteName)
        //{
        //    gameSprite = ResourceManager.GetSprite(SpriteName);
        //}

        public void Draw(SpriteBatch spriteBatch)
        {
            gameSprite.Draw(spriteBatch);
        }

        public Vector2 GetVectorPosition()
        {
            throw new NotImplementedException();
        }

        public void SetVectorPosition(Vector2 newPosition)
        {
            throw new NotImplementedException();
        }

        public void SetVectorPosition(float X, float Y)
        {
            throw new NotImplementedException();
        }
    }
}

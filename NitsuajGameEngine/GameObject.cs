using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace NitsuajGameEngine
{
    class GameObject : IDrawable
    {
        private Sprite gameSprite;

        public GameObject(string SpriteName)
        {
            gameSprite = ResourceManager.GetSprite(SpriteName);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            gameSprite.Draw(spriteBatch);
        }
    }
}

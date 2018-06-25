using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    class SpritePrototype : IPrototype
    {
        private Texture2D Texture;
        private int Columns;
        private int Rows;

        public SpritePrototype(Texture2D Texture, int Columns, int Rows)
        {
            this.Texture = Texture;
            this.Columns = Columns;
            this.Rows = Rows;
        }

        public object Clone()
        {
            return new Sprite(Texture, Columns, Rows);
        }
    }
}

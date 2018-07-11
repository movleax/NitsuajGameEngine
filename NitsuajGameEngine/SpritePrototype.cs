using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    class SpritePrototype : IPrototype, IAnimatable
    {
        private Texture2D Texture;
        private int Columns;
        private int Rows;
        private Animator animator;

        public SpritePrototype(Texture2D Texture, int Columns, int Rows, Animator animator)
        {
            this.animator = animator;
            this.Texture = Texture;
            this.Columns = Columns;
            this.Rows = Rows;
        }

        public SpritePrototype(Texture2D Texture, long MilliSecondInterval, int Columns, int Rows)
        {
            this.animator = new Animator(Texture, MilliSecondInterval, Columns, Rows);
            this.Texture = Texture;
            this.Columns = Columns;
            this.Rows = Rows;
        }

        public object CreateCopy()
        {
            //var foo = this.MemberwiseClone();
            return new Sprite(Texture, Columns, Rows, new Animator(animator));
        }

        public void DefineAnimation(string animationName, int Row, long MilliSecondInterval)
        {
            animator.DefineAnimation(animationName, Row, MilliSecondInterval);
        }

        public void SetAnimation(string animationName)
        {
            animator.SetAnimation(animationName);
        }

        public void UpdateAnimation(GameTime gameTime)
        {
            animator.UpdateAnimation(gameTime);
        }
    }
}

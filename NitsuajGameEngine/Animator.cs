using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    class Animator : IAnimatable
    {
        private Rectangle drawRect;

        // Use these for clipping the sprite sheet
        private int rows;
        private int columns;
        private int clipWidth;
        private int clipHeight;
        private int currentFrame;
        private int totalFrames;

        private Timer timer;

        // Use this for storing sprite animations
        private Dictionary<string, Animation> animations;

        // copy constructor
        public Animator(Animator animator)
        {
            drawRect = new Rectangle(animator.drawRect.X, animator.drawRect.Y, animator.drawRect.Width, animator.drawRect.Height);

            animations = new Dictionary<string, Animation>(animator.animations);

            timer = animator.timer;

            rows = animator.rows;
            columns = animator.columns;
            clipWidth = animator.clipWidth;
            clipHeight = animator.clipHeight;
            currentFrame = animator.currentFrame;
            totalFrames = animator.totalFrames;
        }

        public Animator(Texture2D Texture, int Columns, int Rows)
        {
            rows = Rows;
            columns = Columns;
            currentFrame = 0;
            totalFrames = columns * rows;

            clipWidth = Texture.Width / columns;
            clipHeight = Texture.Height / rows;

            timer = new Timer(500);

            drawRect = new Rectangle(0, 0, clipWidth, clipHeight);
            animations = new Dictionary<string, Animation>();
        }

        public void DefineAnimation(string animationName, int Row, long MilliSecondInterval)
        {
            animations.Add(animationName, new Animation(Row, MilliSecondInterval));
        }

        public void SetAnimation(string animationName)
        {
            // don't attempt to change animations of there is no key that exists
            if (!animations.ContainsKey(animationName))
                return;

            drawRect.Y = animations[animationName].GetRow() * clipHeight;
            timer.SetInterval(animations[animationName].GetMillisecondInterval());
        }

        public void UpdateAnimation(GameTime gameTime)
        {
            if (!timer.HasTimerElapsed(gameTime))
                return;

            currentFrame = currentFrame < columns - 1 ? currentFrame + 1 : 0;

            drawRect.X = clipWidth * currentFrame;
        }

        public Rectangle GetDrawRect()
        {
            return drawRect;
        }
    }
}

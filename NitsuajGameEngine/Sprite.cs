using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace NitsuajGameEngine
{
    class Sprite
    {
        // Different properties for drawing the sprite
        private Texture2D texture;
        private Vector2 position;
        private Rectangle drawRect;
        private float alpha;
        private float rotation;
        private Vector2 origin;
        private float scale;
        private SpriteEffects spriteEffect;
        private float zDepth;

        // Use these for clipping the sprite sheet
        private int rows;
        private int columns;
        private int clipWidth;
        private int clipHeight;
        private int currentFrame;
        private int totalFrames;

        // Use this for storing sprite animations
        private Dictionary<string, int> animations;

        public Sprite(Texture2D Texture, int Columns, int Rows)
        {
            alpha = 1.0f;
            rotation = 0.0f;
            origin = new Vector2(0, 0);
            scale = 6.0f;
            spriteEffect = SpriteEffects.None;
            zDepth = 0.1f;

            texture = Texture;

            rows = Rows;
            columns = Columns;
            currentFrame = 0;
            totalFrames = columns * rows;

            clipWidth = texture.Width / columns;
            clipHeight = texture.Height / rows;
            animations = new Dictionary<string, int>();

            drawRect = new Rectangle(0, 0, clipWidth, clipHeight);
            position = new Vector2(0, 0);
        }

        public void DefineAnimation(string animationName, int Row)
        {
            animations.Add(animationName, Row);
        }

        public void SetAnimation(string animationName)
        {
            // don't attempt to change animations of there is no key that exists
            if (!animations.ContainsKey(animationName))
                return;

            drawRect.Y = animations[animationName] * clipHeight;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                            texture,
                            position,
                            drawRect,
                            Color.White * alpha,
                            rotation,
                            origin,
                            scale,
                            spriteEffect,
                            zDepth
                        );
        }

        public void IncrementFrame()
        {
            currentFrame = currentFrame < columns-1 ? currentFrame + 1 : 0;

            drawRect.X = clipWidth * currentFrame;
        }
    }
}

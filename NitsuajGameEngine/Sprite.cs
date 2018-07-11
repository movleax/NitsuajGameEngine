﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace NitsuajGameEngine
{
    class Sprite : IDrawable, IAnimatable
    {
        private Animator animator;

        // Different properties for drawing the sprite
        private Texture2D texture;
        private Position position;
        //private Rectangle drawRect;
        private float alpha;
        private float rotation;
        private Vector2 origin;
        private float scale;
        private SpriteEffects spriteEffect;
        private float zDepth;

        // Use these for clipping the sprite sheet
        //private int rows;
        //private int columns;
        //private int clipWidth;
        //private int clipHeight;
        //private int currentFrame;
        //private int totalFrames;

        // Use this for storing sprite animations
        //private Dictionary<string, int> animations;

        public Sprite(Texture2D Texture, int Columns, int Rows, Animator animator)
            //:base(Texture, Columns, Rows)
        {
            alpha = 1.0f;
            rotation = 0.0f;
            origin = new Vector2(0, 0);
            scale = 6.0f;
            spriteEffect = SpriteEffects.None;
            zDepth = 0.1f;

            texture = Texture;

            this.animator = animator;

            //rows = Rows;
            //columns = Columns;
            //currentFrame = 0;
            //totalFrames = columns * rows;
            //
            //clipWidth = texture.Width / columns;
            //clipHeight = texture.Height / rows;
            ////animations = new Dictionary<string, int>();
            //
            //drawRect = new Rectangle(0, 0, clipWidth, clipHeight);
            position = new Position(new Vector2(50, 0));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                            texture,
                            position.GetVectorPosition(),
                            animator.GetDrawRect()/*drawRect*/,
                            Color.White * alpha,
                            rotation,
                            origin,
                            scale,
                            spriteEffect,
                            zDepth
                        );
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

        public void SetVectorPosition(Vector2 newPosition)
        {
            position.SetVectorPosition(newPosition);
        }

        public void SetVectorPosition(float X, float Y)
        {
            position.SetVectorPosition(X, Y);
        }

        public Vector2 GetVectorPosition()
        {
            return position.GetVectorPosition();
        }
    }
}

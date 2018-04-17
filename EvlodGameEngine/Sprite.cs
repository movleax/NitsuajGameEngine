using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace EvlodGameEngine
{
    class Sprite
    {
        Texture2D texture;
        Vector2 position;
        Rectangle drawRect;
        float alpha;
        float rotation;
        Vector2 origin;
        float scale;
        SpriteEffects spriteEffect;
        float zDepth;

        int rows;
        int columns;
        int clipWidth;
        int clipHeight;
        int currentFrame;
        int totalFrames;


        public Sprite(Texture2D Texture, int Rows, int Columns)
        {
            alpha = 1.0f;
            rotation = 0.0f;
            origin = new Vector2(0, 0);
            scale = 1.0f;
            spriteEffect = SpriteEffects.None;
            zDepth = 0.1f;

            texture = Texture;

            rows = Rows;
            columns = Columns;
            currentFrame = 0;
            totalFrames = columns * rows;

            clipWidth = texture.Width / columns;
            clipHeight = texture.Height / rows;
            

            drawRect = new Rectangle(0, 0, texture.Width, texture.Height);
            position = new Vector2(0, 0);
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
            currentFrame = currentFrame < totalFrames ? currentFrame++ : 0;
        }
    }
}

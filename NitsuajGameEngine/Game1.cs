﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace NitsuajGameEngine
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Sprite testSprite;
        Sprite testSprite2;
        Player player;
        PlayerInput playerInput;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            SpritePrototype spriteProto = new SpritePrototype(this.Content.Load<Texture2D>("joe_test_anim"), 75, 6, 4);
            spriteProto.DefineAnimation("MoveRight", 0, 75);
            spriteProto.DefineAnimation("MoveLeft", 1, 75);
            spriteProto.DefineAnimation("IdleRight", 2, 175);
            spriteProto.DefineAnimation("IdleLeft", 3, 175);
            spriteProto.SetAnimation("IdleRight");
            ResourceManager.AddSprite("joe_test_anim", spriteProto);

            // TODO: use this.Content to load your game content here


            player = new Player("joe_test_anim", new Position(new Vector2(150, 150)));

            ICommand moveRightCommand = new MoveRight(player);
            ICommand moveLeftCommand = new MoveLeft(player);

            playerInput = new PlayerInput(moveRightCommand, moveLeftCommand, moveRightCommand, moveRightCommand, moveRightCommand);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                playerInput.MoveRight();
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                playerInput.MoveLeft();


            // TODO: Add your update logic here
            //if (k++ % 5 == 0)
            //    testSprite.IncrementFrame();

            player.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            player.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

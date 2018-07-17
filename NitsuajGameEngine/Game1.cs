using Microsoft.Xna.Framework;
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

            SpritePrototype spriteProto = new SpritePrototype(this.Content.Load<Texture2D>("joe_test_anim"), 6, 12);
            spriteProto.DefineAnimation("MoveRight", 0, 75);
            spriteProto.DefineAnimation("MoveLeft", 1, 75);
            spriteProto.DefineAnimation("IdleRight", 2, 175);
            spriteProto.DefineAnimation("IdleLeft", 3, 175);
            spriteProto.DefineAnimation("MoveUp", 4, 75);
            spriteProto.DefineAnimation("MoveDown", 5, 75);
            spriteProto.DefineAnimation("IdleUp", 6, 175);
            spriteProto.DefineAnimation("IdleDown", 7, 175);
            spriteProto.DefineAnimation("AttackRight", 8, 50);
            spriteProto.DefineAnimation("AttackLeft", 9, 50);
            spriteProto.DefineAnimation("AttackUp", 10, 50);
            spriteProto.DefineAnimation("AttackDown", 11, 50);
            spriteProto.SetAnimation("IdleDown");
            ResourceManager.AddSprite("joe_test_anim", spriteProto);

            // TODO: use this.Content to load your game content here


            player = new Player("joe_test_anim", new Position(new Vector2(150, 150)));

            ICommand moveRightCommand = new MoveRight(player);
            ICommand moveLeftCommand = new MoveLeft(player);
            ICommand moveUpCommand = new MoveUp(player);
            ICommand moveDownCommand = new MoveDown(player);
            ICommand idleLeftCommand = new IdleLeft(player);
            ICommand idleRightCommand = new IdleRight(player);
            ICommand idleUpCommand = new IdleUp(player);
            ICommand idleDownCommand = new IdleDown(player);
            ICommand attackLeftCommand = new AttackLeft(player);
            ICommand attackRightCommand = new AttackRight(player);
            ICommand attackUpCommand = new AttackUp(player);
            ICommand attackDownCommand = new AttackDown(player);

            playerInput = new PlayerInput(moveRightCommand, moveLeftCommand, moveUpCommand, moveDownCommand, idleRightCommand, idleLeftCommand, idleUpCommand, idleDownCommand, attackRightCommand, attackLeftCommand, attackUpCommand, attackDownCommand);
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

            if (Keyboard.GetState().IsKeyUp(Keys.Right) || Keyboard.GetState().IsKeyUp(Keys.Left) || Keyboard.GetState().IsKeyUp(Keys.Up) || Keyboard.GetState().IsKeyUp(Keys.Down))
                playerInput.Idle();
            if (Keyboard.GetState().IsKeyUp(Keys.Space))
            {
                playerInput.ResetAttack();
                playerInput.Idle();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
                playerInput.Attack();
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                playerInput.MoveRight();
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                playerInput.MoveLeft();
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                playerInput.MoveUp();
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                playerInput.MoveDown();

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

#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Media;
using GameUILibrary;
#endregion

namespace BasicUI_MonoGame_Android
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;

        private int nativeScreenWidth;
        private int nativeScreenHeight;

        private BasicUI basicUI;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreparingDeviceSettings += graphics_PreparingDeviceSettings;
        }

        private void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            nativeScreenWidth = graphics.PreferredBackBufferWidth;
            nativeScreenHeight = graphics.PreferredBackBufferHeight;

            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1080;
            graphics.PreferMultiSampling = true;
            graphics.PreferredDepthStencilFormat = DepthFormat.Depth24Stencil8;
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
            this.IsMouseVisible = true;

            FontManager.DefaultFont = Content.Load<SpriteFont>("Segoe_UI_10_Regular");
            Viewport viewport = GraphicsDevice.Viewport;
            basicUI = new BasicUI(viewport.Width, viewport.Height, this.GraphicsDevice, nativeScreenWidth, nativeScreenHeight);
            basicUI.DataContext = new BasicUIViewModel();
            FontManager.Instance.LoadFonts(Content);
            ImageManager.Instance.LoadImages(Content);
            SoundManager.Instance.LoadSounds(Content);

            RelayCommand command = new RelayCommand(new Action<object>(ExitEvent));

            KeyBinding keyBinding = new KeyBinding(command, Keys.Escape, ModifierKeys.None);
            basicUI.InputBindings.Add(keyBinding);
        }

        private void ExitEvent(object parameter)
        {
            Exit();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            basicUI.UpdateInput(gameTime);
            basicUI.UpdateLayout(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            basicUI.Draw(gameTime);

            base.Draw(gameTime);
        }
    }
}

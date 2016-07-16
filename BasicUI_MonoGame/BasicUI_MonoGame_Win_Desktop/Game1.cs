using System;
using System.Collections.Generic;
using System.Diagnostics;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Debug;
using EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Media;
using EmptyKeys.UserInterface.Media.Imaging;
using GameUILibrary;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

namespace BasicUI_MonoGame_Win_Desktop
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        private readonly Random random = new Random();

        GraphicsDeviceManager graphics;        

        private int nativeScreenWidth;
        private int nativeScreenHeight;
        private RenderTarget2D renderTarget;

        private BasicUI basicUI;
        private DebugViewModel debug;
        private BasicUIViewModel viewModel;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreparingDeviceSettings += graphics_PreparingDeviceSettings;            
            graphics.DeviceCreated += graphics_DeviceCreated;            
            Window.ClientSizeChanged += Window_ClientSizeChanged;
        }

        private void Window_ClientSizeChanged(object sender, EventArgs e)
        {
            if (basicUI != null)
            {
                Viewport viewPort = GraphicsDevice.Viewport;
                basicUI.Resize(viewPort.Width, viewPort.Height);                
            }
        }

        void graphics_DeviceCreated(object sender, EventArgs e)
        {
            Engine engine = new MonoGameEngine(GraphicsDevice, nativeScreenWidth, nativeScreenHeight);                    
        }

        private void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            nativeScreenWidth = graphics.PreferredBackBufferWidth;
            nativeScreenHeight = graphics.PreferredBackBufferHeight;

            graphics.PreferredBackBufferWidth = 1366;
            graphics.PreferredBackBufferHeight = 768;
            graphics.PreferMultiSampling = true;            
            graphics.GraphicsProfile = GraphicsProfile.HiDef;
            graphics.SynchronizeWithVerticalRetrace = true;
            graphics.PreferredDepthStencilFormat = DepthFormat.Depth24Stencil8;            
            e.GraphicsDeviceInformation.PresentationParameters.MultiSampleCount = 16;
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

            SpriteFont font = Content.Load<SpriteFont>("Segoe_UI_10_Regular");
            FontManager.DefaultFont = Engine.Instance.Renderer.CreateFont(font);
            Viewport viewport = GraphicsDevice.Viewport;
            basicUI = new BasicUI(viewport.Width, viewport.Height);
            viewModel = new BasicUIViewModel();
            viewModel.Tetris = new TetrisController(basicUI.TetrisContainer, basicUI.TetrisNextContainer);
            basicUI.DataContext = viewModel;
            debug = new DebugViewModel(basicUI);           

            FontManager.Instance.LoadFonts(Content);
            ImageManager.Instance.LoadImages(Content);
            SoundManager.Instance.LoadSounds(Content);

            RelayCommand command = new RelayCommand(new Action<object>(ExitEvent));

            KeyBinding keyBinding = new KeyBinding(command, KeyCode.Escape, ModifierKeys.None);
            basicUI.InputBindings.Add(keyBinding);

            RelayCommand tetrisLeft = new RelayCommand(new Action<object>(OnLeft));            
            KeyBinding left = new KeyBinding(tetrisLeft, KeyCode.A, ModifierKeys.None);
            basicUI.InputBindings.Add(left);

            RelayCommand tetrisRight = new RelayCommand(new Action<object>(OnRight));
            KeyBinding right = new KeyBinding(tetrisRight, KeyCode.D, ModifierKeys.None);
            basicUI.InputBindings.Add(right);

            RelayCommand tetrisDown = new RelayCommand(new Action<object>(OnDown));
            KeyBinding down = new KeyBinding(tetrisDown, KeyCode.S, ModifierKeys.None);
            basicUI.InputBindings.Add(down);

            RelayCommand tetrisRotate = new RelayCommand(new Action<object>(OnRotate));
            KeyBinding rotate = new KeyBinding(tetrisRotate, KeyCode.W, ModifierKeys.None);
            basicUI.InputBindings.Add(rotate);

            RelayCommand resizeCommand = new RelayCommand(new Action<object>(OnResize));
            KeyBinding resizeBinding = new KeyBinding(resizeCommand, KeyCode.R, ModifierKeys.Control);
            basicUI.InputBindings.Add(resizeBinding);

            renderTarget = new RenderTarget2D(GraphicsDevice,
                100,
                100,
                false,
                GraphicsDevice.PresentationParameters.BackBufferFormat,
                DepthFormat.Depth24Stencil8);

            viewModel.RenderTargetSource = new BitmapImage();
            var texture = Engine.Instance.Renderer.CreateTexture(renderTarget);
            viewModel.RenderTargetSource.Texture = texture;
        }

        private void OnResize(object obj)
        {            
            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1080;
            graphics.ApplyChanges();
        }

        private void OnRotate(object obj)
        {
            viewModel.Tetris.Rotate();
        }

        private void OnDown(object obj)
        {
            viewModel.Tetris.MoveDown();
        }

        private void OnRight(object obj)
        {            
            viewModel.Tetris.MoveRight();
        }

        private void OnLeft(object obj)
        {
            viewModel.Tetris.MoveLeft();
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
            debug.Update();
            basicUI.UpdateInput(gameTime.ElapsedGameTime.TotalMilliseconds);

            viewModel.Update(gameTime.ElapsedGameTime.TotalMilliseconds);
            basicUI.UpdateLayout(gameTime.ElapsedGameTime.TotalMilliseconds);

            base.Update(gameTime);


        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.SetRenderTarget(renderTarget);
            Color color = new Color();
            color.A = 255;
            color.R = (byte)random.Next(0, 255);
            color.G = (byte)random.Next(0, 255);
            color.B = (byte)random.Next(0, 255);
            GraphicsDevice.Clear(color);
            GraphicsDevice.SetRenderTarget(null);

            GraphicsDevice.Clear(Color.CornflowerBlue);

            basicUI.Draw(gameTime.ElapsedGameTime.TotalMilliseconds);
            debug.Draw();
            base.Draw(gameTime);
        }
    }
}

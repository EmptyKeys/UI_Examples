using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Media;
using GameLibrary.ViewModels;
using SynapseGaming.SunBurn.Framework.Core;
using SynapseGaming.SunBurn.Framework.Graphics;
using SynapseGaming.SunBurn.Framework.Graphics.Sprites;
using SynapseGaming.SunBurn.Framework.Input;
using SynapseGaming.SunBurn.Framework.Primitives;

namespace GameLibrary
{
    public class BasicUIScreen : GameScreen
    {
        private Color backgroundColor = new Color(64, 64, 64);

        private BasicUI basicUI;

        /// <summary>
        /// Called when the program switches to the screen. This is
        /// where screen assets are loaded and resources are created.
        /// </summary>
        public override void LoadContent()
        {
            InputDevice input = Platform.Instance.InputDevice;
            input.MouseState.Visible = true;

            Font font = BaseGameProgram.Instance.ContentDatabase.Load<Font>("Segoe_UI_10_Regular");
            FontManager.DefaultFont = Engine.Instance.Renderer.CreateFont(font);
            Viewport viewport = Platform.Instance.GraphicsDevice.Viewport;

            basicUI = new BasicUI(viewport.Width, viewport.Height);
            basicUI.DataContext = new BasicUIViewModel();

            FontManager.Instance.LoadFonts(BaseGameProgram.Instance.ContentDatabase);
            ImageManager.Instance.LoadImages(BaseGameProgram.Instance.ContentDatabase);
            SoundManager.Instance.LoadSounds(BaseGameProgram.Instance.ContentDatabase);

            RelayCommand command = new RelayCommand(new Action<object>(ExitEvent));

            KeyBinding keyBinding = new KeyBinding(command, KeyCode.Escape, ModifierKeys.None);
            basicUI.InputBindings.Add(keyBinding);
        }

        /// <summary>
        /// Called when the program switches away from this screen
        /// and is where screen resources are disposed.
        /// </summary>
        public override void UnloadContent()
        {
        }

        /// <summary>
        /// Allows the screen to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides the time elapsed since the last screen draw / update.</param>
        public override void Update(GameTime gameTime)
        {
            basicUI.UpdateInput(gameTime.ElapsedGameTime.TotalMilliseconds);
            basicUI.UpdateLayout(gameTime.ElapsedGameTime.TotalMilliseconds);
        }

        /// <summary>
        /// Allows the screen to render.
        /// </summary>
        /// <param name="gameTime">Provides the time elapsed since the last screen draw / update.</param>
        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice device = Platform.Instance.GraphicsDevice;
            device.Clear(backgroundColor);

            basicUI.Draw(gameTime.ElapsedGameTime.TotalMilliseconds);
        }

        private void StartGameEvent(object sender, RoutedEventArgs e)
        {
            Platform.Instance.SetGameScreen(new SimpleGameScreen());
        }

        private void ExitEvent(object parameter)
        {
            Platform.Instance.RunAsGameLoop.Exit();
        }

        public void InvalidateUserInterface()
        {
            Viewport viewport = Platform.Instance.GraphicsDevice.Viewport;
            basicUI.Width = viewport.Width;
            basicUI.Height = viewport.Height;
            basicUI.InvalidateMeasure();
        }
    }
}

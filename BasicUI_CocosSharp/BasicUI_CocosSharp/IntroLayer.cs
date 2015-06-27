using System;
using System.Collections.Generic;
using CocosSharp;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Debug;
using EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface.Media;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BasicUI_CocosSharp
{
    public class IntroLayer : CCLayerColor
    {
        private BasicUI root;
        private DebugViewModel debug;
        private float elapsedGameTime;

        public IntroLayer()
        {
            // setup our color for the background
            Color = new CCColor3B(CCColor4B.Blue);
            Opacity = 255;
        }

        protected override void AddedToScene()
        {
            base.AddedToScene();

            // Use the bounds to layout the positioning of our drawable assets
            var bounds = VisibleBoundsWorldspace;

            ContentManager content = Application.Game.Content;
            content.RootDirectory = Application.ContentRootDirectory;

            SpriteFont font = content.Load<SpriteFont>("fonts/Segoe_UI_10_Regular");
            FontManager.DefaultFont = Engine.Instance.Renderer.CreateFont(font);

            root = new BasicUI((int)bounds.Size.Width, (int)bounds.Size.Height);
            debug = new DebugViewModel(root);
            root.DataContext = new BasicUIViewModel();

            SoundManager.Instance.LoadSounds(content, "sounds");
            ImageManager.Instance.LoadImages(content);
            FontManager.Instance.LoadFonts(content, "fonts");

            Schedule(UpdateUI);

            // Register for touch events
            var touchListener = new CCEventListenerTouchAllAtOnce();
            touchListener.OnTouchesEnded = OnTouchesEnded;
            AddEventListener(touchListener, this);
        }

        private void UpdateUI(float frameTimeInSeconds)
        {
            elapsedGameTime = frameTimeInSeconds * 1000;
            debug.Update();
            root.UpdateInput(elapsedGameTime);
            root.UpdateLayout(elapsedGameTime);

        }

        protected override void VisitRenderer(ref CCAffineTransform worldTransform)
        {
            base.VisitRenderer(ref worldTransform);
            root.Draw(elapsedGameTime);
            debug.Draw();
        }

        void OnTouchesEnded(List<CCTouch> touches, CCEvent touchEvent)
        {
            if (touches.Count > 0)
            {
                // Perform touch handling here
            }
        }
    }
}


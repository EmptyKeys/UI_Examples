using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SynapseGaming.SunBurn.Framework.Content;
using SynapseGaming.SunBurn.Framework.Core;
using SynapseGaming.SunBurn.Framework.Graphics;
using SynapseGaming.SunBurn.Framework.Models;
using SynapseGaming.SunBurn.Engine.Core;
using SynapseGaming.SunBurn.Engine.Rendering;
using EmptyKeys.UserInterface;


namespace GameLibrary
{
    /// <summary>
    /// Base class for all platform specific program implementations.
    /// </summary>
    public abstract class BaseGameProgram : Program
    {
        // SunBurn Engine core system.
        private SunBurnCoreSystem sunBurnCoreSystem;
        private SplashScreenGameScreen splashScreenGameScreen;

        // Database of game assets.
        public ContentDatabase ContentDatabase { get; private set; }

        // Static access to the program instance.
        public static BaseGameProgram Instance { get; private set; }

        public BaseGameProgram()
        {
            Instance = this;

            Engine uiEngine = new SunBurnEngine();

            splashScreenGameScreen = new SplashScreenGameScreen();
            splashScreenGameScreen.DisplayCompleteEvent += new DisplayCompleteDelegate(OnSplashScreenDisplayCompleteEvent);
        }

        public abstract SystemPreferences GetSystemPreferences();
        public abstract void OnInitializeSceneInterface(SceneInterface sceneInterface);

        /// <summary>
        /// Initialize resources which should be available at any
        /// point during the game (eg: resources that are not screen specific).
        /// </summary>
        public override void OnPlatformInitializationComplete()
        {
            // Load the database of game assets.
            ContentDatabase = new ContentDatabase("GameContent");

            // Create the core system.
            sunBurnCoreSystem = new SunBurnCoreSystem(ContentDatabase);

            // Set the initial game screen.
            Platform.Instance.SetGameScreen(splashScreenGameScreen);
        }

        protected virtual void OnSplashScreenDisplayCompleteEvent(GameScreen sender)
        {
            Platform.Instance.SetGameScreen(new BasicUIScreen());
        }

        /// <summary>
        /// Cleanup any resources.
        /// </summary>
        public override void Dispose()
        {
            sunBurnCoreSystem.Unload();
            ContentDatabase.Unload();
        }
    }
}

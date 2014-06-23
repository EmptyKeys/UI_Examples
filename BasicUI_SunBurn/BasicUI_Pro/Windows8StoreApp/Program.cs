using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameLibrary;
using SynapseGaming.SunBurn.Framework.Content;
using SynapseGaming.SunBurn.Framework.Core;
using SynapseGaming.SunBurn.Framework.Graphics;
using SynapseGaming.SunBurn.Framework.Models;
using SynapseGaming.SunBurn.Engine.Core;

using TargetPlatform = SynapseGaming.SunBurn.Framework.Driver.DX11.DX11Platform;


namespace WindowsStore
{
    /// <summary>
    /// Entry point for games utilizing the built-in game loop
    /// (via Platform.RunAsGameLoop.Run()).
    /// 
    /// The platform layer automatically initializes itself and
    /// any needed platform resources (like a window, graphics device, ...).
    /// </summary>
    public class WindowsStoreProgram : BaseGameProgram
    {
        /// <summary>
        /// Main entry point for the game / application.
        /// </summary>
        [MTAThread]
        private static void Main()
        {
            using (Platform platform = new TargetPlatform(GraphicsProfile.Any))
                platform.RunAsGameLoop.Run<WindowsStoreProgram>();
        }

        public override SystemPreferences GetSystemPreferences()
        {
            // Create or load the platform preferences.
            SystemPreferences preferences = new SystemPreferences();

            preferences.EffectDetail = DetailPreference.High;
            preferences.LightingDetail = DetailPreference.High;
            preferences.ShadowDetail = DetailPreference.High;
            preferences.ShadowQuality = 1.0f;
            preferences.PostProcessingDetail = DetailPreference.High;
            preferences.TextureSampling = SamplingPreference.Anisotropic;
            preferences.MaxAnisotropy = 4;

            return preferences;
        }

        public override void OnInitializeSceneInterface(SceneInterface sceneInterface)
        {
        }

        /// <summary>
        /// Set and modify any platform specific presentation information.
        /// </summary>
        public override void OnPreparePresentationParameters(PresentationParameters parameters)
        {
            parameters.BackBufferWidth = 1920;
            parameters.BackBufferHeight = 1080;
            parameters.DepthStencilFormat = DepthFormat.Depth24Stencil8;
        }
    }
}

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

using TargetPlatform = SynapseGaming.SunBurn.Framework.Driver.GL2.GL2Platform;


namespace MacOSX
{
    /// <summary>
    /// Entry point for games utilizing the built-in game loop
    /// (via Platform.RunAsGameLoop.Run()).
    /// 
    /// The platform layer automatically initializes itself and
    /// any needed platform resources (like a window, graphics device, ...).
    /// </summary>
    public class MacOSXProgram : BaseGameProgram
    {
        /// <summary>
        /// Main entry point for the game / application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (Platform platform = new TargetPlatform(GraphicsProfile.DirectX9_3_SM3))
                platform.RunAsGameLoop.Run<MacOSXProgram>();
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
#if DEBUG
            SynapseGaming.SunBurn.Engine.Editor.SunBurnEditor editor = new SynapseGaming.SunBurn.Engine.Editor.SunBurnEditor(sceneInterface, true);
            sceneInterface.AddManager(editor);
#endif
        }

        /// <summary>
        /// Set and modify any platform specific presentation information.
        /// </summary>
        public override void OnPreparePresentationParameters(PresentationParameters parameters)
        {
            parameters.BackBufferWidth = 1280;
            parameters.BackBufferHeight = 720;
            parameters.DepthStencilFormat = DepthFormat.Depth24Stencil8;
        }
    }
}

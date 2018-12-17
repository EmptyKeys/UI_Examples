using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Debug;
using EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface.Media;
using EmptyKeys.UserInterface.Media.Effects;
using EmptyKeys.UserInterface.Renderers;
using Xenko.Core.Mathematics;
using Xenko.Engine;
using Xenko.Graphics;
using Xenko.Input;
using Xenko.Rendering;
using Xenko.Rendering.Compositing;

namespace BasicUI_Xenko
{
    public class BasicUIScript : AsyncScript
    {
        private BasicUI uiRoot;
        private DebugViewModel debug;
        private DelegateSceneRenderer customRenderDelegate;

        public override async Task Execute()
        {

            SpriteFont font = await Content.LoadAsync<SpriteFont>("Segoe_UI_10_Regular");
            FontManager.DefaultFont = Engine.Instance.Renderer.CreateFont(font);

            XenkoRenderer.GraphicsContext = Game.GraphicsContext;
            uiRoot = new BasicUI();
            debug = new DebugViewModel(uiRoot);
            uiRoot.DataContext = new BasicUIViewModel();
            
            FontManager.Instance.LoadFonts(Content);
            SoundManager.Instance.LoadSounds(Content);
            ImageManager.Instance.LoadImages(Content);
            EffectManager.Instance.LoadEffects(EffectSystem);

            var scene = SceneSystem.SceneInstance.RootScene;
            var compositor = SceneSystem.GraphicsCompositor;
            customRenderDelegate = new DelegateSceneRenderer(Render);
            ((SceneRendererCollection)((SceneCameraRenderer)compositor.Game).Child).Children.Add(customRenderDelegate);

            while (Game.IsRunning)
            {
                await Script.NextFrame();
                debug.Update();
                uiRoot.UpdateInput(Game.UpdateTime.Elapsed.TotalMilliseconds);
                uiRoot.UpdateLayout(Game.UpdateTime.Elapsed.TotalMilliseconds);
            }            
        }

        private void Render(RenderDrawContext obj)
        {
            uiRoot.Draw(Game.UpdateTime.Elapsed.TotalMilliseconds);
            debug.Draw();
        }
    }
}

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
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Engine;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Input;
using SiliconStudio.Xenko.Rendering;
using SiliconStudio.Xenko.Rendering.Composers;

namespace BasicUI_Xenko
{
    public class BasicUIScript : AsyncScript
    {
        private BasicUI uiRoot;
        private DebugViewModel debug;

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
            
            var scene = SceneSystem.SceneInstance.Scene;
            var compositor = ((SceneGraphicsCompositorLayers)scene.Settings.GraphicsCompositor);
            compositor.Master.Renderers.Add(new SceneDelegateRenderer(Render));

            while (Game.IsRunning)
            {
                await Script.NextFrame();
                debug.Update();
                uiRoot.UpdateInput(Game.UpdateTime.Elapsed.TotalMilliseconds);
                uiRoot.UpdateLayout(Game.UpdateTime.Elapsed.TotalMilliseconds);
            }            
        }

        private void Render(RenderDrawContext arg1, RenderFrame arg2)
        {
            uiRoot.Draw(Game.UpdateTime.Elapsed.TotalMilliseconds);
            debug.Draw();
        }        
    }
}

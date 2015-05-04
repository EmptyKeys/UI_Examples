using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface.Media;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Paradox.Engine;
using SiliconStudio.Paradox.Graphics;
using SiliconStudio.Paradox.Input;
using SiliconStudio.Paradox.Rendering;
using SiliconStudio.Paradox.Rendering.Composers;

namespace BasicUI_Paradox
{
    public class BasicUIScript : AsyncScript
    {
        private BasicUI uiRoot;

        public override async Task Execute()
        {

            SpriteFont font = await Asset.LoadAsync<SpriteFont>("Segoe_UI_10_Regular");
            FontManager.DefaultFont = Engine.Instance.Renderer.CreateFont(font);

            Viewport viewport = GraphicsDevice.Viewport;
            uiRoot = new BasicUI((int)viewport.Width, (int)viewport.Height);
            uiRoot.DataContext = new BasicUIViewModel();
            
            FontManager.Instance.LoadFonts(Asset);
            SoundManager.Instance.LoadSounds(Asset);
            ImageManager.Instance.LoadImages(Asset);
            
            var scene = SceneSystem.SceneInstance.Scene;
            var compositor = ((SceneGraphicsCompositorLayers)scene.Settings.GraphicsCompositor);
            compositor.Master.Renderers.Add(new SceneDelegateRenderer(Render));

            while (Game.IsRunning)
            {
                await Script.NextFrame();

                uiRoot.UpdateInput(Game.UpdateTime.Elapsed.TotalMilliseconds);
                uiRoot.UpdateLayout(Game.UpdateTime.Elapsed.TotalMilliseconds);
            }            
        }

        private void Render(RenderContext arg1, RenderFrame arg2)
        {
            uiRoot.Draw(Game.UpdateTime.Elapsed.TotalMilliseconds);
        }
    }
}

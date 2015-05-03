using System.Reflection;
using Microsoft.Xna.Framework;
using CocosSharp;
using CocosDenshion;
using EmptyKeys.UserInterface;

namespace BasicUI_CocosSharp
{
    public class AppDelegate : CCApplicationDelegate
    {

        public override void ApplicationDidFinishLaunching(CCApplication application, CCWindow mainWindow)
        {
            application.ContentRootDirectory = "Content";
            var windowSize = mainWindow.WindowSizeInPixels;

            int nativeWidth = application.GraphicsDevice.PresentationParameters.BackBufferWidth;
            int nativeHeight = application.GraphicsDevice.PresentationParameters.BackBufferHeight;

            CocosSharpEngine engine = new CocosSharpEngine(application.GraphicsDevice, nativeWidth, nativeHeight);

            var desiredWidth = 1280.0f;
            var desiredHeight = 720.0f;

            // This will set the world bounds to be (0,0, w, h)
            // CCSceneResolutionPolicy.ShowAll will ensure that the aspect ratio is preserved
            CCScene.SetDefaultDesignResolution(desiredWidth, desiredHeight, CCSceneResolutionPolicy.ShowAll);

            // Determine whether to use the high or low def versions of our images
            // Make sure the default texel to content size ratio is set correctly
            // Of course you're free to have a finer set of image resolutions e.g (ld, hd, super-hd)
            if (desiredWidth < windowSize.Width)
            {
                application.ContentSearchPaths.Add("hd");
                CCSprite.DefaultTexelToContentSizeRatio = 2.0f;
            }
            else
            {
                application.ContentSearchPaths.Add("ld");
                CCSprite.DefaultTexelToContentSizeRatio = 1.0f;
            }

            var scene = new CCScene(mainWindow);
            var introLayer = new IntroLayer();

            scene.AddChild(introLayer);

            mainWindow.RunWithScene(scene);
        }

        public override void ApplicationDidEnterBackground(CCApplication application)
        {
            application.Paused = true;
        }

        public override void ApplicationWillEnterForeground(CCApplication application)
        {
            application.Paused = false;
        }
    }
}
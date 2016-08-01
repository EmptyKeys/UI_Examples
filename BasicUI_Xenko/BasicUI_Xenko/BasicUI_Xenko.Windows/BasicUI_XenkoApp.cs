using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Input;
using SiliconStudio.Xenko.Engine;
using SiliconStudio.Xenko.Games;

namespace BasicUI_Xenko
{
    class BasicUI_XenkoApp
    {
        private static Game game;

        static void Main(string[] args)
        {
            // Profiler.EnableAll();
            using (game = new Game())
            {
                game.GraphicsDeviceManager.DeviceCreated += GraphicsDeviceManager_DeviceCreated;                
                game.Run();
            }
        }

        private static void GraphicsDeviceManager_DeviceCreated(object sender, System.EventArgs e)
        {
            GraphicsDeviceManager manager = sender as GraphicsDeviceManager;
            XenkoInputDevice.NativeInputManager = game.Input;
            Engine engine = new XenkoEngine(manager, game.EffectSystem);
        }
    }
}

using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Input;
using SiliconStudio.Xenko.Engine;
using SiliconStudio.Xenko.Games;

namespace BasicUI_Xenko
{
    class BasicUI_XenkoApp
    {
        static void Main(string[] args)
        {
            // Profiler.EnableAll();
            using (var game = new Game())
            {
                game.GraphicsDeviceManager.DeviceCreated += GraphicsDeviceManager_DeviceCreated;
                XenkoInputDevice.NativeInputManager = game.Input;
                game.Run();
            }
        }

        private static void GraphicsDeviceManager_DeviceCreated(object sender, System.EventArgs e)
        {
            GraphicsDeviceManager manager = sender as GraphicsDeviceManager;
            Engine engine = new XenkoEngine(manager, manager.GraphicsDevice.BackBuffer.Width, manager.GraphicsDevice.BackBuffer.Height);
        }
    }
}

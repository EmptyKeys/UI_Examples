using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Input;
using SiliconStudio.Paradox.Engine;
using SiliconStudio.Paradox.Games;

namespace BasicUI_Paradox
{
    class BasicUI_ParadoxApp
    {
        static void Main(string[] args)
        {
            // Profiler.EnableAll();
            using (var game = new Game())
            {
                game.GraphicsDeviceManager.DeviceCreated += GraphicsDeviceManager_DeviceCreated;
                ParadoxInputDevice.NativeInputManager = game.Input;
                game.Run();
            }
        }

        private static void GraphicsDeviceManager_DeviceCreated(object sender, System.EventArgs e)
        {
            GraphicsDeviceManager manager = sender as GraphicsDeviceManager;
            Engine engine = new ParadoxEngine(manager, manager.GraphicsDevice.BackBuffer.Width, manager.GraphicsDevice.BackBuffer.Height);
        }
    }
}

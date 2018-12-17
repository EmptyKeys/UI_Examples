using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Input;
using Xenko.Engine;
using Xenko.Games;

namespace BasicUI_Xenko
{
    class BasicUI_XenkoApp
    {
        private static Game game;

        static void Main(string[] args)
        {                        
            using (game = new Game())
            {
                game.GraphicsDeviceManager.DeviceCreated += GraphicsDeviceManager_DeviceCreated;
                game.GraphicsDeviceManager.PreparingDeviceSettings += GraphicsDeviceManager_PreparingDeviceSettings;
                game.Run();
            }
        }

        private static void GraphicsDeviceManager_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.MultisampleCount = Xenko.Graphics.MultisampleCount.None;
        }

        static void GraphicsDeviceManager_DeviceCreated(object sender, System.EventArgs e)
        {
            GraphicsDeviceManager manager = sender as GraphicsDeviceManager;
            XenkoInputDevice.NativeInputManager = game.Input;
            Engine engine = new XenkoEngine(manager, game.EffectSystem);
        }
    }
}

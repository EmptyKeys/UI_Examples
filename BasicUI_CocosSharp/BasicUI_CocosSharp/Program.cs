using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

using CocosSharp;

namespace BasicUI_CocosSharp
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            CCApplication application = new CCApplication(false, new CCSize(1280f, 720f));
            application.ApplicationDelegate = new AppDelegate();

            application.StartGame();
        }
    }


}


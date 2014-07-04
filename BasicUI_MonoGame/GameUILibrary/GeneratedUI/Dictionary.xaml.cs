// -----------------------------------------------------------
//  
//  This file was generated, please do not modify.
//  
// -----------------------------------------------------------
namespace EmptyKeys.UserInterface.Generated {
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using EmptyKeys.UserInterface;
    using EmptyKeys.UserInterface.Data;
    using EmptyKeys.UserInterface.Controls;
    using EmptyKeys.UserInterface.Controls.Primitives;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Themes;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "0.9.2.0")]
    public sealed class Dictionary : ResourceDictionary {
        
        private static Dictionary singleton = new Dictionary();
        
        public Dictionary() {
            this.InitializeResources();
        }
        
        public static Dictionary Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [Image] BitmapImage
            BitmapImage r_0_bm = new BitmapImage();
            r_0_bm.TextureAsset = "Images/MonogameLogo";
            ImageManager.Instance.AddImage("Images/MonogameLogo");
            this.Add("Image", r_0_bm);
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
        }
    }
}

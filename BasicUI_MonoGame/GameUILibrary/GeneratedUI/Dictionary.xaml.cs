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
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "1.3.0.0")]
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
            // Resource - [buttonStyle] Style
            var r_0_s_bo = this[typeof(Button)];
            Style r_0_s = new Style(typeof(Button), r_0_s_bo as Style);
            Setter r_0_s_S_0 = new Setter(Button.BackgroundProperty, new SolidColorBrush(new Color(255, 140, 0, 255)));
            r_0_s.Setters.Add(r_0_s_S_0);
            this.Add("buttonStyle", r_0_s);
            // Resource - [Sounds] SoundSourceCollection
            var r_1_sounds = new SoundSourceCollection();
            r_1_sounds.Add(new SoundSource { SoundType = SoundType.ButtonsClick, SoundAsset = "Click" });
            SoundManager.Instance.AddSound("Click");
            r_1_sounds.Add(new SoundSource { SoundType = SoundType.TextBoxKeyPress, SoundAsset = "KeyPress" });
            SoundManager.Instance.AddSound("KeyPress");
            r_1_sounds.Add(new SoundSource { SoundType = SoundType.TabControlMove, SoundAsset = "Move" });
            SoundManager.Instance.AddSound("Move");
            r_1_sounds.Add(new SoundSource { SoundType = SoundType.TabControlSelect, SoundAsset = "Select" });
            SoundManager.Instance.AddSound("Select");
            this.Add("Sounds", r_1_sounds);
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
            // Resource - [Image] BitmapImage
            BitmapImage r_3_bm = new BitmapImage();
            r_3_bm.TextureAsset = "Images/MonogameLogo";
            ImageManager.Instance.AddImage("Images/MonogameLogo");
            this.Add("Image", r_3_bm);
        }
    }
}

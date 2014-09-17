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
    using SynapseGaming.SunBurn.Framework.Primitives;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "0.9.9.0")]
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
            Setter r_0_s_S_1 = new Setter(Button.WidthProperty, 200F);
            r_0_s.Setters.Add(r_0_s_S_1);
            Setter r_0_s_S_2 = new Setter(Button.PaddingProperty, new Thickness(2F));
            r_0_s.Setters.Add(r_0_s_S_2);
            this.Add("buttonStyle", r_0_s);
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
            // Resource - [logoSunburn] BitmapImage
            BitmapImage r_2_bm = new BitmapImage();
            r_2_bm.TextureAsset = "Images/SunBurn";
            ImageManager.Instance.AddImage("Images/SunBurn");
            this.Add("logoSunburn", r_2_bm);
            // Resource - [logoEmptyKeys] BitmapImage
            BitmapImage r_3_bm = new BitmapImage();
            r_3_bm.TextureAsset = "Images/EmptyKeysLogoTextSmall";
            ImageManager.Instance.AddImage("Images/EmptyKeysLogoTextSmall");
            this.Add("logoEmptyKeys", r_3_bm);
            // Resource - [Sounds] SoundSourceCollection
            var r_4_sounds = new SoundSourceCollection();
            r_4_sounds.Add(new SoundSource { SoundType = SoundType.ButtonsClick, SoundAsset = "Click" });
            SoundManager.Instance.AddSound("Click");
            r_4_sounds.Add(new SoundSource { SoundType = SoundType.TextBoxKeyPress, SoundAsset = "KeyPress" });
            SoundManager.Instance.AddSound("KeyPress");
            r_4_sounds.Add(new SoundSource { SoundType = SoundType.TabControlMove, SoundAsset = "Move" });
            SoundManager.Instance.AddSound("Move");
            r_4_sounds.Add(new SoundSource { SoundType = SoundType.TabControlSelect, SoundAsset = "Select" });
            SoundManager.Instance.AddSound("Select");
            this.Add("Sounds", r_4_sounds);
            // Resource - [ToolTipText] String
            this.Add("ToolTipText", "Click to open message box");
        }
    }
}

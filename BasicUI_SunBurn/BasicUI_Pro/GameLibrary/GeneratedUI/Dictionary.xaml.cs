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
            // Resource - [buttonStyle] Style
            var r_0_s_bo = this[typeof(Button)];
            Style r_0_s = new Style(typeof(Button), r_0_s_bo as Style);
            Setter r_0_s_S_0 = new Setter(Button.BackgroundProperty, new SolidColorBrush(new Color(255, 140, 0, 255)));
            r_0_s.Setters.Add(r_0_s_S_0);
            this.Add("buttonStyle", r_0_s);
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
        }
    }
}

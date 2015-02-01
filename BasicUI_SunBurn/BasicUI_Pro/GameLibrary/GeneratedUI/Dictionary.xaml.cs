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
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Themes;
    using SynapseGaming.SunBurn.Framework.Primitives;
    
    
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
            // Resource - [ToolTipText] String
            this.Add("ToolTipText", "Click to open message box");
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
            // Resource - [logoSunburn] BitmapImage
            BitmapImage r_2_bm = new BitmapImage();
            r_2_bm.TextureAsset = "Images/SunBurn";
            ImageManager.Instance.AddImage("Images/SunBurn");
            this.Add("logoSunburn", r_2_bm);
            // Resource - [buttonStyle] Style
            var r_3_s_bo = this[typeof(Button)];
            Style r_3_s = new Style(typeof(Button), r_3_s_bo as Style);
            Setter r_3_s_S_0 = new Setter(Button.BackgroundProperty, new SolidColorBrush(new Color(255, 140, 0, 255)));
            r_3_s.Setters.Add(r_3_s_S_0);
            Setter r_3_s_S_1 = new Setter(Button.WidthProperty, 200F);
            r_3_s.Setters.Add(r_3_s_S_1);
            Setter r_3_s_S_2 = new Setter(Button.PaddingProperty, new Thickness(2F));
            r_3_s.Setters.Add(r_3_s_S_2);
            this.Add("buttonStyle", r_3_s);
            // Resource - [logoEmptyKeys] BitmapImage
            BitmapImage r_4_bm = new BitmapImage();
            r_4_bm.TextureAsset = "Images/EmptyKeysLogoTextSmall";
            ImageManager.Instance.AddImage("Images/EmptyKeysLogoTextSmall");
            this.Add("logoEmptyKeys", r_4_bm);
            // Resource - [buttonAnimStyle] Style
            var r_5_s_bo = this[typeof(Button)];
            Style r_5_s = new Style(typeof(Button), r_5_s_bo as Style);
            Setter r_5_s_S_0 = new Setter(Button.WidthProperty, 200F);
            r_5_s.Setters.Add(r_5_s_S_0);
            Setter r_5_s_S_1 = new Setter(Button.MarginProperty, new Thickness(0F, 1F, 0F, 1F));
            r_5_s.Setters.Add(r_5_s_S_1);
            Setter r_5_s_S_2 = new Setter(Button.SnapsToDevicePixelsProperty, false);
            r_5_s.Setters.Add(r_5_s_S_2);
            EventTrigger r_5_s_ET_0 = new EventTrigger(Button.MouseEnterEvent);
            r_5_s.Triggers.Add(r_5_s_ET_0);
            BeginStoryboard r_5_s_ET_0_AC_0 = new BeginStoryboard();
            r_5_s_ET_0_AC_0.Name = "r_5_s_ET_0_AC_0";
            r_5_s_ET_0.AddAction(r_5_s_ET_0_AC_0);
            Storyboard r_5_s_ET_0_AC_0_SB = new Storyboard();
            r_5_s_ET_0_AC_0.Storyboard = r_5_s_ET_0_AC_0_SB;
            r_5_s_ET_0_AC_0_SB.Name = "r_5_s_ET_0_AC_0_SB";
            ThicknessAnimation r_5_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_5_s_ET_0_AC_0_SB_TL_0.Name = "r_5_s_ET_0_AC_0_SB_TL_0";
            r_5_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_0_AC_0_SB_TL_0.From = new Thickness(0F, 1F, 0F, 1F);
            r_5_s_ET_0_AC_0_SB_TL_0.To = new Thickness(0F, 5F, 0F, 5F);
            SineEase r_5_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            r_5_s_ET_0_AC_0_SB_TL_0.EasingFunction = r_5_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_0_AC_0_SB_TL_0, Button.MarginProperty);
            r_5_s_ET_0_AC_0_SB.Children.Add(r_5_s_ET_0_AC_0_SB_TL_0);
            FloatAnimation r_5_s_ET_0_AC_0_SB_TL_1 = new FloatAnimation();
            r_5_s_ET_0_AC_0_SB_TL_1.Name = "r_5_s_ET_0_AC_0_SB_TL_1";
            r_5_s_ET_0_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_0_AC_0_SB_TL_1.To = 220F;
            SineEase r_5_s_ET_0_AC_0_SB_TL_1_EA = new SineEase();
            r_5_s_ET_0_AC_0_SB_TL_1.EasingFunction = r_5_s_ET_0_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_0_AC_0_SB_TL_1, Button.WidthProperty);
            r_5_s_ET_0_AC_0_SB.Children.Add(r_5_s_ET_0_AC_0_SB_TL_1);
            EventTrigger r_5_s_ET_1 = new EventTrigger(Button.MouseLeaveEvent);
            r_5_s.Triggers.Add(r_5_s_ET_1);
            BeginStoryboard r_5_s_ET_1_AC_0 = new BeginStoryboard();
            r_5_s_ET_1_AC_0.Name = "r_5_s_ET_1_AC_0";
            r_5_s_ET_1.AddAction(r_5_s_ET_1_AC_0);
            Storyboard r_5_s_ET_1_AC_0_SB = new Storyboard();
            r_5_s_ET_1_AC_0.Storyboard = r_5_s_ET_1_AC_0_SB;
            r_5_s_ET_1_AC_0_SB.Name = "r_5_s_ET_1_AC_0_SB";
            ThicknessAnimation r_5_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_5_s_ET_1_AC_0_SB_TL_0.Name = "r_5_s_ET_1_AC_0_SB_TL_0";
            r_5_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_1_AC_0_SB_TL_0.From = new Thickness(0F, 5F, 0F, 5F);
            r_5_s_ET_1_AC_0_SB_TL_0.To = new Thickness(0F, 1F, 0F, 1F);
            SineEase r_5_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            r_5_s_ET_1_AC_0_SB_TL_0.EasingFunction = r_5_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_1_AC_0_SB_TL_0, Button.MarginProperty);
            r_5_s_ET_1_AC_0_SB.Children.Add(r_5_s_ET_1_AC_0_SB_TL_0);
            FloatAnimation r_5_s_ET_1_AC_0_SB_TL_1 = new FloatAnimation();
            r_5_s_ET_1_AC_0_SB_TL_1.Name = "r_5_s_ET_1_AC_0_SB_TL_1";
            r_5_s_ET_1_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_1_AC_0_SB_TL_1.To = 200F;
            SineEase r_5_s_ET_1_AC_0_SB_TL_1_EA = new SineEase();
            r_5_s_ET_1_AC_0_SB_TL_1.EasingFunction = r_5_s_ET_1_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_1_AC_0_SB_TL_1, Button.WidthProperty);
            r_5_s_ET_1_AC_0_SB.Children.Add(r_5_s_ET_1_AC_0_SB_TL_1);
            this.Add("buttonAnimStyle", r_5_s);
            // Resource - [MessageBoxButtonYes] String
            this.Add("MessageBoxButtonYes", "Yes!");
            // Resource - [Sounds] SoundSourceCollection
            var r_7_sounds = new SoundSourceCollection();
            r_7_sounds.Add(new SoundSource { SoundType = SoundType.ButtonsClick, SoundAsset = "Click" });
            SoundManager.Instance.AddSound("Click");
            r_7_sounds.Add(new SoundSource { SoundType = SoundType.TextBoxKeyPress, SoundAsset = "KeyPress" });
            SoundManager.Instance.AddSound("KeyPress");
            r_7_sounds.Add(new SoundSource { SoundType = SoundType.TabControlMove, SoundAsset = "Move" });
            SoundManager.Instance.AddSound("Move");
            r_7_sounds.Add(new SoundSource { SoundType = SoundType.TabControlSelect, SoundAsset = "Select" });
            SoundManager.Instance.AddSound("Select");
            this.Add("Sounds", r_7_sounds);
        }
    }
}

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
    using EmptyKeys.UserInterface.Input;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Shapes;
    using EmptyKeys.UserInterface.Renderers;
    using EmptyKeys.UserInterface.Themes;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "1.6.5.0")]
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
            Setter r_0_s_S_0 = new Setter(Button.BackgroundProperty, new SolidColorBrush(new ColorW(255, 140, 0, 255)));
            r_0_s.Setters.Add(r_0_s_S_0);
            Setter r_0_s_S_1 = new Setter(Button.WidthProperty, 200F);
            r_0_s.Setters.Add(r_0_s_S_1);
            Setter r_0_s_S_2 = new Setter(Button.PaddingProperty, new Thickness(2F));
            r_0_s.Setters.Add(r_0_s_S_2);
            this.Add("buttonStyle", r_0_s);
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
            // Resource - [logoEmptyKeys] BitmapImage
            BitmapImage r_2_bm = new BitmapImage();
            r_2_bm.TextureAsset = "Images/EmptyKeysLogoTextSmall";
            ImageManager.Instance.AddImage("Images/EmptyKeysLogoTextSmall");
            this.Add("logoEmptyKeys", r_2_bm);
            // Resource - [buttonAnimStyle] Style
            var r_3_s_bo = this[typeof(Button)];
            Style r_3_s = new Style(typeof(Button), r_3_s_bo as Style);
            Setter r_3_s_S_0 = new Setter(Button.WidthProperty, 200F);
            r_3_s.Setters.Add(r_3_s_S_0);
            Setter r_3_s_S_1 = new Setter(Button.MarginProperty, new Thickness(0F, 1F, 0F, 1F));
            r_3_s.Setters.Add(r_3_s_S_1);
            Setter r_3_s_S_2 = new Setter(Button.SnapsToDevicePixelsProperty, false);
            r_3_s.Setters.Add(r_3_s_S_2);
            EventTrigger r_3_s_ET_0 = new EventTrigger(Button.MouseEnterEvent);
            r_3_s.Triggers.Add(r_3_s_ET_0);
            BeginStoryboard r_3_s_ET_0_AC_0 = new BeginStoryboard();
            r_3_s_ET_0_AC_0.Name = "r_3_s_ET_0_AC_0";
            r_3_s_ET_0.AddAction(r_3_s_ET_0_AC_0);
            Storyboard r_3_s_ET_0_AC_0_SB = new Storyboard();
            r_3_s_ET_0_AC_0.Storyboard = r_3_s_ET_0_AC_0_SB;
            r_3_s_ET_0_AC_0_SB.Name = "r_3_s_ET_0_AC_0_SB";
            ThicknessAnimation r_3_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_3_s_ET_0_AC_0_SB_TL_0.Name = "r_3_s_ET_0_AC_0_SB_TL_0";
            r_3_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_3_s_ET_0_AC_0_SB_TL_0.From = new Thickness(0F, 1F, 0F, 1F);
            r_3_s_ET_0_AC_0_SB_TL_0.To = new Thickness(0F, 5F, 0F, 5F);
            SineEase r_3_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            r_3_s_ET_0_AC_0_SB_TL_0.EasingFunction = r_3_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_3_s_ET_0_AC_0_SB_TL_0, Button.MarginProperty);
            r_3_s_ET_0_AC_0_SB.Children.Add(r_3_s_ET_0_AC_0_SB_TL_0);
            FloatAnimation r_3_s_ET_0_AC_0_SB_TL_1 = new FloatAnimation();
            r_3_s_ET_0_AC_0_SB_TL_1.Name = "r_3_s_ET_0_AC_0_SB_TL_1";
            r_3_s_ET_0_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_3_s_ET_0_AC_0_SB_TL_1.To = 220F;
            SineEase r_3_s_ET_0_AC_0_SB_TL_1_EA = new SineEase();
            r_3_s_ET_0_AC_0_SB_TL_1.EasingFunction = r_3_s_ET_0_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_3_s_ET_0_AC_0_SB_TL_1, Button.WidthProperty);
            r_3_s_ET_0_AC_0_SB.Children.Add(r_3_s_ET_0_AC_0_SB_TL_1);
            EventTrigger r_3_s_ET_1 = new EventTrigger(Button.MouseLeaveEvent);
            r_3_s.Triggers.Add(r_3_s_ET_1);
            BeginStoryboard r_3_s_ET_1_AC_0 = new BeginStoryboard();
            r_3_s_ET_1_AC_0.Name = "r_3_s_ET_1_AC_0";
            r_3_s_ET_1.AddAction(r_3_s_ET_1_AC_0);
            Storyboard r_3_s_ET_1_AC_0_SB = new Storyboard();
            r_3_s_ET_1_AC_0.Storyboard = r_3_s_ET_1_AC_0_SB;
            r_3_s_ET_1_AC_0_SB.Name = "r_3_s_ET_1_AC_0_SB";
            ThicknessAnimation r_3_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_3_s_ET_1_AC_0_SB_TL_0.Name = "r_3_s_ET_1_AC_0_SB_TL_0";
            r_3_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_3_s_ET_1_AC_0_SB_TL_0.From = new Thickness(0F, 5F, 0F, 5F);
            r_3_s_ET_1_AC_0_SB_TL_0.To = new Thickness(0F, 1F, 0F, 1F);
            SineEase r_3_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            r_3_s_ET_1_AC_0_SB_TL_0.EasingFunction = r_3_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_3_s_ET_1_AC_0_SB_TL_0, Button.MarginProperty);
            r_3_s_ET_1_AC_0_SB.Children.Add(r_3_s_ET_1_AC_0_SB_TL_0);
            FloatAnimation r_3_s_ET_1_AC_0_SB_TL_1 = new FloatAnimation();
            r_3_s_ET_1_AC_0_SB_TL_1.Name = "r_3_s_ET_1_AC_0_SB_TL_1";
            r_3_s_ET_1_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_3_s_ET_1_AC_0_SB_TL_1.To = 200F;
            SineEase r_3_s_ET_1_AC_0_SB_TL_1_EA = new SineEase();
            r_3_s_ET_1_AC_0_SB_TL_1.EasingFunction = r_3_s_ET_1_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_3_s_ET_1_AC_0_SB_TL_1, Button.WidthProperty);
            r_3_s_ET_1_AC_0_SB.Children.Add(r_3_s_ET_1_AC_0_SB_TL_1);
            this.Add("buttonAnimStyle", r_3_s);
            // Resource - [MessageBoxButtonYes] String
            this.Add("MessageBoxButtonYes", "Yes!");
            // Resource - [Sounds] SoundSourceCollection
            var r_5_sounds = new SoundSourceCollection();
            r_5_sounds.Add(new SoundSource { SoundType = SoundType.ButtonsClick, SoundAsset = "Click" });
            SoundManager.Instance.AddSound("Click");
            r_5_sounds.Add(new SoundSource { SoundType = SoundType.TextBoxKeyPress, SoundAsset = "KeyPress" });
            SoundManager.Instance.AddSound("KeyPress");
            r_5_sounds.Add(new SoundSource { SoundType = SoundType.TabControlMove, SoundAsset = "Move" });
            SoundManager.Instance.AddSound("Move");
            r_5_sounds.Add(new SoundSource { SoundType = SoundType.TabControlSelect, SoundAsset = "Select" });
            SoundManager.Instance.AddSound("Select");
            this.Add("Sounds", r_5_sounds);
            // Resource - [ToolTipText] String
            this.Add("ToolTipText", "Click to open message box");
        }
    }
}

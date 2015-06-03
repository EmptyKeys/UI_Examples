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
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "1.7.0.0")]
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
            this.Add("buttonStyle", r_0_s);
            // Resource - [Image] BitmapImage
            BitmapImage r_1_bm = new BitmapImage();
            r_1_bm.TextureAsset = "Images/MonoGameLogo";
            ImageManager.Instance.AddImage("Images/MonoGameLogo");
            this.Add("Image", r_1_bm);
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
            // Resource - [DataTemplateKey(GameData.CustomWindow)] DataTemplate
            Func<UIElement, UIElement> r_3_dtFunc = r_3_dtMethod;
            this.Add(typeof(GameData.CustomWindow), new DataTemplate(typeof(GameData.CustomWindow), r_3_dtFunc));
            // Resource - [CustomWindowTemplate] ControlTemplate
            Func<UIElement, UIElement> r_4_ctFunc = r_4_ctMethod;
            ControlTemplate r_4_ct = new ControlTemplate(r_4_ctFunc);
            this.Add("CustomWindowTemplate", r_4_ct);
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
            // Resource - [DataTemplateKey(GameData.TestTreeDataItem)] DataTemplate
            Func<UIElement, UIElement> r_6_dtFunc = r_6_dtMethod;
            this.Add(typeof(GameData.TestTreeDataItem), new DataTemplate(typeof(GameData.TestTreeDataItem), r_6_dtFunc));
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
        
        private static UIElement r_3_dtMethod(UIElement parent) {
            // e_32 element
            Border e_32 = new Border();
            e_32.Parent = parent;
            e_32.Name = "e_32";
            e_32.Background = new SolidColorBrush(new ColorW(0, 0, 255, 255));
            // e_33 element
            StackPanel e_33 = new StackPanel();
            e_32.Child = e_33;
            e_33.Name = "e_33";
            // e_34 element
            TextBlock e_34 = new TextBlock();
            e_33.Children.Add(e_34);
            e_34.Name = "e_34";
            e_34.HorizontalAlignment = HorizontalAlignment.Center;
            e_34.VerticalAlignment = VerticalAlignment.Center;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_34_Text = new Binding("TextData");
            e_34.SetBinding(TextBlock.TextProperty, binding_e_34_Text);
            // e_35 element
            Button e_35 = new Button();
            e_33.Children.Add(e_35);
            e_35.Name = "e_35";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_35.Content = "Hide Window";
            Binding binding_e_35_Command = new Binding("HideCommand");
            e_35.SetBinding(Button.CommandProperty, binding_e_35_Command);
            return e_32;
        }
        
        private static UIElement r_4_ctMethod(UIElement parent) {
            // e_36 element
            Grid e_36 = new Grid();
            e_36.Parent = parent;
            e_36.Name = "e_36";
            RowDefinition row_e_36_0 = new RowDefinition();
            row_e_36_0.Height = new GridLength(20F, GridUnitType.Pixel);
            e_36.RowDefinitions.Add(row_e_36_0);
            RowDefinition row_e_36_1 = new RowDefinition();
            e_36.RowDefinitions.Add(row_e_36_1);
            // PART_WindowTitleBorder element
            Border PART_WindowTitleBorder = new Border();
            e_36.Children.Add(PART_WindowTitleBorder);
            PART_WindowTitleBorder.Name = "PART_WindowTitleBorder";
            PART_WindowTitleBorder.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            // e_37 element
            ContentPresenter e_37 = new ContentPresenter();
            e_36.Children.Add(e_37);
            e_37.Name = "e_37";
            Grid.SetRow(e_37, 1);
            Binding binding_e_37_Content = new Binding();
            e_37.SetBinding(ContentPresenter.ContentProperty, binding_e_37_Content);
            return e_36;
        }
        
        private static UIElement r_6_dtMethod(UIElement parent) {
            // e_38 element
            TextBlock e_38 = new TextBlock();
            e_38.Parent = parent;
            e_38.Name = "e_38";
            e_38.Margin = new Thickness(2F, 2F, 2F, 2F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_38_Text = new Binding("Name");
            e_38.SetBinding(TextBlock.TextProperty, binding_e_38_Text);
            return e_38;
        }
    }
}

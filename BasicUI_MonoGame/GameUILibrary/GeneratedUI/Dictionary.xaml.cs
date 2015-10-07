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
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "1.9.0.0")]
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
            this.Add("Image", r_1_bm);
            // Resource - [TetrisWindowBackground] SolidColorBrush
            this.Add("TetrisWindowBackground", new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            // Resource - [CustomWindowTemplate] ControlTemplate
            Func<UIElement, UIElement> r_3_ctFunc = r_3_ctMethod;
            ControlTemplate r_3_ct = new ControlTemplate(r_3_ctFunc);
            this.Add("CustomWindowTemplate", r_3_ct);
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
            // Resource - [TetrisBorderStyle] Style
            Style r_5_s = new Style(typeof(Border));
            Setter r_5_s_S_0 = new Setter(Border.SnapsToDevicePixelsProperty, true);
            r_5_s.Setters.Add(r_5_s_S_0);
            Setter r_5_s_S_1 = new Setter(Border.BackgroundProperty, new ResourceReferenceExpression("TetrisWindowBackground"));
            r_5_s.Setters.Add(r_5_s_S_1);
            Setter r_5_s_S_2 = new Setter(Border.BorderBrushProperty, new ResourceReferenceExpression("TetrisBorderBrush"));
            r_5_s.Setters.Add(r_5_s_S_2);
            Setter r_5_s_S_3 = new Setter(Border.BorderThicknessProperty, new Thickness(1F));
            r_5_s.Setters.Add(r_5_s_S_3);
            Setter r_5_s_S_4 = new Setter(Border.OpacityProperty, 0.9F);
            r_5_s.Setters.Add(r_5_s_S_4);
            this.Add("TetrisBorderStyle", r_5_s);
            // Resource - [DataTemplateKey(GameData.TestTreeDataItem)] DataTemplate
            Func<UIElement, UIElement> r_6_dtFunc = r_6_dtMethod;
            this.Add(typeof(GameData.TestTreeDataItem), new DataTemplate(typeof(GameData.TestTreeDataItem), r_6_dtFunc));
            // Resource - [TetrisForeground] SolidColorBrush
            this.Add("TetrisForeground", new SolidColorBrush(new ColorW(255, 255, 255, 255)));
            // Resource - [buttonAnimStyle] Style
            var r_8_s_bo = this[typeof(Button)];
            Style r_8_s = new Style(typeof(Button), r_8_s_bo as Style);
            Setter r_8_s_S_0 = new Setter(Button.WidthProperty, 200F);
            r_8_s.Setters.Add(r_8_s_S_0);
            Setter r_8_s_S_1 = new Setter(Button.MarginProperty, new Thickness(0F, 1F, 0F, 1F));
            r_8_s.Setters.Add(r_8_s_S_1);
            Setter r_8_s_S_2 = new Setter(Button.SnapsToDevicePixelsProperty, false);
            r_8_s.Setters.Add(r_8_s_S_2);
            EventTrigger r_8_s_ET_0 = new EventTrigger(Button.MouseEnterEvent);
            r_8_s.Triggers.Add(r_8_s_ET_0);
            BeginStoryboard r_8_s_ET_0_AC_0 = new BeginStoryboard();
            r_8_s_ET_0_AC_0.Name = "r_8_s_ET_0_AC_0";
            r_8_s_ET_0.AddAction(r_8_s_ET_0_AC_0);
            Storyboard r_8_s_ET_0_AC_0_SB = new Storyboard();
            r_8_s_ET_0_AC_0.Storyboard = r_8_s_ET_0_AC_0_SB;
            r_8_s_ET_0_AC_0_SB.Name = "r_8_s_ET_0_AC_0_SB";
            ThicknessAnimation r_8_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_8_s_ET_0_AC_0_SB_TL_0.Name = "r_8_s_ET_0_AC_0_SB_TL_0";
            r_8_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_8_s_ET_0_AC_0_SB_TL_0.From = new Thickness(0F, 1F, 0F, 1F);
            r_8_s_ET_0_AC_0_SB_TL_0.To = new Thickness(0F, 5F, 0F, 5F);
            SineEase r_8_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            r_8_s_ET_0_AC_0_SB_TL_0.EasingFunction = r_8_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_8_s_ET_0_AC_0_SB_TL_0, Button.MarginProperty);
            r_8_s_ET_0_AC_0_SB.Children.Add(r_8_s_ET_0_AC_0_SB_TL_0);
            FloatAnimation r_8_s_ET_0_AC_0_SB_TL_1 = new FloatAnimation();
            r_8_s_ET_0_AC_0_SB_TL_1.Name = "r_8_s_ET_0_AC_0_SB_TL_1";
            r_8_s_ET_0_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_8_s_ET_0_AC_0_SB_TL_1.To = 220F;
            SineEase r_8_s_ET_0_AC_0_SB_TL_1_EA = new SineEase();
            r_8_s_ET_0_AC_0_SB_TL_1.EasingFunction = r_8_s_ET_0_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_8_s_ET_0_AC_0_SB_TL_1, Button.WidthProperty);
            r_8_s_ET_0_AC_0_SB.Children.Add(r_8_s_ET_0_AC_0_SB_TL_1);
            EventTrigger r_8_s_ET_1 = new EventTrigger(Button.MouseLeaveEvent);
            r_8_s.Triggers.Add(r_8_s_ET_1);
            BeginStoryboard r_8_s_ET_1_AC_0 = new BeginStoryboard();
            r_8_s_ET_1_AC_0.Name = "r_8_s_ET_1_AC_0";
            r_8_s_ET_1.AddAction(r_8_s_ET_1_AC_0);
            Storyboard r_8_s_ET_1_AC_0_SB = new Storyboard();
            r_8_s_ET_1_AC_0.Storyboard = r_8_s_ET_1_AC_0_SB;
            r_8_s_ET_1_AC_0_SB.Name = "r_8_s_ET_1_AC_0_SB";
            ThicknessAnimation r_8_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_8_s_ET_1_AC_0_SB_TL_0.Name = "r_8_s_ET_1_AC_0_SB_TL_0";
            r_8_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_8_s_ET_1_AC_0_SB_TL_0.From = new Thickness(0F, 5F, 0F, 5F);
            r_8_s_ET_1_AC_0_SB_TL_0.To = new Thickness(0F, 1F, 0F, 1F);
            SineEase r_8_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            r_8_s_ET_1_AC_0_SB_TL_0.EasingFunction = r_8_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_8_s_ET_1_AC_0_SB_TL_0, Button.MarginProperty);
            r_8_s_ET_1_AC_0_SB.Children.Add(r_8_s_ET_1_AC_0_SB_TL_0);
            FloatAnimation r_8_s_ET_1_AC_0_SB_TL_1 = new FloatAnimation();
            r_8_s_ET_1_AC_0_SB_TL_1.Name = "r_8_s_ET_1_AC_0_SB_TL_1";
            r_8_s_ET_1_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_8_s_ET_1_AC_0_SB_TL_1.To = 200F;
            SineEase r_8_s_ET_1_AC_0_SB_TL_1_EA = new SineEase();
            r_8_s_ET_1_AC_0_SB_TL_1.EasingFunction = r_8_s_ET_1_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_8_s_ET_1_AC_0_SB_TL_1, Button.WidthProperty);
            r_8_s_ET_1_AC_0_SB.Children.Add(r_8_s_ET_1_AC_0_SB_TL_1);
            this.Add("buttonAnimStyle", r_8_s);
            // Resource - [Sounds] SoundSourceCollection
            var r_9_sounds = new SoundSourceCollection();
            r_9_sounds.Add(new SoundSource { SoundType = SoundType.ButtonsClick, SoundAsset = "Click" });
            SoundManager.Instance.AddSound("Click");
            r_9_sounds.Add(new SoundSource { SoundType = SoundType.TextBoxKeyPress, SoundAsset = "KeyPress" });
            SoundManager.Instance.AddSound("KeyPress");
            r_9_sounds.Add(new SoundSource { SoundType = SoundType.TabControlMove, SoundAsset = "Move" });
            SoundManager.Instance.AddSound("Move");
            r_9_sounds.Add(new SoundSource { SoundType = SoundType.TabControlSelect, SoundAsset = "Select" });
            SoundManager.Instance.AddSound("Select");
            this.Add("Sounds", r_9_sounds);
            // Resource - [TetrisBorderBrush] SolidColorBrush
            this.Add("TetrisBorderBrush", new SolidColorBrush(new ColorW(114, 176, 218, 255)));
            // Resource - [DataTemplateKey(GameData.CustomWindow)] DataTemplate
            Func<UIElement, UIElement> r_11_dtFunc = r_11_dtMethod;
            this.Add(typeof(GameData.CustomWindow), new DataTemplate(typeof(GameData.CustomWindow), r_11_dtFunc));
            ImageManager.Instance.AddImage("Images/MonoGameLogo");
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Bold, "Segoe_UI_15_Bold");
        }
        
        private static UIElement r_3_ctMethod(UIElement parent) {
            // e_75 element
            Grid e_75 = new Grid();
            e_75.Parent = parent;
            e_75.Name = "e_75";
            RowDefinition row_e_75_0 = new RowDefinition();
            row_e_75_0.Height = new GridLength(20F, GridUnitType.Pixel);
            e_75.RowDefinitions.Add(row_e_75_0);
            RowDefinition row_e_75_1 = new RowDefinition();
            e_75.RowDefinitions.Add(row_e_75_1);
            // PART_WindowTitleBorder element
            Border PART_WindowTitleBorder = new Border();
            e_75.Children.Add(PART_WindowTitleBorder);
            PART_WindowTitleBorder.Name = "PART_WindowTitleBorder";
            PART_WindowTitleBorder.Background = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            // e_76 element
            ContentPresenter e_76 = new ContentPresenter();
            e_75.Children.Add(e_76);
            e_76.Name = "e_76";
            Grid.SetRow(e_76, 1);
            Binding binding_e_76_Content = new Binding();
            e_76.SetBinding(ContentPresenter.ContentProperty, binding_e_76_Content);
            return e_75;
        }
        
        private static UIElement r_6_dtMethod(UIElement parent) {
            // e_77 element
            TextBlock e_77 = new TextBlock();
            e_77.Parent = parent;
            e_77.Name = "e_77";
            e_77.Margin = new Thickness(2F, 2F, 2F, 2F);
            Binding binding_e_77_Text = new Binding("Name");
            e_77.SetBinding(TextBlock.TextProperty, binding_e_77_Text);
            return e_77;
        }
        
        private static UIElement r_11_dtMethod(UIElement parent) {
            // e_78 element
            Border e_78 = new Border();
            e_78.Parent = parent;
            e_78.Name = "e_78";
            e_78.Background = new SolidColorBrush(new ColorW(0, 0, 255, 255));
            // e_79 element
            StackPanel e_79 = new StackPanel();
            e_78.Child = e_79;
            e_79.Name = "e_79";
            // e_80 element
            TextBlock e_80 = new TextBlock();
            e_79.Children.Add(e_80);
            e_80.Name = "e_80";
            e_80.HorizontalAlignment = HorizontalAlignment.Center;
            e_80.VerticalAlignment = VerticalAlignment.Center;
            Binding binding_e_80_Text = new Binding("TextData");
            e_80.SetBinding(TextBlock.TextProperty, binding_e_80_Text);
            // e_81 element
            Button e_81 = new Button();
            e_79.Children.Add(e_81);
            e_81.Name = "e_81";
            e_81.Content = "Hide Window";
            Binding binding_e_81_Command = new Binding("HideCommand");
            e_81.SetBinding(Button.CommandProperty, binding_e_81_Command);
            return e_78;
        }
    }
}

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
    using EmptyKeys.UserInterface.Charts;
    using EmptyKeys.UserInterface.Data;
    using EmptyKeys.UserInterface.Controls;
    using EmptyKeys.UserInterface.Controls.Primitives;
    using EmptyKeys.UserInterface.Input;
    using EmptyKeys.UserInterface.Interactions.Core;
    using EmptyKeys.UserInterface.Interactivity;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Shapes;
    using EmptyKeys.UserInterface.Renderers;
    using EmptyKeys.UserInterface.Themes;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "1.13.0.0")]
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
            // Resource - [buttonAnimStyle] Style
            var r_0_s_bo = this[typeof(Button)];
            Style r_0_s = new Style(typeof(Button), r_0_s_bo as Style);
            Setter r_0_s_S_0 = new Setter(Button.WidthProperty, 200F);
            r_0_s.Setters.Add(r_0_s_S_0);
            Setter r_0_s_S_1 = new Setter(Button.MarginProperty, new Thickness(0F, 1F, 0F, 1F));
            r_0_s.Setters.Add(r_0_s_S_1);
            Setter r_0_s_S_2 = new Setter(Button.SnapsToDevicePixelsProperty, false);
            r_0_s.Setters.Add(r_0_s_S_2);
            EventTrigger r_0_s_ET_0 = new EventTrigger(Button.MouseEnterEvent);
            r_0_s.Triggers.Add(r_0_s_ET_0);
            BeginStoryboard r_0_s_ET_0_AC_0 = new BeginStoryboard();
            r_0_s_ET_0_AC_0.Name = "r_0_s_ET_0_AC_0";
            r_0_s_ET_0.AddAction(r_0_s_ET_0_AC_0);
            Storyboard r_0_s_ET_0_AC_0_SB = new Storyboard();
            r_0_s_ET_0_AC_0.Storyboard = r_0_s_ET_0_AC_0_SB;
            r_0_s_ET_0_AC_0_SB.Name = "r_0_s_ET_0_AC_0_SB";
            ThicknessAnimation r_0_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_0_s_ET_0_AC_0_SB_TL_0.Name = "r_0_s_ET_0_AC_0_SB_TL_0";
            r_0_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_0_s_ET_0_AC_0_SB_TL_0.From = new Thickness(0F, 1F, 0F, 1F);
            r_0_s_ET_0_AC_0_SB_TL_0.To = new Thickness(0F, 5F, 0F, 5F);
            SineEase r_0_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            r_0_s_ET_0_AC_0_SB_TL_0.EasingFunction = r_0_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_0_s_ET_0_AC_0_SB_TL_0, Button.MarginProperty);
            r_0_s_ET_0_AC_0_SB.Children.Add(r_0_s_ET_0_AC_0_SB_TL_0);
            FloatAnimation r_0_s_ET_0_AC_0_SB_TL_1 = new FloatAnimation();
            r_0_s_ET_0_AC_0_SB_TL_1.Name = "r_0_s_ET_0_AC_0_SB_TL_1";
            r_0_s_ET_0_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_0_s_ET_0_AC_0_SB_TL_1.To = 220F;
            SineEase r_0_s_ET_0_AC_0_SB_TL_1_EA = new SineEase();
            r_0_s_ET_0_AC_0_SB_TL_1.EasingFunction = r_0_s_ET_0_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_0_s_ET_0_AC_0_SB_TL_1, Button.WidthProperty);
            r_0_s_ET_0_AC_0_SB.Children.Add(r_0_s_ET_0_AC_0_SB_TL_1);
            EventTrigger r_0_s_ET_1 = new EventTrigger(Button.MouseLeaveEvent);
            r_0_s.Triggers.Add(r_0_s_ET_1);
            BeginStoryboard r_0_s_ET_1_AC_0 = new BeginStoryboard();
            r_0_s_ET_1_AC_0.Name = "r_0_s_ET_1_AC_0";
            r_0_s_ET_1.AddAction(r_0_s_ET_1_AC_0);
            Storyboard r_0_s_ET_1_AC_0_SB = new Storyboard();
            r_0_s_ET_1_AC_0.Storyboard = r_0_s_ET_1_AC_0_SB;
            r_0_s_ET_1_AC_0_SB.Name = "r_0_s_ET_1_AC_0_SB";
            ThicknessAnimation r_0_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_0_s_ET_1_AC_0_SB_TL_0.Name = "r_0_s_ET_1_AC_0_SB_TL_0";
            r_0_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_0_s_ET_1_AC_0_SB_TL_0.From = new Thickness(0F, 5F, 0F, 5F);
            r_0_s_ET_1_AC_0_SB_TL_0.To = new Thickness(0F, 1F, 0F, 1F);
            SineEase r_0_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            r_0_s_ET_1_AC_0_SB_TL_0.EasingFunction = r_0_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_0_s_ET_1_AC_0_SB_TL_0, Button.MarginProperty);
            r_0_s_ET_1_AC_0_SB.Children.Add(r_0_s_ET_1_AC_0_SB_TL_0);
            FloatAnimation r_0_s_ET_1_AC_0_SB_TL_1 = new FloatAnimation();
            r_0_s_ET_1_AC_0_SB_TL_1.Name = "r_0_s_ET_1_AC_0_SB_TL_1";
            r_0_s_ET_1_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_0_s_ET_1_AC_0_SB_TL_1.To = 200F;
            SineEase r_0_s_ET_1_AC_0_SB_TL_1_EA = new SineEase();
            r_0_s_ET_1_AC_0_SB_TL_1.EasingFunction = r_0_s_ET_1_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_0_s_ET_1_AC_0_SB_TL_1, Button.WidthProperty);
            r_0_s_ET_1_AC_0_SB.Children.Add(r_0_s_ET_1_AC_0_SB_TL_1);
            this.Add("buttonAnimStyle", r_0_s);
            // Resource - [buttonStyle] Style
            var r_1_s_bo = this[typeof(Button)];
            Style r_1_s = new Style(typeof(Button), r_1_s_bo as Style);
            Setter r_1_s_S_0 = new Setter(Button.BackgroundProperty, new SolidColorBrush(new ColorW(255, 140, 0, 255)));
            r_1_s.Setters.Add(r_1_s_S_0);
            this.Add("buttonStyle", r_1_s);
            // Resource - [CustomWindowTemplate] ControlTemplate
            Func<UIElement, UIElement> r_2_ctFunc = r_2_ctMethod;
            ControlTemplate r_2_ct = new ControlTemplate(r_2_ctFunc);
            this.Add("CustomWindowTemplate", r_2_ct);
            // Resource - [DataTemplateKey(GameData.CustomWindow)] DataTemplate
            Func<UIElement, UIElement> r_3_dtFunc = r_3_dtMethod;
            this.Add(typeof(GameData.CustomWindow), new DataTemplate(typeof(GameData.CustomWindow), r_3_dtFunc));
            // Resource - [DataTemplateKey(GameData.DragDropItem)] DataTemplate
            Func<UIElement, UIElement> r_4_dtFunc = r_4_dtMethod;
            this.Add(typeof(GameData.DragDropItem), new DataTemplate(typeof(GameData.DragDropItem), r_4_dtFunc));
            // Resource - [DataTemplateKey(GameData.TestTreeDataItem)] DataTemplate
            Func<UIElement, UIElement> r_5_dtFunc = r_5_dtMethod;
            this.Add(typeof(GameData.TestTreeDataItem), new DataTemplate(typeof(GameData.TestTreeDataItem), r_5_dtFunc));
            // Resource - [Image] BitmapImage
            BitmapImage r_6_bm = new BitmapImage();
            r_6_bm.TextureAsset = "Images/MonoGameLogo";
            this.Add("Image", r_6_bm);
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
            // Resource - [TetrisBorderBrush] SolidColorBrush
            this.Add("TetrisBorderBrush", new SolidColorBrush(new ColorW(114, 176, 218, 255)));
            // Resource - [TetrisBorderStyle] Style
            Style r_9_s = new Style(typeof(Border));
            Setter r_9_s_S_0 = new Setter(Border.SnapsToDevicePixelsProperty, true);
            r_9_s.Setters.Add(r_9_s_S_0);
            Setter r_9_s_S_1 = new Setter(Border.BackgroundProperty, new ResourceReferenceExpression("TetrisWindowBackground"));
            r_9_s.Setters.Add(r_9_s_S_1);
            Setter r_9_s_S_2 = new Setter(Border.BorderBrushProperty, new ResourceReferenceExpression("TetrisBorderBrush"));
            r_9_s.Setters.Add(r_9_s_S_2);
            Setter r_9_s_S_3 = new Setter(Border.BorderThicknessProperty, new Thickness(1F));
            r_9_s.Setters.Add(r_9_s_S_3);
            Setter r_9_s_S_4 = new Setter(Border.OpacityProperty, 0.9F);
            r_9_s.Setters.Add(r_9_s_S_4);
            this.Add("TetrisBorderStyle", r_9_s);
            // Resource - [TetrisForeground] SolidColorBrush
            this.Add("TetrisForeground", new SolidColorBrush(new ColorW(255, 255, 255, 255)));
            // Resource - [TetrisWindowBackground] SolidColorBrush
            this.Add("TetrisWindowBackground", new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
            ImageManager.Instance.AddImage("Images/MonoGameLogo");
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Bold, "Segoe_UI_15_Bold");
        }
        
        private static UIElement r_2_ctMethod(UIElement parent) {
            // e_0 element
            Grid e_0 = new Grid();
            e_0.Parent = parent;
            e_0.Name = "e_0";
            RowDefinition row_e_0_0 = new RowDefinition();
            row_e_0_0.Height = new GridLength(20F, GridUnitType.Pixel);
            e_0.RowDefinitions.Add(row_e_0_0);
            RowDefinition row_e_0_1 = new RowDefinition();
            e_0.RowDefinitions.Add(row_e_0_1);
            // PART_WindowTitleBorder element
            Border PART_WindowTitleBorder = new Border();
            e_0.Children.Add(PART_WindowTitleBorder);
            PART_WindowTitleBorder.Name = "PART_WindowTitleBorder";
            PART_WindowTitleBorder.Background = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            // e_1 element
            ContentPresenter e_1 = new ContentPresenter();
            e_0.Children.Add(e_1);
            e_1.Name = "e_1";
            Grid.SetRow(e_1, 1);
            Binding binding_e_1_Content = new Binding();
            e_1.SetBinding(ContentPresenter.ContentProperty, binding_e_1_Content);
            return e_0;
        }
        
        private static UIElement r_3_dtMethod(UIElement parent) {
            // e_2 element
            Border e_2 = new Border();
            e_2.Parent = parent;
            e_2.Name = "e_2";
            e_2.Background = new SolidColorBrush(new ColorW(0, 0, 255, 255));
            // e_3 element
            StackPanel e_3 = new StackPanel();
            e_2.Child = e_3;
            e_3.Name = "e_3";
            // e_4 element
            TextBlock e_4 = new TextBlock();
            e_3.Children.Add(e_4);
            e_4.Name = "e_4";
            e_4.HorizontalAlignment = HorizontalAlignment.Center;
            e_4.VerticalAlignment = VerticalAlignment.Center;
            Binding binding_e_4_Text = new Binding("TextData");
            e_4.SetBinding(TextBlock.TextProperty, binding_e_4_Text);
            // e_5 element
            Button e_5 = new Button();
            e_3.Children.Add(e_5);
            e_5.Name = "e_5";
            e_5.Content = "Hide Window";
            Binding binding_e_5_Command = new Binding("HideCommand");
            e_5.SetBinding(Button.CommandProperty, binding_e_5_Command);
            return e_2;
        }
        
        private static UIElement r_4_dtMethod(UIElement parent) {
            // e_6 element
            TextBlock e_6 = new TextBlock();
            e_6.Parent = parent;
            e_6.Name = "e_6";
            e_6.Margin = new Thickness(5F, 5F, 5F, 5F);
            Binding binding_e_6_Text = new Binding("Name");
            e_6.SetBinding(TextBlock.TextProperty, binding_e_6_Text);
            return e_6;
        }
        
        private static UIElement r_5_dtMethod(UIElement parent) {
            // e_7 element
            TextBlock e_7 = new TextBlock();
            e_7.Parent = parent;
            e_7.Name = "e_7";
            e_7.Margin = new Thickness(2F, 2F, 2F, 2F);
            Binding binding_e_7_Text = new Binding("Name");
            e_7.SetBinding(TextBlock.TextProperty, binding_e_7_Text);
            return e_7;
        }
    }
}

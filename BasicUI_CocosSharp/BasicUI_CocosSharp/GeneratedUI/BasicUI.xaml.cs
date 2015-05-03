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
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "1.6.0.0")]
    public partial class BasicUI : UIRoot {
        
        private Grid e_0;
        
        private StackPanel e_1;
        
        private Image logo;
        
        private TextBlock e_2;
        
        private StackPanel e_3;
        
        private ComboBox combo;
        
        private Button button1;
        
        private Button button2;
        
        private Button button3;
        
        private TextBlock buttonResult;
        
        private Slider slider;
        
        private TextBox textBox;
        
        private CheckBox checkBox;
        
        private TabControl e_5;
        
        private ProgressBar e_18;
        
        private StackPanel e_19;
        
        private Button animButton1;
        
        private Button animButton2;
        
        private Button animButton3;
        
        private Button animButton4;
        
        private Grid e_20;
        
        private Border animBorder1;
        
        private Border animBorder2;
        
        public BasicUI(int width, int height) : 
                base(width, height) {
            Style style = RootStyle.CreateRootStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.FontSize = 13.33333F;
            this.SetResourceReference(SoundManager.SoundsProperty, "Sounds");
            InitializeElementResources(this);
            // e_0 element
            this.e_0 = new Grid();
            this.Content = this.e_0;
            this.e_0.Name = "e_0";
            RowDefinition row_e_0_0 = new RowDefinition();
            row_e_0_0.Height = new GridLength(110F, GridUnitType.Pixel);
            this.e_0.RowDefinitions.Add(row_e_0_0);
            RowDefinition row_e_0_1 = new RowDefinition();
            this.e_0.RowDefinitions.Add(row_e_0_1);
            ColumnDefinition col_e_0_0 = new ColumnDefinition();
            this.e_0.ColumnDefinitions.Add(col_e_0_0);
            ColumnDefinition col_e_0_1 = new ColumnDefinition();
            this.e_0.ColumnDefinitions.Add(col_e_0_1);
            // e_1 element
            this.e_1 = new StackPanel();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            this.e_1.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Grid.SetColumnSpan(this.e_1, 2);
            // logo element
            this.logo = new Image();
            this.e_1.Children.Add(this.logo);
            this.logo.Name = "logo";
            this.logo.HorizontalAlignment = HorizontalAlignment.Center;
            BitmapImage logo_bm = new BitmapImage();
            logo_bm.TextureAsset = "Images/EmptyKeysLogoTextSmall";
            ImageManager.Instance.AddImage("Images/EmptyKeysLogoTextSmall");
            this.logo.Source = logo_bm;
            this.logo.Stretch = Stretch.None;
            this.logo.SetResourceReference(Image.SourceProperty, "logoEmptyKeys");
            // e_2 element
            this.e_2 = new TextBlock();
            this.e_1.Children.Add(this.e_2);
            this.e_2.Name = "e_2";
            this.e_2.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_2.VerticalAlignment = VerticalAlignment.Center;
            this.e_2.Foreground = new SolidColorBrush(new ColorW(211, 211, 211, 255));
            this.e_2.TextWrapping = TextWrapping.Wrap;
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Bold, "Segoe_UI_15_Bold");
            this.e_2.FontFamily = new FontFamily("Segoe UI");
            this.e_2.FontSize = 20F;
            this.e_2.FontStyle = FontStyle.Bold;
            this.e_2.SetResourceReference(TextBlock.TextProperty, "TitleResource");
            // e_3 element
            this.e_3 = new StackPanel();
            this.e_0.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            Grid.SetRow(this.e_3, 1);
            // combo element
            this.combo = new ComboBox();
            this.e_3.Children.Add(this.combo);
            this.combo.Name = "combo";
            this.combo.Width = 200F;
            this.combo.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            Func<UIElement, UIElement> combo_dtFunc = combo_dtMethod;
            this.combo.ItemTemplate = new DataTemplate(combo_dtFunc);
            Binding binding_combo_ItemsSource = new Binding("ComboBoxSource");
            this.combo.SetBinding(ComboBox.ItemsSourceProperty, binding_combo_ItemsSource);
            Binding binding_combo_SelectedIndex = new Binding("SelectedIndex");
            this.combo.SetBinding(ComboBox.SelectedIndexProperty, binding_combo_SelectedIndex);
            // button1 element
            this.button1 = new Button();
            this.e_3.Children.Add(this.button1);
            this.button1.Name = "button1";
            this.button1.Height = 30F;
            this.button1.Width = 200F;
            this.button1.Margin = new Thickness(5F, 5F, 5F, 5F);
            ToolTip tt_button1 = new ToolTip();
            this.button1.ToolTip = tt_button1;
            tt_button1.Content = "Click Me!";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.button1.Content = "1";
            this.button1.CommandParameter = "Click Button 1";
            Binding binding_button1_Command = new Binding("ButtonCommand");
            this.button1.SetBinding(Button.CommandProperty, binding_button1_Command);
            // button2 element
            this.button2 = new Button();
            this.e_3.Children.Add(this.button2);
            this.button2.Name = "button2";
            this.button2.Height = 30F;
            this.button2.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.button2.Content = "2";
            this.button2.CommandParameter = "Click Button 2";
            Binding binding_button2_Command = new Binding("ButtonCommand");
            this.button2.SetBinding(Button.CommandProperty, binding_button2_Command);
            this.button2.SetResourceReference(Button.StyleProperty, "buttonStyle");
            // button3 element
            this.button3 = new Button();
            this.e_3.Children.Add(this.button3);
            this.button3.Name = "button3";
            this.button3.Height = 30F;
            this.button3.Width = 200F;
            this.button3.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Bold, "Segoe_UI_15_Bold");
            this.button3.FontFamily = new FontFamily("Segoe UI");
            this.button3.FontSize = 20F;
            this.button3.FontStyle = FontStyle.Bold;
            this.button3.Content = "3";
            this.button3.CommandParameter = "Click Button 3";
            Binding binding_button3_Command = new Binding("OpenMessageBox");
            this.button3.SetBinding(Button.CommandProperty, binding_button3_Command);
            this.button3.SetResourceReference(Button.ToolTipProperty, "ToolTipText");
            // buttonResult element
            this.buttonResult = new TextBlock();
            this.e_3.Children.Add(this.buttonResult);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.HorizontalAlignment = HorizontalAlignment.Center;
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            Binding binding_buttonResult_Text = new Binding("ButtonResult");
            this.buttonResult.SetBinding(TextBlock.TextProperty, binding_buttonResult_Text);
            // slider element
            this.slider = new Slider();
            this.e_3.Children.Add(this.slider);
            this.slider.Name = "slider";
            this.slider.Width = 200F;
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.slider.Minimum = 5F;
            this.slider.Maximum = 20F;
            Binding binding_slider_Value = new Binding("SliderValue");
            this.slider.SetBinding(Slider.ValueProperty, binding_slider_Value);
            // textBox element
            this.textBox = new TextBox();
            this.e_3.Children.Add(this.textBox);
            this.textBox.Name = "textBox";
            this.textBox.Width = 200F;
            this.textBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            Binding binding_textBox_Text = new Binding("TextBoxText");
            this.textBox.SetBinding(TextBox.TextProperty, binding_textBox_Text);
            // checkBox element
            this.checkBox = new CheckBox();
            this.e_3.Children.Add(this.checkBox);
            this.checkBox.Name = "checkBox";
            this.checkBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.checkBox.HorizontalAlignment = HorizontalAlignment.Center;
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.checkBox.Content = "Check Box";
            // e_5 element
            this.e_5 = new TabControl();
            this.e_3.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
            this.e_5.Height = 150F;
            this.e_5.Width = 400F;
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.e_5.ItemsSource = this.Get_e_5_Items();
            // e_18 element
            this.e_18 = new ProgressBar();
            this.e_3.Children.Add(this.e_18);
            this.e_18.Name = "e_18";
            this.e_18.Height = 30F;
            this.e_18.Width = 400F;
            this.e_18.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.e_18.Value = 39F;
            // e_19 element
            this.e_19 = new StackPanel();
            this.e_0.Children.Add(this.e_19);
            this.e_19.Name = "e_19";
            Grid.SetColumn(this.e_19, 1);
            Grid.SetRow(this.e_19, 1);
            // animButton1 element
            this.animButton1 = new Button();
            this.e_19.Children.Add(this.animButton1);
            this.animButton1.Name = "animButton1";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.animButton1.Content = "Mouse Over me!";
            this.animButton1.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton2 element
            this.animButton2 = new Button();
            this.e_19.Children.Add(this.animButton2);
            this.animButton2.Name = "animButton2";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.animButton2.Content = "Mouse Over me!";
            this.animButton2.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton3 element
            this.animButton3 = new Button();
            this.e_19.Children.Add(this.animButton3);
            this.animButton3.Name = "animButton3";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.animButton3.Content = "Mouse Over me!";
            this.animButton3.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton4 element
            this.animButton4 = new Button();
            this.e_19.Children.Add(this.animButton4);
            this.animButton4.Name = "animButton4";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.animButton4.Content = "Mouse Over me!";
            this.animButton4.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // e_20 element
            this.e_20 = new Grid();
            this.e_19.Children.Add(this.e_20);
            this.e_20.Name = "e_20";
            // animBorder1 element
            this.animBorder1 = new Border();
            this.e_20.Children.Add(this.animBorder1);
            this.animBorder1.Name = "animBorder1";
            this.animBorder1.Height = 100F;
            this.animBorder1.Width = 200F;
            this.animBorder1.Margin = new Thickness(0F, 10F, 0F, 10F);
            EventTrigger animBorder1_ET_0 = new EventTrigger(Border.LoadedEvent, this.animBorder1);
            animBorder1.Triggers.Add(animBorder1_ET_0);
            BeginStoryboard animBorder1_ET_0_AC_0 = new BeginStoryboard();
            animBorder1_ET_0_AC_0.Name = "animBorder1_ET_0_AC_0";
            animBorder1_ET_0.AddAction(animBorder1_ET_0_AC_0);
            Storyboard animBorder1_ET_0_AC_0_SB = new Storyboard();
            animBorder1_ET_0_AC_0.Storyboard = animBorder1_ET_0_AC_0_SB;
            animBorder1_ET_0_AC_0_SB.Name = "animBorder1_ET_0_AC_0_SB";
            SolidColorBrushAnimation animBorder1_ET_0_AC_0_SB_TL_0 = new SolidColorBrushAnimation();
            animBorder1_ET_0_AC_0_SB_TL_0.Name = "animBorder1_ET_0_AC_0_SB_TL_0";
            animBorder1_ET_0_AC_0_SB_TL_0.AutoReverse = true;
            animBorder1_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 5, 0));
            animBorder1_ET_0_AC_0_SB_TL_0.RepeatBehavior = RepeatBehavior.Forever;
            animBorder1_ET_0_AC_0_SB_TL_0.From = new ColorW(255, 255, 0, 255);
            animBorder1_ET_0_AC_0_SB_TL_0.To = new ColorW(0, 0, 255, 255);
            ExponentialEase animBorder1_ET_0_AC_0_SB_TL_0_EA = new ExponentialEase();
            animBorder1_ET_0_AC_0_SB_TL_0.EasingFunction = animBorder1_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetName(animBorder1_ET_0_AC_0_SB_TL_0, "animBorder1");
            Storyboard.SetTargetProperty(animBorder1_ET_0_AC_0_SB_TL_0, Border.BackgroundProperty);
            animBorder1_ET_0_AC_0_SB.Children.Add(animBorder1_ET_0_AC_0_SB_TL_0);
            // animBorder2 element
            this.animBorder2 = new Border();
            this.e_20.Children.Add(this.animBorder2);
            this.animBorder2.Name = "animBorder2";
            this.animBorder2.Height = 50F;
            this.animBorder2.Width = 100F;
            this.animBorder2.Margin = new Thickness(50F, 35F, 50F, 35F);
            EventTrigger animBorder2_ET_0 = new EventTrigger(Border.LoadedEvent, this.animBorder2);
            animBorder2.Triggers.Add(animBorder2_ET_0);
            BeginStoryboard animBorder2_ET_0_AC_0 = new BeginStoryboard();
            animBorder2_ET_0_AC_0.Name = "animBorder2_ET_0_AC_0";
            animBorder2_ET_0.AddAction(animBorder2_ET_0_AC_0);
            Storyboard animBorder2_ET_0_AC_0_SB = new Storyboard();
            animBorder2_ET_0_AC_0.Storyboard = animBorder2_ET_0_AC_0_SB;
            animBorder2_ET_0_AC_0_SB.Name = "animBorder2_ET_0_AC_0_SB";
            SolidColorBrushAnimation animBorder2_ET_0_AC_0_SB_TL_0 = new SolidColorBrushAnimation();
            animBorder2_ET_0_AC_0_SB_TL_0.Name = "animBorder2_ET_0_AC_0_SB_TL_0";
            animBorder2_ET_0_AC_0_SB_TL_0.AutoReverse = true;
            animBorder2_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 3, 0));
            animBorder2_ET_0_AC_0_SB_TL_0.RepeatBehavior = RepeatBehavior.Forever;
            animBorder2_ET_0_AC_0_SB_TL_0.From = new ColorW(255, 0, 0, 255);
            animBorder2_ET_0_AC_0_SB_TL_0.To = new ColorW(255, 255, 255, 255);
            CubicEase animBorder2_ET_0_AC_0_SB_TL_0_EA = new CubicEase();
            animBorder2_ET_0_AC_0_SB_TL_0.EasingFunction = animBorder2_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetName(animBorder2_ET_0_AC_0_SB_TL_0, "animBorder2");
            Storyboard.SetTargetProperty(animBorder2_ET_0_AC_0_SB_TL_0, Border.BackgroundProperty);
            animBorder2_ET_0_AC_0_SB.Children.Add(animBorder2_ET_0_AC_0_SB_TL_0);
            FloatAnimation animBorder2_ET_0_AC_0_SB_TL_1 = new FloatAnimation();
            animBorder2_ET_0_AC_0_SB_TL_1.Name = "animBorder2_ET_0_AC_0_SB_TL_1";
            animBorder2_ET_0_AC_0_SB_TL_1.AutoReverse = true;
            animBorder2_ET_0_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 4, 0));
            animBorder2_ET_0_AC_0_SB_TL_1.RepeatBehavior = RepeatBehavior.Forever;
            animBorder2_ET_0_AC_0_SB_TL_1.From = 1F;
            animBorder2_ET_0_AC_0_SB_TL_1.To = 0F;
            Storyboard.SetTargetName(animBorder2_ET_0_AC_0_SB_TL_1, "animBorder2");
            Storyboard.SetTargetProperty(animBorder2_ET_0_AC_0_SB_TL_1, Border.OpacityProperty);
            animBorder2_ET_0_AC_0_SB.Children.Add(animBorder2_ET_0_AC_0_SB_TL_1);
        }
        
        private static void InitializeElementResources(UIElement elem) {
            elem.Resources.MergedDictionaries.Add(Dictionary.Instance);
        }
        
        private static UIElement combo_dtMethod(UIElement parent) {
            // e_4 element
            TextBlock e_4 = new TextBlock();
            e_4.Parent = parent;
            e_4.Name = "e_4";
            e_4.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_4.HorizontalAlignment = HorizontalAlignment.Center;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_4_Text = new Binding("Name");
            e_4.SetBinding(TextBlock.TextProperty, binding_e_4_Text);
            return e_4;
        }
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_e_5_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_6 element
            TabItem e_6 = new TabItem();
            e_6.Name = "e_6";
            e_6.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            e_6.Header = "Tab 1";
            // e_7 element
            ListBox e_7 = new ListBox();
            e_6.Content = e_7;
            e_7.Name = "e_7";
            e_7.Height = 100F;
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            Func<UIElement, UIElement> e_7_dtFunc = e_7_dtMethod;
            e_7.ItemTemplate = new DataTemplate(e_7_dtFunc);
            Binding binding_e_7_ItemsSource = new Binding("ComboBoxSource");
            e_7.SetBinding(ListBox.ItemsSourceProperty, binding_e_7_ItemsSource);
            Binding binding_e_7_SelectedItem = new Binding("SelectedItem");
            e_7.SetBinding(ListBox.SelectedItemProperty, binding_e_7_SelectedItem);
            items.Add(e_6);
            // e_9 element
            TabItem e_9 = new TabItem();
            e_9.Name = "e_9";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            e_9.Header = "Tab 2";
            // e_10 element
            StackPanel e_10 = new StackPanel();
            e_9.Content = e_10;
            e_10.Name = "e_10";
            // e_11 element
            ListBox e_11 = new ListBox();
            e_10.Children.Add(e_11);
            e_11.Name = "e_11";
            e_11.Height = 100F;
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            e_11.ItemsSource = this.Get_e_11_Items();
            items.Add(e_9);
            // e_16 element
            TabItem e_16 = new TabItem();
            e_16.Name = "e_16";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            e_16.Content = "Tab 3 Content";
            e_16.Header = "Tab 3";
            items.Add(e_16);
            // e_17 element
            TabItem e_17 = new TabItem();
            e_17.Name = "e_17";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            e_17.Content = "Tab 4 Content";
            e_17.Header = "Tab 4";
            items.Add(e_17);
            return items;
        }
        
        private static UIElement e_7_dtMethod(UIElement parent) {
            // e_8 element
            TextBlock e_8 = new TextBlock();
            e_8.Parent = parent;
            e_8.Name = "e_8";
            e_8.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_8.HorizontalAlignment = HorizontalAlignment.Center;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_8_Text = new Binding("Name");
            e_8.SetBinding(TextBlock.TextProperty, binding_e_8_Text);
            return e_8;
        }
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_e_11_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_12 element
            ListBoxItem e_12 = new ListBoxItem();
            e_12.Name = "e_12";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            e_12.Content = "Selection 1";
            items.Add(e_12);
            // e_13 element
            ListBoxItem e_13 = new ListBoxItem();
            e_13.Name = "e_13";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            e_13.Content = "Selection 2";
            items.Add(e_13);
            // e_14 element
            ListBoxItem e_14 = new ListBoxItem();
            e_14.Name = "e_14";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            e_14.Content = "Selection 3";
            items.Add(e_14);
            // e_15 element
            ListBoxItem e_15 = new ListBoxItem();
            e_15.Name = "e_15";
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            e_15.Content = "Selection 4";
            items.Add(e_15);
            return items;
        }
    }
}

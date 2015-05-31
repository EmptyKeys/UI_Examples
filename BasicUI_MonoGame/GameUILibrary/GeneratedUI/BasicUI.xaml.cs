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
    public partial class BasicUI : UIRoot {
        
        private Grid e_0;
        
        private StackPanel e_1;
        
        private Image logo;
        
        private TextBlock e_2;
        
        private StackPanel e_3;
        
        private ComboBox combo;
        
        private StackPanel e_4;
        
        private Button button1;
        
        private Button button2;
        
        private StackPanel e_5;
        
        private Button button3;
        
        private Button button4;
        
        private TextBlock buttonResult;
        
        private ProgressBar e_6;
        
        private Slider slider;
        
        private StackPanel e_7;
        
        private TextBox textBox;
        
        private CheckBox checkBox;
        
        private TabControl e_8;
        
        private StackPanel e_28;
        
        private Button animButton1;
        
        private Button animButton2;
        
        private Button animButton3;
        
        private Button animButton4;
        
        private Grid e_29;
        
        private Border animBorder1;
        
        private Border animBorder2;
        
        private Rectangle e_30;
        
        private Ellipse e_31;
        
        private Button imageButton;
        
        public BasicUI(int width, int height) : 
                base(width, height) {
            Style style = RootStyle.CreateRootStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
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
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.combo.ItemsSource = Get_combo_Items();
            this.combo.SelectedIndex = 2;
            // e_4 element
            this.e_4 = new StackPanel();
            this.e_3.Children.Add(this.e_4);
            this.e_4.Name = "e_4";
            this.e_4.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_4.Orientation = Orientation.Horizontal;
            // button1 element
            this.button1 = new Button();
            this.e_4.Children.Add(this.button1);
            this.button1.Name = "button1";
            this.button1.Height = 30F;
            this.button1.Width = 200F;
            this.button1.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.button1.Content = "1";
            this.button1.CommandParameter = "Click Button 1";
            Binding binding_button1_Command = new Binding("ButtonCommand");
            this.button1.SetBinding(Button.CommandProperty, binding_button1_Command);
            // button2 element
            this.button2 = new Button();
            this.e_4.Children.Add(this.button2);
            this.button2.Name = "button2";
            this.button2.Height = 30F;
            this.button2.Width = 200F;
            this.button2.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.button2.Content = "2";
            this.button2.CommandParameter = "Click Button 2";
            Binding binding_button2_Command = new Binding("ButtonCommand");
            this.button2.SetBinding(Button.CommandProperty, binding_button2_Command);
            this.button2.SetResourceReference(Button.StyleProperty, "buttonStyle");
            // e_5 element
            this.e_5 = new StackPanel();
            this.e_3.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
            this.e_5.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_5.Orientation = Orientation.Horizontal;
            // button3 element
            this.button3 = new Button();
            this.e_5.Children.Add(this.button3);
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
            Binding binding_button3_Command = new Binding("ButtonCommand");
            this.button3.SetBinding(Button.CommandProperty, binding_button3_Command);
            // button4 element
            this.button4 = new Button();
            this.e_5.Children.Add(this.button4);
            this.button4.Name = "button4";
            this.button4.Height = 30F;
            this.button4.Width = 200F;
            this.button4.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.button4.Content = "4";
            this.button4.CommandParameter = "Click Button 4";
            Binding binding_button4_IsEnabled = new Binding("ButtonEnabled");
            this.button4.SetBinding(Button.IsEnabledProperty, binding_button4_IsEnabled);
            Binding binding_button4_Command = new Binding("ButtonCommand");
            this.button4.SetBinding(Button.CommandProperty, binding_button4_Command);
            // buttonResult element
            this.buttonResult = new TextBlock();
            this.e_3.Children.Add(this.buttonResult);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.HorizontalAlignment = HorizontalAlignment.Center;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_buttonResult_Text = new Binding("ButtonResult");
            this.buttonResult.SetBinding(TextBlock.TextProperty, binding_buttonResult_Text);
            // e_6 element
            this.e_6 = new ProgressBar();
            this.e_3.Children.Add(this.e_6);
            this.e_6.Name = "e_6";
            this.e_6.Height = 30F;
            this.e_6.Width = 400F;
            this.e_6.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_6_Value = new Binding("ProgressValue");
            this.e_6.SetBinding(ProgressBar.ValueProperty, binding_e_6_Value);
            // slider element
            this.slider = new Slider();
            this.e_3.Children.Add(this.slider);
            this.slider.Name = "slider";
            this.slider.Width = 200F;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.slider.Minimum = 5F;
            this.slider.Maximum = 20F;
            Binding binding_slider_Value = new Binding("SliderValue");
            this.slider.SetBinding(Slider.ValueProperty, binding_slider_Value);
            // e_7 element
            this.e_7 = new StackPanel();
            this.e_3.Children.Add(this.e_7);
            this.e_7.Name = "e_7";
            this.e_7.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_7.Orientation = Orientation.Horizontal;
            // textBox element
            this.textBox = new TextBox();
            this.e_7.Children.Add(this.textBox);
            this.textBox.Name = "textBox";
            this.textBox.Width = 200F;
            this.textBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_textBox_Text = new Binding("TextBoxText");
            this.textBox.SetBinding(TextBox.TextProperty, binding_textBox_Text);
            // checkBox element
            this.checkBox = new CheckBox();
            this.e_7.Children.Add(this.checkBox);
            this.checkBox.Name = "checkBox";
            this.checkBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.checkBox.HorizontalAlignment = HorizontalAlignment.Center;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.checkBox.Content = "Check Box";
            // e_8 element
            this.e_8 = new TabControl();
            this.e_3.Children.Add(this.e_8);
            this.e_8.Name = "e_8";
            this.e_8.Height = 300F;
            this.e_8.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.e_8.ItemsSource = Get_e_8_Items();
            // e_28 element
            this.e_28 = new StackPanel();
            this.e_0.Children.Add(this.e_28);
            this.e_28.Name = "e_28";
            Grid.SetColumn(this.e_28, 1);
            Grid.SetRow(this.e_28, 1);
            // animButton1 element
            this.animButton1 = new Button();
            this.e_28.Children.Add(this.animButton1);
            this.animButton1.Name = "animButton1";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.animButton1.Content = "Mouse Over me!";
            this.animButton1.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton2 element
            this.animButton2 = new Button();
            this.e_28.Children.Add(this.animButton2);
            this.animButton2.Name = "animButton2";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.animButton2.Content = "Mouse Over me!";
            this.animButton2.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton3 element
            this.animButton3 = new Button();
            this.e_28.Children.Add(this.animButton3);
            this.animButton3.Name = "animButton3";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.animButton3.Content = "Mouse Over me!";
            this.animButton3.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton4 element
            this.animButton4 = new Button();
            this.e_28.Children.Add(this.animButton4);
            this.animButton4.Name = "animButton4";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.animButton4.Content = "Mouse Over me!";
            this.animButton4.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // e_29 element
            this.e_29 = new Grid();
            this.e_28.Children.Add(this.e_29);
            this.e_29.Name = "e_29";
            // animBorder1 element
            this.animBorder1 = new Border();
            this.e_29.Children.Add(this.animBorder1);
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
            this.e_29.Children.Add(this.animBorder2);
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
            // e_30 element
            this.e_30 = new Rectangle();
            this.e_28.Children.Add(this.e_30);
            this.e_30.Name = "e_30";
            this.e_30.Height = 100F;
            this.e_30.Width = 200F;
            this.e_30.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_30.Fill = new SolidColorBrush(new ColorW(0, 128, 0, 255));
            this.e_30.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            this.e_30.StrokeThickness = 5F;
            this.e_30.RadiusX = 10F;
            this.e_30.RadiusY = 10F;
            // e_31 element
            this.e_31 = new Ellipse();
            this.e_28.Children.Add(this.e_31);
            this.e_31.Name = "e_31";
            this.e_31.Height = 100F;
            this.e_31.Width = 200F;
            this.e_31.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_31.Fill = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            this.e_31.Stroke = new SolidColorBrush(new ColorW(0, 128, 0, 255));
            this.e_31.StrokeThickness = 10F;
            // imageButton element
            this.imageButton = new Button();
            this.e_28.Children.Add(this.imageButton);
            this.imageButton.Name = "imageButton";
            this.imageButton.Height = 48F;
            this.imageButton.Width = 48F;
            ImageBrush imageButton_Background = new ImageBrush();
            BitmapImage imageButton_Background_bm = new BitmapImage();
            imageButton_Background_bm.TextureAsset = "Images/MonoGameLogo";
            ImageManager.Instance.AddImage("Images/MonoGameLogo");
            imageButton_Background.ImageSource = imageButton_Background_bm;
            imageButton_Background.Stretch = Stretch.None;
            this.imageButton.Background = imageButton_Background;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
        }
        
        private static void InitializeElementResources(UIElement elem) {
            elem.Resources.MergedDictionaries.Add(Dictionary.Instance);
        }
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_combo_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // item1 element
            ComboBoxItem item1 = new ComboBoxItem();
            item1.Name = "item1";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            item1.Content = "Item 1";
            items.Add(item1);
            // item2 element
            ComboBoxItem item2 = new ComboBoxItem();
            item2.Name = "item2";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            item2.Content = "Item 2";
            items.Add(item2);
            // item3 element
            ComboBoxItem item3 = new ComboBoxItem();
            item3.Name = "item3";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            item3.Content = "Item 3";
            item3.IsSelected = true;
            items.Add(item3);
            return items;
        }
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_e_8_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_9 element
            TabItem e_9 = new TabItem();
            e_9.Name = "e_9";
            e_9.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_9.Header = "ListBox";
            // e_10 element
            ListBox e_10 = new ListBox();
            e_9.Content = e_10;
            e_10.Name = "e_10";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_10.ItemsSource = Get_e_10_Items();
            items.Add(e_9);
            // e_17 element
            TabItem e_17 = new TabItem();
            e_17.Name = "e_17";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_17.Header = "TreeView";
            // e_18 element
            TreeView e_18 = new TreeView();
            e_17.Content = e_18;
            e_18.Name = "e_18";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_18_ItemsSource = new Binding("TreeItems");
            e_18.SetBinding(TreeView.ItemsSourceProperty, binding_e_18_ItemsSource);
            items.Add(e_17);
            // e_19 element
            TabItem e_19 = new TabItem();
            e_19.Name = "e_19";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_19.Header = "DataGrid";
            // e_20 element
            DataGrid e_20 = new DataGrid();
            e_19.Content = e_20;
            e_20.Name = "e_20";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_20.AutoGenerateColumns = false;
            DataGridTextColumn e_20_Col0 = new DataGridTextColumn();
            e_20_Col0.Header = "#";
            Binding e_20_Col0_b = new Binding("Number");
            e_20_Col0.Binding = e_20_Col0_b;
            e_20.Columns.Add(e_20_Col0);
            DataGridTextColumn e_20_Col1 = new DataGridTextColumn();
            e_20_Col1.Header = "Text";
            Style e_20_Col1_e_s = new Style(typeof(DataGridCell));
            Setter e_20_Col1_e_s_S_0 = new Setter(DataGridCell.BackgroundProperty, new SolidColorBrush(new ColorW(128, 128, 128, 255)));
            e_20_Col1_e_s.Setters.Add(e_20_Col1_e_s_S_0);
            Setter e_20_Col1_e_s_S_1 = new Setter(DataGridCell.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            e_20_Col1_e_s.Setters.Add(e_20_Col1_e_s_S_1);
            Setter e_20_Col1_e_s_S_2 = new Setter(DataGridCell.VerticalAlignmentProperty, VerticalAlignment.Center);
            e_20_Col1_e_s.Setters.Add(e_20_Col1_e_s_S_2);
            e_20_Col1.ElementStyle = e_20_Col1_e_s;
            Binding e_20_Col1_b = new Binding("Text");
            e_20_Col1.Binding = e_20_Col1_b;
            e_20.Columns.Add(e_20_Col1);
            DataGridCheckBoxColumn e_20_Col2 = new DataGridCheckBoxColumn();
            e_20_Col2.Header = "Bool";
            Binding e_20_Col2_b = new Binding("Boolean");
            e_20_Col2.Binding = e_20_Col2_b;
            e_20.Columns.Add(e_20_Col2);
            DataGridTemplateColumn e_20_Col3 = new DataGridTemplateColumn();
            e_20_Col3.Width = 200F;
            // e_21 element
            TextBlock e_21 = new TextBlock();
            e_21.Name = "e_21";
            e_21.Text = "Template Column";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_20_Col3.Header = e_21;
            Style e_20_Col3_h_s = new Style(typeof(DataGridColumnHeader));
            Setter e_20_Col3_h_s_S_0 = new Setter(DataGridColumnHeader.ForegroundProperty, new SolidColorBrush(new ColorW(255, 165, 0, 255)));
            e_20_Col3_h_s.Setters.Add(e_20_Col3_h_s_S_0);
            e_20_Col3.HeaderStyle = e_20_Col3_h_s;
            Func<UIElement, UIElement> e_20_Col3_ct_dtFunc = e_20_Col3_ct_dtMethod;
            e_20_Col3.CellTemplate = new DataTemplate(e_20_Col3_ct_dtFunc);
            e_20.Columns.Add(e_20_Col3);
            Binding binding_e_20_ItemsSource = new Binding("GridData");
            e_20.SetBinding(DataGrid.ItemsSourceProperty, binding_e_20_ItemsSource);
            items.Add(e_19);
            // e_27 element
            TabItem e_27 = new TabItem();
            e_27.Name = "e_27";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_27.Content = "Tab 4 Content";
            e_27.Header = "Tab 4";
            items.Add(e_27);
            return items;
        }
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_e_10_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_11 element
            ListBoxItem e_11 = new ListBoxItem();
            e_11.Name = "e_11";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_11.Content = "Selection 1";
            items.Add(e_11);
            // e_12 element
            ListBoxItem e_12 = new ListBoxItem();
            e_12.Name = "e_12";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_12.Content = "Selection 2";
            items.Add(e_12);
            // e_13 element
            ListBoxItem e_13 = new ListBoxItem();
            e_13.Name = "e_13";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_13.Content = "Selection 3";
            items.Add(e_13);
            // e_14 element
            ListBoxItem e_14 = new ListBoxItem();
            e_14.Name = "e_14";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_14.Content = "Selection 4";
            items.Add(e_14);
            // e_15 element
            ListBoxItem e_15 = new ListBoxItem();
            e_15.Name = "e_15";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_15.Content = "Selection 5";
            items.Add(e_15);
            // e_16 element
            ListBoxItem e_16 = new ListBoxItem();
            e_16.Name = "e_16";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_16.Content = "Selection 6";
            items.Add(e_16);
            return items;
        }
        
        private static UIElement e_20_Col3_ct_dtMethod(UIElement parent) {
            // e_22 element
            StackPanel e_22 = new StackPanel();
            e_22.Parent = parent;
            e_22.Name = "e_22";
            // e_23 element
            TextBlock e_23 = new TextBlock();
            e_22.Children.Add(e_23);
            e_23.Name = "e_23";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_23_Text = new Binding("Text");
            e_23.SetBinding(TextBlock.TextProperty, binding_e_23_Text);
            // e_24 element
            StackPanel e_24 = new StackPanel();
            e_22.Children.Add(e_24);
            e_24.Name = "e_24";
            e_24.Orientation = Orientation.Horizontal;
            // e_25 element
            TextBlock e_25 = new TextBlock();
            e_24.Children.Add(e_25);
            e_25.Name = "e_25";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_25_Text = new Binding("Boolean");
            e_25.SetBinding(TextBlock.TextProperty, binding_e_25_Text);
            // e_26 element
            TextBlock e_26 = new TextBlock();
            e_24.Children.Add(e_26);
            e_26.Name = "e_26";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_26_Text = new Binding("Number");
            e_26.SetBinding(TextBlock.TextProperty, binding_e_26_Text);
            return e_22;
        }
    }
}

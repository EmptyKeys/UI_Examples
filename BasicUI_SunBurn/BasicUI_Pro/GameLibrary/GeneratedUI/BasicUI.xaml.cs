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
        
        private StackPanel e_5;
        
        private Slider slider;
        
        private TextBlock sliderValue;
        
        private TextBox textBox;
        
        private CheckBox checkBox;
        
        private TabControl e_6;
        
        private ProgressBar e_20;
        
        private Button imageButton;
        
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
            this.InitializeElementResources(this);
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
            // e_1 element
            this.e_1 = new StackPanel();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            this.e_1.Background = new SolidColorBrush(new Color(0, 0, 0, 255));
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
            this.e_2.Foreground = new Color(211, 211, 211, 255);
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
            Func<UIElement, UIElement> combo_dtFunc = (parent) => {
            return this.combo_dtMethod(parent);
            };
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
            Binding binding_buttonResult_Text = new Binding("ButtonResult");
            this.buttonResult.SetBinding(TextBlock.TextProperty, binding_buttonResult_Text);
            // e_5 element
            this.e_5 = new StackPanel();
            this.e_3.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
            this.e_5.Width = 200F;
            this.e_5.Orientation = Orientation.Horizontal;
            // slider element
            this.slider = new Slider();
            this.e_5.Children.Add(this.slider);
            this.slider.Name = "slider";
            this.slider.Width = 150F;
            this.slider.Minimum = 5F;
            this.slider.Maximum = 20F;
            Binding binding_slider_Value = new Binding("SliderValue");
            this.slider.SetBinding(Slider.ValueProperty, binding_slider_Value);
            // sliderValue element
            this.sliderValue = new TextBlock();
            this.e_5.Children.Add(this.sliderValue);
            this.sliderValue.Name = "sliderValue";
            this.sliderValue.Margin = new Thickness(5F, 5F, 5F, 5F);
            Binding binding_sliderValue_Text = new Binding("SliderValue");
            this.sliderValue.SetBinding(TextBlock.TextProperty, binding_sliderValue_Text);
            // textBox element
            this.textBox = new TextBox();
            this.e_3.Children.Add(this.textBox);
            this.textBox.Name = "textBox";
            this.textBox.Width = 200F;
            this.textBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            Binding binding_textBox_Text = new Binding("TextBoxText");
            this.textBox.SetBinding(TextBox.TextProperty, binding_textBox_Text);
            // checkBox element
            this.checkBox = new CheckBox();
            this.e_3.Children.Add(this.checkBox);
            this.checkBox.Name = "checkBox";
            this.checkBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.checkBox.HorizontalAlignment = HorizontalAlignment.Center;
            this.checkBox.Content = "Check Box";
            // e_6 element
            this.e_6 = new TabControl();
            this.e_3.Children.Add(this.e_6);
            this.e_6.Name = "e_6";
            this.e_6.Height = 150F;
            this.e_6.Width = 400F;
            this.e_6.ItemsSource = this.Get_e_6_Items();
            // e_20 element
            this.e_20 = new ProgressBar();
            this.e_3.Children.Add(this.e_20);
            this.e_20.Name = "e_20";
            this.e_20.Height = 30F;
            this.e_20.Width = 400F;
            this.e_20.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_20.Value = 39F;
            // imageButton element
            this.imageButton = new Button();
            this.e_3.Children.Add(this.imageButton);
            this.imageButton.Name = "imageButton";
            this.imageButton.Height = 68F;
            this.imageButton.Width = 57F;
            ImageBrush imageButton_Background = new ImageBrush();
            BitmapImage imageButton_Background_bm = new BitmapImage();
            imageButton_Background_bm.TextureAsset = "Images/SunBurn";
            ImageManager.Instance.AddImage("Images/SunBurn");
            imageButton_Background.ImageSource = imageButton_Background_bm;
            this.imageButton.Background = imageButton_Background;
        }
        
        private void InitializeElementResources(UIElement elem) {
            elem.Resources.MergedDictionaries.Add(Dictionary.Instance);
        }
        
        private UIElement combo_dtMethod(UIElement parent) {
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
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_e_6_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_7 element
            TabItem e_7 = new TabItem();
            e_7.Name = "e_7";
            e_7.Header = "Tab 1";
            // e_8 element
            StackPanel e_8 = new StackPanel();
            e_7.Content = e_8;
            e_8.Name = "e_8";
            // e_9 element
            ListBox e_9 = new ListBox();
            e_8.Children.Add(e_9);
            e_9.Name = "e_9";
            e_9.Height = 100F;
            Func<UIElement, UIElement> e_9_dtFunc = (parent) => {
            return this.e_9_dtMethod(parent);
            };
            e_9.ItemTemplate = new DataTemplate(e_9_dtFunc);
            Binding binding_e_9_ItemsSource = new Binding("ComboBoxSource");
            e_9.SetBinding(ListBox.ItemsSourceProperty, binding_e_9_ItemsSource);
            Binding binding_e_9_SelectedItem = new Binding("SelectedItem");
            e_9.SetBinding(ListBox.SelectedItemProperty, binding_e_9_SelectedItem);
            items.Add(e_7);
            // e_11 element
            TabItem e_11 = new TabItem();
            e_11.Name = "e_11";
            e_11.Header = "Tab 2";
            // e_12 element
            StackPanel e_12 = new StackPanel();
            e_11.Content = e_12;
            e_12.Name = "e_12";
            // e_13 element
            ListBox e_13 = new ListBox();
            e_12.Children.Add(e_13);
            e_13.Name = "e_13";
            e_13.Height = 100F;
            e_13.ItemsSource = this.Get_e_13_Items();
            items.Add(e_11);
            // e_18 element
            TabItem e_18 = new TabItem();
            e_18.Name = "e_18";
            e_18.Content = "Tab 3 Content";
            e_18.Header = "Tab 3";
            items.Add(e_18);
            // e_19 element
            TabItem e_19 = new TabItem();
            e_19.Name = "e_19";
            e_19.Content = "Tab 4 Content";
            e_19.Header = "Tab 4";
            items.Add(e_19);
            return items;
        }
        
        private UIElement e_9_dtMethod(UIElement parent) {
            // e_10 element
            TextBlock e_10 = new TextBlock();
            e_10.Parent = parent;
            e_10.Name = "e_10";
            e_10.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_10.HorizontalAlignment = HorizontalAlignment.Center;
            Binding binding_e_10_Text = new Binding("Name");
            e_10.SetBinding(TextBlock.TextProperty, binding_e_10_Text);
            return e_10;
        }
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_e_13_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_14 element
            ListBoxItem e_14 = new ListBoxItem();
            e_14.Name = "e_14";
            e_14.Content = "Selection 1";
            items.Add(e_14);
            // e_15 element
            ListBoxItem e_15 = new ListBoxItem();
            e_15.Name = "e_15";
            e_15.Content = "Selection 2";
            items.Add(e_15);
            // e_16 element
            ListBoxItem e_16 = new ListBoxItem();
            e_16.Name = "e_16";
            e_16.Content = "Selection 3";
            items.Add(e_16);
            // e_17 element
            ListBoxItem e_17 = new ListBoxItem();
            e_17.Name = "e_17";
            e_17.Content = "Selection 4";
            items.Add(e_17);
            return items;
        }
    }
}

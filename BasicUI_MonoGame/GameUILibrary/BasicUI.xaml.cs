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
    using EmptyKeys.UserInterface.Themes;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "0.9.0.0")]
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
        
        private Button button4;
        
        private Button button5;
        
        private Button button6;
        
        private TextBox textBox;
        
        private CheckBox checkBox;
        
        private TabControl e_4;
        
        private ProgressBar e_9;
        
        public BasicUI(int width, int height, GraphicsDevice graphicsDevice, int nativeScreenWidth, int nativeScreenHeight) : 
                base(width, height, graphicsDevice, nativeScreenWidth, nativeScreenHeight) {
            Style style = RootStyle.CreateRootStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
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
            this.logo.SourceAsset = "Images/EmptyKeysLogoTextSmall";
            ImageManager.Instance.AddImage("Images/EmptyKeysLogoTextSmall");
            // e_2 element
            this.e_2 = new TextBlock();
            this.e_1.Children.Add(this.e_2);
            this.e_2.Name = "e_2";
            this.e_2.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_2.VerticalAlignment = VerticalAlignment.Center;
            this.e_2.Foreground = new Color(211, 211, 211, 255);
            this.e_2.Text = "Basic UI Example";
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Bold, "Segoe_UI_15_Bold");
            this.e_2.FontFamily = new FontFamily("Segoe UI");
            this.e_2.FontSize = 20F;
            this.e_2.FontStyle = FontStyle.Bold;
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
            this.combo.ItemsSource = this.Get_combo_Items();
            // button1 element
            this.button1 = new Button();
            this.e_3.Children.Add(this.button1);
            this.button1.Name = "button1";
            this.button1.Height = 30F;
            this.button1.Width = 200F;
            this.button1.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button1.Content = "1";
            // button2 element
            this.button2 = new Button();
            this.e_3.Children.Add(this.button2);
            this.button2.Name = "button2";
            this.button2.Height = 30F;
            this.button2.Width = 200F;
            this.button2.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button2.Content = "2";
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
            // button4 element
            this.button4 = new Button();
            this.e_3.Children.Add(this.button4);
            this.button4.Name = "button4";
            this.button4.Height = 30F;
            this.button4.Width = 200F;
            this.button4.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button4.Content = "4";
            // button5 element
            this.button5 = new Button();
            this.e_3.Children.Add(this.button5);
            this.button5.Name = "button5";
            this.button5.Height = 30F;
            this.button5.Width = 200F;
            this.button5.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button5.Content = "5";
            // button6 element
            this.button6 = new Button();
            this.e_3.Children.Add(this.button6);
            this.button6.Name = "button6";
            this.button6.Height = 30F;
            this.button6.Width = 200F;
            this.button6.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button6.Content = "6";
            // textBox element
            this.textBox = new TextBox();
            this.e_3.Children.Add(this.textBox);
            this.textBox.Name = "textBox";
            this.textBox.Width = 200F;
            this.textBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.textBox.Text = "Text Box";
            // checkBox element
            this.checkBox = new CheckBox();
            this.e_3.Children.Add(this.checkBox);
            this.checkBox.Name = "checkBox";
            this.checkBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.checkBox.HorizontalAlignment = HorizontalAlignment.Center;
            this.checkBox.Content = "Check Box";
            // e_4 element
            this.e_4 = new TabControl();
            this.e_3.Children.Add(this.e_4);
            this.e_4.Name = "e_4";
            this.e_4.Width = 400F;
            this.e_4.ItemsSource = this.Get_e_4_Items();
            // e_9 element
            this.e_9 = new ProgressBar();
            this.e_3.Children.Add(this.e_9);
            this.e_9.Name = "e_9";
            this.e_9.Height = 30F;
            this.e_9.Width = 400F;
            this.e_9.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_9.Value = 39F;
        }
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_combo_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // item1 element
            ComboBoxItem item1 = new ComboBoxItem();
            item1.Name = "item1";
            item1.Content = "Item 1";
            items.Add(item1);
            // item2 element
            ComboBoxItem item2 = new ComboBoxItem();
            item2.Name = "item2";
            item2.Content = "Item 2";
            items.Add(item2);
            // item3 element
            ComboBoxItem item3 = new ComboBoxItem();
            item3.Name = "item3";
            item3.Content = "Item 3";
            items.Add(item3);
            return items;
        }
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_e_4_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_5 element
            TabItem e_5 = new TabItem();
            e_5.Name = "e_5";
            e_5.Content = "Tab 1 Content";
            e_5.Header = "Tab 1";
            items.Add(e_5);
            // e_6 element
            TabItem e_6 = new TabItem();
            e_6.Name = "e_6";
            e_6.Content = "Tab 2 Content";
            e_6.Header = "Tab 2";
            items.Add(e_6);
            // e_7 element
            TabItem e_7 = new TabItem();
            e_7.Name = "e_7";
            e_7.Content = "Tab 3 Content";
            e_7.Header = "Tab 3";
            items.Add(e_7);
            // e_8 element
            TabItem e_8 = new TabItem();
            e_8.Name = "e_8";
            e_8.Content = "Tab 4 Content";
            e_8.Header = "Tab 4";
            items.Add(e_8);
            return items;
        }
    }
}

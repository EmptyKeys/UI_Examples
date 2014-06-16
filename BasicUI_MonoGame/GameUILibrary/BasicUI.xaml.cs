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
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "0.9.0.0")]
    public partial class BasicUI : UIRoot {
        
        private Grid e_2;
        
        private TextBlock e_3;
        
        private StackPanel e_4;
        
        private ComboBox combo;
        
        private Button button1;
        
        private Button button2;
        
        private Button button3;
        
        private Button button4;
        
        private Button button5;
        
        private Button button6;
        
        private TextBox textBox;
        
        private CheckBox checkBox;
        
        private TabControl e_5;
        
        private ProgressBar e_10;
        
        public BasicUI(int width, int height, GraphicsDevice graphicsDevice, int nativeScreenWidth, int nativeScreenHeight) : 
                base(width, height, graphicsDevice, nativeScreenWidth, nativeScreenHeight) {
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            Style _s = new Style();
            Func<UIElement, UIElement> _s_S_0_ctFunc = (parent) => {
            return this._s_S_0_ctMethod(parent);
            };
            ControlTemplate _s_S_0_ct = new ControlTemplate(typeof(UIRoot), _s_S_0_ctFunc);
            Setter _s_S_0 = new Setter(Control.TemplateProperty, _s_S_0_ct);
            _s.Setters.Add(_s_S_0);
            this.Style = _s;
            // e_2 element
            this.e_2 = new Grid();
            this.Content = this.e_2;
            this.e_2.Name = "e_2";
            RowDefinition row_e_2_0 = new RowDefinition();
            row_e_2_0.Height = new GridLength(40F, GridUnitType.Pixel);
            this.e_2.RowDefinitions.Add(row_e_2_0);
            RowDefinition row_e_2_1 = new RowDefinition();
            this.e_2.RowDefinitions.Add(row_e_2_1);
            ColumnDefinition col_e_2_0 = new ColumnDefinition();
            this.e_2.ColumnDefinitions.Add(col_e_2_0);
            // e_3 element
            this.e_3 = new TextBlock();
            this.e_2.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            this.e_3.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_3.VerticalAlignment = VerticalAlignment.Center;
            this.e_3.Text = "Basic UI Example";
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Bold, "Segoe_UI_15_Bold");
            this.e_3.FontFamily = new FontFamily("Segoe UI");
            this.e_3.FontSize = 20F;
            this.e_3.FontStyle = FontStyle.Bold;
            // e_4 element
            this.e_4 = new StackPanel();
            this.e_2.Children.Add(this.e_4);
            this.e_4.Name = "e_4";
            this.e_4.Background = new SolidColorBrush(new Color(0, 0, 0, 255));
            Grid.SetRow(this.e_4, 1);
            // combo element
            this.combo = new ComboBox();
            this.e_4.Children.Add(this.combo);
            this.combo.Name = "combo";
            this.combo.Width = 200F;
            this.combo.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.combo.ItemsSource = this.Get_combo_Items();
            // button1 element
            this.button1 = new Button();
            this.e_4.Children.Add(this.button1);
            this.button1.Name = "button1";
            this.button1.Height = 30F;
            this.button1.Width = 200F;
            this.button1.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button1.Content = "1";
            // button2 element
            this.button2 = new Button();
            this.e_4.Children.Add(this.button2);
            this.button2.Name = "button2";
            this.button2.Height = 30F;
            this.button2.Width = 200F;
            this.button2.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button2.Content = "2";
            // button3 element
            this.button3 = new Button();
            this.e_4.Children.Add(this.button3);
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
            this.e_4.Children.Add(this.button4);
            this.button4.Name = "button4";
            this.button4.Height = 30F;
            this.button4.Width = 200F;
            this.button4.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button4.Content = "4";
            // button5 element
            this.button5 = new Button();
            this.e_4.Children.Add(this.button5);
            this.button5.Name = "button5";
            this.button5.Height = 30F;
            this.button5.Width = 200F;
            this.button5.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button5.Content = "5";
            // button6 element
            this.button6 = new Button();
            this.e_4.Children.Add(this.button6);
            this.button6.Name = "button6";
            this.button6.Height = 30F;
            this.button6.Width = 200F;
            this.button6.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button6.Content = "6";
            // textBox element
            this.textBox = new TextBox();
            this.e_4.Children.Add(this.textBox);
            this.textBox.Name = "textBox";
            this.textBox.Width = 200F;
            this.textBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.textBox.Text = "Text Box";
            // checkBox element
            this.checkBox = new CheckBox();
            this.e_4.Children.Add(this.checkBox);
            this.checkBox.Name = "checkBox";
            this.checkBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.checkBox.HorizontalAlignment = HorizontalAlignment.Center;
            this.checkBox.Content = "Check Box";
            // e_5 element
            this.e_5 = new TabControl();
            this.e_4.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
            this.e_5.Width = 400F;
            this.e_5.ItemsSource = this.Get_e_5_Items();
            // e_10 element
            this.e_10 = new ProgressBar();
            this.e_4.Children.Add(this.e_10);
            this.e_10.Name = "e_10";
            this.e_10.Height = 30F;
            this.e_10.Width = 400F;
            this.e_10.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_10.Value = 39F;
        }
        
        private UIElement _s_S_0_ctMethod(UIElement parent) {
            // e_0 element
            Border e_0 = new Border();
            e_0.Parent = parent;
            e_0.Name = "e_0";
            Binding binding_e_0_BorderThickness = new Binding("BorderThickness");
            binding_e_0_BorderThickness.Source = parent;
            e_0.SetBinding(Border.BorderThicknessProperty, binding_e_0_BorderThickness);
            Binding binding_e_0_BorderBrush = new Binding("BorderBrush");
            binding_e_0_BorderBrush.Source = parent;
            e_0.SetBinding(Border.BorderBrushProperty, binding_e_0_BorderBrush);
            Binding binding_e_0_Background = new Binding("Background");
            binding_e_0_Background.Source = parent;
            e_0.SetBinding(Border.BackgroundProperty, binding_e_0_Background);
            // e_1 element
            ContentPresenter e_1 = new ContentPresenter();
            e_0.Child = e_1;
            e_1.Name = "e_1";
            Binding binding_e_1_Content = new Binding("Content");
            binding_e_1_Content.Source = parent;
            e_1.SetBinding(ContentPresenter.ContentProperty, binding_e_1_Content);
            return e_0;
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
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_e_5_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_6 element
            TabItem e_6 = new TabItem();
            e_6.Name = "e_6";
            e_6.Content = "Tab 1 Content";
            e_6.Header = "Tab 1";
            items.Add(e_6);
            // e_7 element
            TabItem e_7 = new TabItem();
            e_7.Name = "e_7";
            e_7.Content = "Tab 2 Content";
            e_7.Header = "Tab 2";
            items.Add(e_7);
            // e_8 element
            TabItem e_8 = new TabItem();
            e_8.Name = "e_8";
            e_8.Content = "Tab 3 Content";
            e_8.Header = "Tab 3";
            items.Add(e_8);
            // e_9 element
            TabItem e_9 = new TabItem();
            e_9.Name = "e_9";
            e_9.Content = "Tab 4 Content";
            e_9.Header = "Tab 4";
            items.Add(e_9);
            return items;
        }
    }
}

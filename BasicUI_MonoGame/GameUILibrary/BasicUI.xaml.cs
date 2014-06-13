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
        
        private Button button1;
        
        private Button button2;
        
        private Button button3;
        
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
            this.e_2.RowDefinitions.Add(row_e_2_0);
            RowDefinition row_e_2_1 = new RowDefinition();
            this.e_2.RowDefinitions.Add(row_e_2_1);
            RowDefinition row_e_2_2 = new RowDefinition();
            this.e_2.RowDefinitions.Add(row_e_2_2);
            ColumnDefinition col_e_2_0 = new ColumnDefinition();
            this.e_2.ColumnDefinitions.Add(col_e_2_0);
            // e_3 element
            this.e_3 = new TextBlock();
            this.e_2.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            this.e_3.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_3.VerticalAlignment = VerticalAlignment.Center;
            this.e_3.Text = "Text";
            // e_4 element
            this.e_4 = new StackPanel();
            this.e_2.Children.Add(this.e_4);
            this.e_4.Name = "e_4";
            this.e_4.Background = new SolidColorBrush(new Color(0, 0, 0, 255));
            Grid.SetRow(this.e_4, 1);
            // button1 element
            this.button1 = new Button();
            this.e_4.Children.Add(this.button1);
            this.button1.Name = "button1";
            this.button1.Height = 30F;
            this.button1.Width = 100F;
            this.button1.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button1.Content = "1";
            // button2 element
            this.button2 = new Button();
            this.e_4.Children.Add(this.button2);
            this.button2.Name = "button2";
            this.button2.Height = 30F;
            this.button2.Width = 100F;
            this.button2.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button2.Content = "2";
            // button3 element
            this.button3 = new Button();
            this.e_4.Children.Add(this.button3);
            this.button3.Name = "button3";
            this.button3.Height = 30F;
            this.button3.Width = 100F;
            this.button3.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button3.Content = "3";
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
    }
}

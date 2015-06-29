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
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "1.7.5.0")]
    public partial class BasicUI : UIRoot {
        
        private Grid e_0;
        
        private StackPanel e_1;
        
        private Image logo;
        
        private TextBlock e_2;
        
        private TabControl TabControl;
        
        public BasicUI(int width, int height) : 
                base(width, height) {
            Style style = RootStyle.CreateRootStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            Binding binding__OwnedWindowsContent = new Binding("Windows");
            this.SetBinding(UIRoot.OwnedWindowsContentProperty, binding__OwnedWindowsContent);
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
            // e_1 element
            this.e_1 = new StackPanel();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            this.e_1.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            // logo element
            this.logo = new Image();
            this.e_1.Children.Add(this.logo);
            this.logo.Name = "logo";
            this.logo.HorizontalAlignment = HorizontalAlignment.Center;
            BitmapImage logo_bm = new BitmapImage();
            logo_bm.TextureAsset = "Images/EmptyKeysLogoTextSmall";
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
            this.e_2.FontFamily = new FontFamily("Segoe UI");
            this.e_2.FontSize = 20F;
            this.e_2.FontStyle = FontStyle.Bold;
            this.e_2.SetResourceReference(TextBlock.TextProperty, "TitleResource");
            // TabControl element
            this.TabControl = new TabControl();
            this.e_0.Children.Add(this.TabControl);
            this.TabControl.Name = "TabControl";
            this.TabControl.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.TabControl.ItemsSource = Get_TabControl_Items();
            Grid.SetRow(this.TabControl, 1);
            ImageManager.Instance.AddImage("Images/EmptyKeysLogoTextSmall");
            ImageManager.Instance.AddImage("Images/MonoGameLogo");
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Bold, "Segoe_UI_15_Bold");
        }
        
        private static void InitializeElementResources(UIElement elem) {
            elem.Resources.MergedDictionaries.Add(Dictionary.Instance);
        }
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_TabControl_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_3 element
            TabItem e_3 = new TabItem();
            e_3.Name = "e_3";
            e_3.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            e_3.Header = "Controls";
            // e_4 element
            Grid e_4 = new Grid();
            e_3.Content = e_4;
            e_4.Name = "e_4";
            RowDefinition row_e_4_0 = new RowDefinition();
            row_e_4_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_0);
            RowDefinition row_e_4_1 = new RowDefinition();
            row_e_4_1.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_1);
            RowDefinition row_e_4_2 = new RowDefinition();
            row_e_4_2.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_2);
            RowDefinition row_e_4_3 = new RowDefinition();
            row_e_4_3.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_3);
            RowDefinition row_e_4_4 = new RowDefinition();
            row_e_4_4.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_4);
            RowDefinition row_e_4_5 = new RowDefinition();
            row_e_4_5.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_5);
            RowDefinition row_e_4_6 = new RowDefinition();
            row_e_4_6.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_6);
            RowDefinition row_e_4_7 = new RowDefinition();
            row_e_4_7.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_7);
            RowDefinition row_e_4_8 = new RowDefinition();
            row_e_4_8.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_8);
            RowDefinition row_e_4_9 = new RowDefinition();
            row_e_4_9.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_9);
            ColumnDefinition col_e_4_0 = new ColumnDefinition();
            col_e_4_0.Width = new GridLength(1F, GridUnitType.Auto);
            e_4.ColumnDefinitions.Add(col_e_4_0);
            ColumnDefinition col_e_4_1 = new ColumnDefinition();
            e_4.ColumnDefinitions.Add(col_e_4_1);
            // e_5 element
            TextBlock e_5 = new TextBlock();
            e_4.Children.Add(e_5);
            e_5.Name = "e_5";
            e_5.VerticalAlignment = VerticalAlignment.Center;
            e_5.Text = "Button";
            // button1 element
            Button button1 = new Button();
            e_4.Children.Add(button1);
            button1.Name = "button1";
            button1.Height = 30F;
            button1.Width = 200F;
            button1.Margin = new Thickness(5F, 5F, 5F, 5F);
            button1.HorizontalAlignment = HorizontalAlignment.Left;
            button1.TabIndex = 1;
            button1.Content = "Button 1";
            button1.CommandParameter = "Click Button 1";
            Grid.SetColumn(button1, 1);
            Grid.SetRow(button1, 0);
            Binding binding_button1_Command = new Binding("ButtonCommand");
            button1.SetBinding(Button.CommandProperty, binding_button1_Command);
            // button2 element
            Button button2 = new Button();
            e_4.Children.Add(button2);
            button2.Name = "button2";
            button2.Height = 30F;
            button2.Width = 200F;
            button2.Margin = new Thickness(5F, 5F, 5F, 5F);
            button2.HorizontalAlignment = HorizontalAlignment.Left;
            button2.TabIndex = 2;
            button2.Content = "Button 2";
            button2.CommandParameter = "Click Button 2";
            Grid.SetColumn(button2, 1);
            Grid.SetRow(button2, 1);
            Binding binding_button2_IsEnabled = new Binding("ButtonEnabled");
            button2.SetBinding(Button.IsEnabledProperty, binding_button2_IsEnabled);
            Binding binding_button2_Command = new Binding("ButtonCommand");
            button2.SetBinding(Button.CommandProperty, binding_button2_Command);
            // buttonResult element
            TextBlock buttonResult = new TextBlock();
            e_4.Children.Add(buttonResult);
            buttonResult.Name = "buttonResult";
            buttonResult.HorizontalAlignment = HorizontalAlignment.Left;
            Grid.SetColumn(buttonResult, 1);
            Grid.SetRow(buttonResult, 2);
            Binding binding_buttonResult_Text = new Binding("ButtonResult");
            buttonResult.SetBinding(TextBlock.TextProperty, binding_buttonResult_Text);
            // e_6 element
            TextBlock e_6 = new TextBlock();
            e_4.Children.Add(e_6);
            e_6.Name = "e_6";
            e_6.VerticalAlignment = VerticalAlignment.Center;
            e_6.Text = "CheckBox";
            Grid.SetRow(e_6, 3);
            // checkBox element
            CheckBox checkBox = new CheckBox();
            e_4.Children.Add(checkBox);
            checkBox.Name = "checkBox";
            checkBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            checkBox.HorizontalAlignment = HorizontalAlignment.Left;
            checkBox.TabIndex = 3;
            checkBox.Content = "Check Box";
            Grid.SetColumn(checkBox, 1);
            Grid.SetRow(checkBox, 3);
            // e_7 element
            TextBlock e_7 = new TextBlock();
            e_4.Children.Add(e_7);
            e_7.Name = "e_7";
            e_7.VerticalAlignment = VerticalAlignment.Center;
            e_7.Text = "ProgressBar";
            Grid.SetRow(e_7, 4);
            // e_8 element
            ProgressBar e_8 = new ProgressBar();
            e_4.Children.Add(e_8);
            e_8.Name = "e_8";
            e_8.Height = 30F;
            e_8.Width = 200F;
            e_8.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_8.HorizontalAlignment = HorizontalAlignment.Left;
            Grid.SetColumn(e_8, 1);
            Grid.SetRow(e_8, 4);
            Binding binding_e_8_Value = new Binding("ProgressValue");
            e_8.SetBinding(ProgressBar.ValueProperty, binding_e_8_Value);
            // e_9 element
            TextBlock e_9 = new TextBlock();
            e_4.Children.Add(e_9);
            e_9.Name = "e_9";
            e_9.VerticalAlignment = VerticalAlignment.Center;
            e_9.Text = "Slider";
            Grid.SetRow(e_9, 5);
            // slider element
            Slider slider = new Slider();
            e_4.Children.Add(slider);
            slider.Name = "slider";
            slider.Width = 200F;
            slider.HorizontalAlignment = HorizontalAlignment.Left;
            slider.TabIndex = 4;
            slider.Minimum = 5F;
            slider.Maximum = 20F;
            Grid.SetColumn(slider, 1);
            Grid.SetRow(slider, 5);
            Binding binding_slider_Value = new Binding("SliderValue");
            slider.SetBinding(Slider.ValueProperty, binding_slider_Value);
            // e_10 element
            TextBlock e_10 = new TextBlock();
            e_4.Children.Add(e_10);
            e_10.Name = "e_10";
            e_10.VerticalAlignment = VerticalAlignment.Center;
            e_10.Text = "TextBox";
            Grid.SetRow(e_10, 6);
            // textBox element
            TextBox textBox = new TextBox();
            e_4.Children.Add(textBox);
            textBox.Name = "textBox";
            textBox.Width = 200F;
            textBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            textBox.HorizontalAlignment = HorizontalAlignment.Left;
            textBox.TabIndex = 5;
            Grid.SetColumn(textBox, 1);
            Grid.SetRow(textBox, 6);
            Binding binding_textBox_Text = new Binding("TextBoxText");
            textBox.SetBinding(TextBox.TextProperty, binding_textBox_Text);
            // e_11 element
            TextBlock e_11 = new TextBlock();
            e_4.Children.Add(e_11);
            e_11.Name = "e_11";
            e_11.VerticalAlignment = VerticalAlignment.Center;
            e_11.Text = "PasswordBox";
            Grid.SetRow(e_11, 7);
            // e_12 element
            PasswordBox e_12 = new PasswordBox();
            e_4.Children.Add(e_12);
            e_12.Name = "e_12";
            e_12.Width = 200F;
            e_12.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_12.HorizontalAlignment = HorizontalAlignment.Left;
            e_12.TabIndex = 6;
            Grid.SetColumn(e_12, 1);
            Grid.SetRow(e_12, 7);
            // e_13 element
            TextBlock e_13 = new TextBlock();
            e_4.Children.Add(e_13);
            e_13.Name = "e_13";
            e_13.VerticalAlignment = VerticalAlignment.Center;
            e_13.Text = "ComboBox";
            Grid.SetRow(e_13, 8);
            // combo element
            ComboBox combo = new ComboBox();
            e_4.Children.Add(combo);
            combo.Name = "combo";
            combo.Width = 200F;
            combo.Margin = new Thickness(5F, 5F, 5F, 5F);
            combo.HorizontalAlignment = HorizontalAlignment.Left;
            combo.TabIndex = 7;
            combo.ItemsSource = Get_combo_Items();
            combo.SelectedIndex = 2;
            Grid.SetColumn(combo, 1);
            Grid.SetRow(combo, 8);
            // e_14 element
            TextBlock e_14 = new TextBlock();
            e_4.Children.Add(e_14);
            e_14.Name = "e_14";
            e_14.VerticalAlignment = VerticalAlignment.Center;
            e_14.Text = "ListBox";
            Grid.SetRow(e_14, 9);
            // e_15 element
            ListBox e_15 = new ListBox();
            e_4.Children.Add(e_15);
            e_15.Name = "e_15";
            e_15.TabIndex = 8;
            e_15.ItemsSource = Get_e_15_Items();
            Grid.SetColumn(e_15, 1);
            Grid.SetRow(e_15, 9);
            items.Add(e_3);
            // e_22 element
            TabItem e_22 = new TabItem();
            e_22.Name = "e_22";
            e_22.Header = "DataGrid";
            // e_23 element
            DataGrid e_23 = new DataGrid();
            e_22.Content = e_23;
            e_23.Name = "e_23";
            e_23.AutoGenerateColumns = false;
            DataGridTextColumn e_23_Col0 = new DataGridTextColumn();
            e_23_Col0.Header = "#";
            Binding e_23_Col0_b = new Binding("Number");
            e_23_Col0.Binding = e_23_Col0_b;
            e_23.Columns.Add(e_23_Col0);
            DataGridTextColumn e_23_Col1 = new DataGridTextColumn();
            e_23_Col1.Header = "Text";
            Style e_23_Col1_e_s = new Style(typeof(DataGridCell));
            Setter e_23_Col1_e_s_S_0 = new Setter(DataGridCell.BackgroundProperty, new SolidColorBrush(new ColorW(128, 128, 128, 255)));
            e_23_Col1_e_s.Setters.Add(e_23_Col1_e_s_S_0);
            Setter e_23_Col1_e_s_S_1 = new Setter(DataGridCell.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            e_23_Col1_e_s.Setters.Add(e_23_Col1_e_s_S_1);
            Setter e_23_Col1_e_s_S_2 = new Setter(DataGridCell.VerticalAlignmentProperty, VerticalAlignment.Center);
            e_23_Col1_e_s.Setters.Add(e_23_Col1_e_s_S_2);
            e_23_Col1.ElementStyle = e_23_Col1_e_s;
            Binding e_23_Col1_b = new Binding("Text");
            e_23_Col1.Binding = e_23_Col1_b;
            e_23.Columns.Add(e_23_Col1);
            DataGridCheckBoxColumn e_23_Col2 = new DataGridCheckBoxColumn();
            e_23_Col2.Header = "Bool";
            Binding e_23_Col2_b = new Binding("Boolean");
            e_23_Col2.Binding = e_23_Col2_b;
            e_23.Columns.Add(e_23_Col2);
            DataGridTemplateColumn e_23_Col3 = new DataGridTemplateColumn();
            e_23_Col3.Width = 200F;
            // e_24 element
            TextBlock e_24 = new TextBlock();
            e_24.Name = "e_24";
            e_24.Text = "Template Column";
            e_23_Col3.Header = e_24;
            Style e_23_Col3_h_s = new Style(typeof(DataGridColumnHeader));
            Setter e_23_Col3_h_s_S_0 = new Setter(DataGridColumnHeader.ForegroundProperty, new SolidColorBrush(new ColorW(255, 165, 0, 255)));
            e_23_Col3_h_s.Setters.Add(e_23_Col3_h_s_S_0);
            e_23_Col3.HeaderStyle = e_23_Col3_h_s;
            Func<UIElement, UIElement> e_23_Col3_ct_dtFunc = e_23_Col3_ct_dtMethod;
            e_23_Col3.CellTemplate = new DataTemplate(e_23_Col3_ct_dtFunc);
            e_23.Columns.Add(e_23_Col3);
            Binding binding_e_23_ItemsSource = new Binding("GridData");
            e_23.SetBinding(DataGrid.ItemsSourceProperty, binding_e_23_ItemsSource);
            items.Add(e_22);
            // e_30 element
            TabItem e_30 = new TabItem();
            e_30.Name = "e_30";
            e_30.Header = "TreeView";
            // e_31 element
            TreeView e_31 = new TreeView();
            e_30.Content = e_31;
            e_31.Name = "e_31";
            Binding binding_e_31_ItemsSource = new Binding("TreeItems");
            e_31.SetBinding(TreeView.ItemsSourceProperty, binding_e_31_ItemsSource);
            items.Add(e_30);
            // e_32 element
            TabItem e_32 = new TabItem();
            e_32.Name = "e_32";
            e_32.Header = "Shapes";
            // e_33 element
            Grid e_33 = new Grid();
            e_32.Content = e_33;
            e_33.Name = "e_33";
            RowDefinition row_e_33_0 = new RowDefinition();
            e_33.RowDefinitions.Add(row_e_33_0);
            RowDefinition row_e_33_1 = new RowDefinition();
            e_33.RowDefinitions.Add(row_e_33_1);
            RowDefinition row_e_33_2 = new RowDefinition();
            e_33.RowDefinitions.Add(row_e_33_2);
            ColumnDefinition col_e_33_0 = new ColumnDefinition();
            e_33.ColumnDefinitions.Add(col_e_33_0);
            ColumnDefinition col_e_33_1 = new ColumnDefinition();
            e_33.ColumnDefinitions.Add(col_e_33_1);
            ColumnDefinition col_e_33_2 = new ColumnDefinition();
            e_33.ColumnDefinitions.Add(col_e_33_2);
            // e_34 element
            Rectangle e_34 = new Rectangle();
            e_33.Children.Add(e_34);
            e_34.Name = "e_34";
            e_34.Height = 100F;
            e_34.Width = 200F;
            e_34.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_34.Fill = new SolidColorBrush(new ColorW(0, 128, 0, 255));
            e_34.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_34.StrokeThickness = 5F;
            e_34.RadiusX = 10F;
            e_34.RadiusY = 10F;
            // e_35 element
            Rectangle e_35 = new Rectangle();
            e_33.Children.Add(e_35);
            e_35.Name = "e_35";
            e_35.Height = 100F;
            e_35.Width = 200F;
            e_35.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_35.Fill = new SolidColorBrush(new ColorW(255, 165, 0, 255));
            Grid.SetColumn(e_35, 1);
            // e_36 element
            Rectangle e_36 = new Rectangle();
            e_33.Children.Add(e_36);
            e_36.Name = "e_36";
            e_36.Height = 100F;
            e_36.Width = 200F;
            e_36.Margin = new Thickness(5F, 5F, 5F, 5F);
            LinearGradientBrush e_36_Fill = new LinearGradientBrush();
            e_36_Fill.StartPoint = new PointF(0F, 0F);
            e_36_Fill.EndPoint = new PointF(1F, 1F);
            e_36_Fill.SpreadMethod = GradientSpreadMethod.Pad;
            e_36_Fill.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0.5F));
            e_36_Fill.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0F));
            e_36.Fill = e_36_Fill;
            LinearGradientBrush e_36_Stroke = new LinearGradientBrush();
            e_36_Stroke.StartPoint = new PointF(0F, 0F);
            e_36_Stroke.EndPoint = new PointF(1F, 1F);
            e_36_Stroke.SpreadMethod = GradientSpreadMethod.Pad;
            e_36_Stroke.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0.5F));
            e_36_Stroke.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0F));
            e_36.Stroke = e_36_Stroke;
            e_36.StrokeThickness = 5F;
            e_36.RadiusX = 10F;
            e_36.RadiusY = 10F;
            Grid.SetColumn(e_36, 2);
            // e_37 element
            Ellipse e_37 = new Ellipse();
            e_33.Children.Add(e_37);
            e_37.Name = "e_37";
            e_37.Height = 100F;
            e_37.Width = 200F;
            e_37.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_37.Fill = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_37.Stroke = new SolidColorBrush(new ColorW(0, 128, 0, 255));
            e_37.StrokeThickness = 10F;
            Grid.SetRow(e_37, 1);
            // e_38 element
            Ellipse e_38 = new Ellipse();
            e_33.Children.Add(e_38);
            e_38.Name = "e_38";
            e_38.Height = 100F;
            e_38.Width = 200F;
            e_38.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_38.Stroke = new SolidColorBrush(new ColorW(255, 165, 0, 255));
            e_38.StrokeThickness = 10F;
            Grid.SetColumn(e_38, 1);
            Grid.SetRow(e_38, 1);
            // e_39 element
            Ellipse e_39 = new Ellipse();
            e_33.Children.Add(e_39);
            e_39.Name = "e_39";
            e_39.Height = 100F;
            e_39.Width = 200F;
            e_39.Margin = new Thickness(5F, 5F, 5F, 5F);
            LinearGradientBrush e_39_Fill = new LinearGradientBrush();
            e_39_Fill.StartPoint = new PointF(0F, 0F);
            e_39_Fill.EndPoint = new PointF(1F, 1F);
            e_39_Fill.SpreadMethod = GradientSpreadMethod.Pad;
            e_39_Fill.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0.5F));
            e_39_Fill.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0F));
            e_39.Fill = e_39_Fill;
            LinearGradientBrush e_39_Stroke = new LinearGradientBrush();
            e_39_Stroke.StartPoint = new PointF(0F, 0F);
            e_39_Stroke.EndPoint = new PointF(1F, 1F);
            e_39_Stroke.SpreadMethod = GradientSpreadMethod.Pad;
            e_39_Stroke.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0.5F));
            e_39_Stroke.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0F));
            e_39.Stroke = e_39_Stroke;
            e_39.StrokeThickness = 10F;
            Grid.SetColumn(e_39, 2);
            Grid.SetRow(e_39, 1);
            // e_40 element
            Line e_40 = new Line();
            e_33.Children.Add(e_40);
            e_40.Name = "e_40";
            e_40.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_40.StrokeThickness = 10F;
            e_40.X1 = 10F;
            e_40.X2 = 150F;
            e_40.Y1 = 10F;
            e_40.Y2 = 150F;
            Grid.SetRow(e_40, 2);
            // e_41 element
            Line e_41 = new Line();
            e_33.Children.Add(e_41);
            e_41.Name = "e_41";
            e_41.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_41.StrokeThickness = 10F;
            e_41.X1 = 100F;
            e_41.X2 = 100F;
            e_41.Y1 = 10F;
            e_41.Y2 = 100F;
            Grid.SetRow(e_41, 2);
            // e_42 element
            Line e_42 = new Line();
            e_33.Children.Add(e_42);
            e_42.Name = "e_42";
            e_42.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_42.StrokeThickness = 10F;
            e_42.X1 = 10F;
            e_42.X2 = 100F;
            e_42.Y1 = 100F;
            e_42.Y2 = 100F;
            Grid.SetRow(e_42, 2);
            // e_43 element
            Rectangle e_43 = new Rectangle();
            e_33.Children.Add(e_43);
            e_43.Name = "e_43";
            e_43.Height = 100F;
            e_43.Width = 200F;
            e_43.Margin = new Thickness(5F, 5F, 5F, 5F);
            ImageBrush e_43_Fill = new ImageBrush();
            BitmapImage e_43_Fill_bm = new BitmapImage();
            e_43_Fill_bm.TextureAsset = "Images/MonoGameLogo";
            e_43_Fill.ImageSource = e_43_Fill_bm;
            e_43_Fill.Stretch = Stretch.None;
            e_43.Fill = e_43_Fill;
            e_43.Stroke = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_43.StrokeThickness = 1F;
            e_43.RadiusX = 10F;
            e_43.RadiusY = 10F;
            Grid.SetColumn(e_43, 1);
            Grid.SetRow(e_43, 2);
            items.Add(e_32);
            // e_44 element
            TabItem e_44 = new TabItem();
            e_44.Name = "e_44";
            e_44.Header = "Animations";
            // e_45 element
            Grid e_45 = new Grid();
            e_44.Content = e_45;
            e_45.Name = "e_45";
            ColumnDefinition col_e_45_0 = new ColumnDefinition();
            e_45.ColumnDefinitions.Add(col_e_45_0);
            ColumnDefinition col_e_45_1 = new ColumnDefinition();
            e_45.ColumnDefinitions.Add(col_e_45_1);
            // e_46 element
            StackPanel e_46 = new StackPanel();
            e_45.Children.Add(e_46);
            e_46.Name = "e_46";
            // animButton1 element
            Button animButton1 = new Button();
            e_46.Children.Add(animButton1);
            animButton1.Name = "animButton1";
            animButton1.TabIndex = 1;
            animButton1.Content = "Mouse Over me!";
            animButton1.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton2 element
            Button animButton2 = new Button();
            e_46.Children.Add(animButton2);
            animButton2.Name = "animButton2";
            animButton2.TabIndex = 2;
            animButton2.Content = "Mouse Over me!";
            animButton2.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton3 element
            Button animButton3 = new Button();
            e_46.Children.Add(animButton3);
            animButton3.Name = "animButton3";
            animButton3.TabIndex = 3;
            animButton3.Content = "Mouse Over me!";
            animButton3.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton4 element
            Button animButton4 = new Button();
            e_46.Children.Add(animButton4);
            animButton4.Name = "animButton4";
            animButton4.TabIndex = 4;
            animButton4.Content = "Mouse Over me!";
            animButton4.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animBorder1 element
            Border animBorder1 = new Border();
            e_45.Children.Add(animBorder1);
            animBorder1.Name = "animBorder1";
            animBorder1.Height = 100F;
            animBorder1.Width = 200F;
            animBorder1.Margin = new Thickness(0F, 10F, 0F, 10F);
            animBorder1.VerticalAlignment = VerticalAlignment.Top;
            EventTrigger animBorder1_ET_0 = new EventTrigger(Border.LoadedEvent, animBorder1);
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
            Grid.SetColumn(animBorder1, 1);
            // animBorder2 element
            Border animBorder2 = new Border();
            e_45.Children.Add(animBorder2);
            animBorder2.Name = "animBorder2";
            animBorder2.Height = 50F;
            animBorder2.Width = 100F;
            animBorder2.Margin = new Thickness(50F, 35F, 50F, 35F);
            animBorder2.VerticalAlignment = VerticalAlignment.Top;
            EventTrigger animBorder2_ET_0 = new EventTrigger(Border.LoadedEvent, animBorder2);
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
            Grid.SetColumn(animBorder2, 1);
            items.Add(e_44);
            // e_47 element
            TabItem e_47 = new TabItem();
            e_47.Name = "e_47";
            e_47.Header = "Tetris";
            // e_48 element
            Border e_48 = new Border();
            e_47.Content = e_48;
            e_48.Name = "e_48";
            // e_49 element
            Grid e_49 = new Grid();
            e_48.Child = e_49;
            e_49.Name = "e_49";
            e_49.Margin = new Thickness(10F, 10F, 10F, 10F);
            RowDefinition row_e_49_0 = new RowDefinition();
            row_e_49_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_49.RowDefinitions.Add(row_e_49_0);
            RowDefinition row_e_49_1 = new RowDefinition();
            row_e_49_1.Height = new GridLength(420F, GridUnitType.Pixel);
            e_49.RowDefinitions.Add(row_e_49_1);
            ColumnDefinition col_e_49_0 = new ColumnDefinition();
            e_49.ColumnDefinitions.Add(col_e_49_0);
            ColumnDefinition col_e_49_1 = new ColumnDefinition();
            e_49.ColumnDefinitions.Add(col_e_49_1);
            ColumnDefinition col_e_49_2 = new ColumnDefinition();
            e_49.ColumnDefinitions.Add(col_e_49_2);
            // e_50 element
            StackPanel e_50 = new StackPanel();
            e_49.Children.Add(e_50);
            e_50.Name = "e_50";
            e_50.HorizontalAlignment = HorizontalAlignment.Right;
            e_50.Orientation = Orientation.Vertical;
            Grid.SetRow(e_50, 1);
            // e_51 element
            TextBlock e_51 = new TextBlock();
            e_50.Children.Add(e_51);
            e_51.Name = "e_51";
            e_51.Text = "Next";
            // e_52 element
            Border e_52 = new Border();
            e_50.Children.Add(e_52);
            e_52.Name = "e_52";
            e_52.Height = 81F;
            e_52.Width = 81F;
            e_52.BorderBrush = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_52.BorderThickness = new Thickness(0F, 0F, 1F, 1F);
            // tetrisNextContainer1 element
            Canvas tetrisNextContainer1 = new Canvas();
            e_52.Child = tetrisNextContainer1;
            tetrisNextContainer1.Name = "tetrisNextContainer1";
            tetrisNextContainer1.Height = 80F;
            tetrisNextContainer1.Width = 80F;
            // e_53 element
            Border e_53 = new Border();
            e_49.Children.Add(e_53);
            e_53.Name = "e_53";
            e_53.Height = 401F;
            e_53.Width = 201F;
            e_53.BorderBrush = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_53.BorderThickness = new Thickness(0F, 0F, 1F, 1F);
            Grid.SetColumn(e_53, 1);
            Grid.SetRow(e_53, 1);
            // tetrisContainer1 element
            Canvas tetrisContainer1 = new Canvas();
            e_53.Child = tetrisContainer1;
            tetrisContainer1.Name = "tetrisContainer1";
            tetrisContainer1.Height = 400F;
            tetrisContainer1.Width = 200F;
            tetrisContainer1.HorizontalAlignment = HorizontalAlignment.Left;
            tetrisContainer1.VerticalAlignment = VerticalAlignment.Top;
            // e_54 element
            Grid e_54 = new Grid();
            e_49.Children.Add(e_54);
            e_54.Name = "e_54";
            RowDefinition row_e_54_0 = new RowDefinition();
            row_e_54_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_54.RowDefinitions.Add(row_e_54_0);
            RowDefinition row_e_54_1 = new RowDefinition();
            row_e_54_1.Height = new GridLength(1F, GridUnitType.Auto);
            e_54.RowDefinitions.Add(row_e_54_1);
            ColumnDefinition col_e_54_0 = new ColumnDefinition();
            col_e_54_0.Width = new GridLength(1F, GridUnitType.Auto);
            e_54.ColumnDefinitions.Add(col_e_54_0);
            ColumnDefinition col_e_54_1 = new ColumnDefinition();
            col_e_54_1.Width = new GridLength(1F, GridUnitType.Star);
            e_54.ColumnDefinitions.Add(col_e_54_1);
            ColumnDefinition col_e_54_2 = new ColumnDefinition();
            col_e_54_2.Width = new GridLength(1F, GridUnitType.Auto);
            e_54.ColumnDefinitions.Add(col_e_54_2);
            Grid.SetColumnSpan(e_54, 3);
            Binding binding_e_54_DataContext = new Binding("Tetris");
            e_54.SetBinding(Grid.DataContextProperty, binding_e_54_DataContext);
            // e_55 element
            Button e_55 = new Button();
            e_54.Children.Add(e_55);
            e_55.Name = "e_55";
            e_55.Height = 30F;
            e_55.Content = "Start";
            Grid.SetColumnSpan(e_55, 3);
            Binding binding_e_55_Command = new Binding("StartCommand");
            e_55.SetBinding(Button.CommandProperty, binding_e_55_Command);
            // e_56 element
            Grid e_56 = new Grid();
            e_54.Children.Add(e_56);
            e_56.Name = "e_56";
            RowDefinition row_e_56_0 = new RowDefinition();
            row_e_56_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_56.RowDefinitions.Add(row_e_56_0);
            ColumnDefinition col_e_56_0 = new ColumnDefinition();
            e_56.ColumnDefinitions.Add(col_e_56_0);
            ColumnDefinition col_e_56_1 = new ColumnDefinition();
            col_e_56_1.Width = new GridLength(70F, GridUnitType.Pixel);
            e_56.ColumnDefinitions.Add(col_e_56_1);
            ColumnDefinition col_e_56_2 = new ColumnDefinition();
            e_56.ColumnDefinitions.Add(col_e_56_2);
            Grid.SetColumn(e_56, 1);
            Grid.SetRow(e_56, 1);
            // spPlayer1 element
            StackPanel spPlayer1 = new StackPanel();
            e_56.Children.Add(spPlayer1);
            spPlayer1.Name = "spPlayer1";
            spPlayer1.HorizontalAlignment = HorizontalAlignment.Right;
            spPlayer1.Orientation = Orientation.Vertical;
            // e_57 element
            TextBlock e_57 = new TextBlock();
            spPlayer1.Children.Add(e_57);
            e_57.Name = "e_57";
            Binding binding_e_57_Text = new Binding("Score");
            e_57.SetBinding(TextBlock.TextProperty, binding_e_57_Text);
            // e_58 element
            TextBlock e_58 = new TextBlock();
            spPlayer1.Children.Add(e_58);
            e_58.Name = "e_58";
            Binding binding_e_58_Text = new Binding("Lines");
            e_58.SetBinding(TextBlock.TextProperty, binding_e_58_Text);
            // e_59 element
            TextBlock e_59 = new TextBlock();
            spPlayer1.Children.Add(e_59);
            e_59.Name = "e_59";
            Binding binding_e_59_Text = new Binding("Level");
            e_59.SetBinding(TextBlock.TextProperty, binding_e_59_Text);
            // e_60 element
            StackPanel e_60 = new StackPanel();
            e_56.Children.Add(e_60);
            e_60.Name = "e_60";
            e_60.HorizontalAlignment = HorizontalAlignment.Center;
            e_60.Orientation = Orientation.Vertical;
            Grid.SetColumn(e_60, 1);
            // e_61 element
            TextBlock e_61 = new TextBlock();
            e_60.Children.Add(e_61);
            e_61.Name = "e_61";
            e_61.Text = "SCORE";
            // e_62 element
            TextBlock e_62 = new TextBlock();
            e_60.Children.Add(e_62);
            e_62.Name = "e_62";
            e_62.Text = "LINES";
            // e_63 element
            TextBlock e_63 = new TextBlock();
            e_60.Children.Add(e_63);
            e_63.Name = "e_63";
            e_63.Text = "LEVEL";
            // e_64 element
            StackPanel e_64 = new StackPanel();
            e_56.Children.Add(e_64);
            e_64.Name = "e_64";
            e_64.HorizontalAlignment = HorizontalAlignment.Left;
            e_64.Orientation = Orientation.Horizontal;
            // e_65 element
            TextBlock e_65 = new TextBlock();
            e_64.Children.Add(e_65);
            e_65.Name = "e_65";
            e_65.Text = "Use A,S,D,W for left, down, right, rotate";
            items.Add(e_47);
            return items;
        }
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_combo_Items() {
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
            item3.IsSelected = true;
            items.Add(item3);
            return items;
        }
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_e_15_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_16 element
            ListBoxItem e_16 = new ListBoxItem();
            e_16.Name = "e_16";
            e_16.Content = "Selection 1";
            items.Add(e_16);
            // e_17 element
            ListBoxItem e_17 = new ListBoxItem();
            e_17.Name = "e_17";
            e_17.Content = "Selection 2";
            items.Add(e_17);
            // e_18 element
            ListBoxItem e_18 = new ListBoxItem();
            e_18.Name = "e_18";
            e_18.Content = "Selection 3";
            items.Add(e_18);
            // e_19 element
            ListBoxItem e_19 = new ListBoxItem();
            e_19.Name = "e_19";
            e_19.Content = "Selection 4";
            items.Add(e_19);
            // e_20 element
            ListBoxItem e_20 = new ListBoxItem();
            e_20.Name = "e_20";
            e_20.Content = "Selection 5";
            items.Add(e_20);
            // e_21 element
            ListBoxItem e_21 = new ListBoxItem();
            e_21.Name = "e_21";
            e_21.Content = "Selection 6";
            items.Add(e_21);
            return items;
        }
        
        private static UIElement e_23_Col3_ct_dtMethod(UIElement parent) {
            // e_25 element
            StackPanel e_25 = new StackPanel();
            e_25.Parent = parent;
            e_25.Name = "e_25";
            // e_26 element
            TextBlock e_26 = new TextBlock();
            e_25.Children.Add(e_26);
            e_26.Name = "e_26";
            Binding binding_e_26_Text = new Binding("Text");
            e_26.SetBinding(TextBlock.TextProperty, binding_e_26_Text);
            // e_27 element
            StackPanel e_27 = new StackPanel();
            e_25.Children.Add(e_27);
            e_27.Name = "e_27";
            e_27.Orientation = Orientation.Horizontal;
            // e_28 element
            TextBlock e_28 = new TextBlock();
            e_27.Children.Add(e_28);
            e_28.Name = "e_28";
            Binding binding_e_28_Text = new Binding("Boolean");
            e_28.SetBinding(TextBlock.TextProperty, binding_e_28_Text);
            // e_29 element
            TextBlock e_29 = new TextBlock();
            e_27.Children.Add(e_29);
            e_29.Name = "e_29";
            Binding binding_e_29_Text = new Binding("Number");
            e_29.SetBinding(TextBlock.TextProperty, binding_e_29_Text);
            return e_25;
        }
    }
}

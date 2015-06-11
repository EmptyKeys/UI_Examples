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
        
        private TabControl e_3;
        
        public BasicUI(int width, int height) : 
                base(width, height) {
            Style style = RootStyle.CreateRootStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
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
            this.e_3 = new TabControl();
            this.e_0.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            this.e_3.Margin = new Thickness(10F, 10F, 10F, 10F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            this.e_3.ItemsSource = Get_e_3_Items();
            Grid.SetRow(this.e_3, 1);
        }
        
        private static void InitializeElementResources(UIElement elem) {
            elem.Resources.MergedDictionaries.Add(Dictionary.Instance);
        }
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_e_3_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_4 element
            TabItem e_4 = new TabItem();
            e_4.Name = "e_4";
            e_4.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_4.Header = "Controls";
            // e_5 element
            StackPanel e_5 = new StackPanel();
            e_4.Content = e_5;
            e_5.Name = "e_5";
            // button1 element
            Button button1 = new Button();
            e_5.Children.Add(button1);
            button1.Name = "button1";
            button1.Height = 30F;
            button1.Width = 200F;
            button1.Margin = new Thickness(5F, 5F, 5F, 5F);
            button1.TabIndex = 1;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            button1.Content = "Button 1";
            button1.CommandParameter = "Click Button 1";
            Binding binding_button1_Command = new Binding("ButtonCommand");
            button1.SetBinding(Button.CommandProperty, binding_button1_Command);
            // button2 element
            Button button2 = new Button();
            e_5.Children.Add(button2);
            button2.Name = "button2";
            button2.Height = 30F;
            button2.Width = 200F;
            button2.Margin = new Thickness(5F, 5F, 5F, 5F);
            button2.TabIndex = 2;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            button2.Content = "Button 2";
            button2.CommandParameter = "Click Button 2";
            Binding binding_button2_IsEnabled = new Binding("ButtonEnabled");
            button2.SetBinding(Button.IsEnabledProperty, binding_button2_IsEnabled);
            Binding binding_button2_Command = new Binding("ButtonCommand");
            button2.SetBinding(Button.CommandProperty, binding_button2_Command);
            // buttonResult element
            TextBlock buttonResult = new TextBlock();
            e_5.Children.Add(buttonResult);
            buttonResult.Name = "buttonResult";
            buttonResult.HorizontalAlignment = HorizontalAlignment.Center;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_buttonResult_Text = new Binding("ButtonResult");
            buttonResult.SetBinding(TextBlock.TextProperty, binding_buttonResult_Text);
            // checkBox element
            CheckBox checkBox = new CheckBox();
            e_5.Children.Add(checkBox);
            checkBox.Name = "checkBox";
            checkBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            checkBox.HorizontalAlignment = HorizontalAlignment.Center;
            checkBox.TabIndex = 3;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            checkBox.Content = "Check Box";
            // e_6 element
            ProgressBar e_6 = new ProgressBar();
            e_5.Children.Add(e_6);
            e_6.Name = "e_6";
            e_6.Height = 30F;
            e_6.Width = 200F;
            e_6.Margin = new Thickness(5F, 5F, 5F, 5F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_6_Value = new Binding("ProgressValue");
            e_6.SetBinding(ProgressBar.ValueProperty, binding_e_6_Value);
            // slider element
            Slider slider = new Slider();
            e_5.Children.Add(slider);
            slider.Name = "slider";
            slider.Width = 200F;
            slider.TabIndex = 4;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            slider.Minimum = 5F;
            slider.Maximum = 20F;
            Binding binding_slider_Value = new Binding("SliderValue");
            slider.SetBinding(Slider.ValueProperty, binding_slider_Value);
            // textBox element
            TextBox textBox = new TextBox();
            e_5.Children.Add(textBox);
            textBox.Name = "textBox";
            textBox.Width = 200F;
            textBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            textBox.TabIndex = 5;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_textBox_Text = new Binding("TextBoxText");
            textBox.SetBinding(TextBox.TextProperty, binding_textBox_Text);
            // combo element
            ComboBox combo = new ComboBox();
            e_5.Children.Add(combo);
            combo.Name = "combo";
            combo.Width = 200F;
            combo.Margin = new Thickness(5F, 5F, 5F, 5F);
            combo.TabIndex = 6;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            combo.ItemsSource = Get_combo_Items();
            combo.SelectedIndex = 2;
            // e_7 element
            ListBox e_7 = new ListBox();
            e_5.Children.Add(e_7);
            e_7.Name = "e_7";
            e_7.TabIndex = 7;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_7.ItemsSource = Get_e_7_Items();
            items.Add(e_4);
            // e_14 element
            TabItem e_14 = new TabItem();
            e_14.Name = "e_14";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_14.Header = "DataGrid";
            // e_15 element
            DataGrid e_15 = new DataGrid();
            e_14.Content = e_15;
            e_15.Name = "e_15";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_15.AutoGenerateColumns = false;
            DataGridTextColumn e_15_Col0 = new DataGridTextColumn();
            e_15_Col0.Header = "#";
            Binding e_15_Col0_b = new Binding("Number");
            e_15_Col0.Binding = e_15_Col0_b;
            e_15.Columns.Add(e_15_Col0);
            DataGridTextColumn e_15_Col1 = new DataGridTextColumn();
            e_15_Col1.Header = "Text";
            Style e_15_Col1_e_s = new Style(typeof(DataGridCell));
            Setter e_15_Col1_e_s_S_0 = new Setter(DataGridCell.BackgroundProperty, new SolidColorBrush(new ColorW(128, 128, 128, 255)));
            e_15_Col1_e_s.Setters.Add(e_15_Col1_e_s_S_0);
            Setter e_15_Col1_e_s_S_1 = new Setter(DataGridCell.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            e_15_Col1_e_s.Setters.Add(e_15_Col1_e_s_S_1);
            Setter e_15_Col1_e_s_S_2 = new Setter(DataGridCell.VerticalAlignmentProperty, VerticalAlignment.Center);
            e_15_Col1_e_s.Setters.Add(e_15_Col1_e_s_S_2);
            e_15_Col1.ElementStyle = e_15_Col1_e_s;
            Binding e_15_Col1_b = new Binding("Text");
            e_15_Col1.Binding = e_15_Col1_b;
            e_15.Columns.Add(e_15_Col1);
            DataGridCheckBoxColumn e_15_Col2 = new DataGridCheckBoxColumn();
            e_15_Col2.Header = "Bool";
            Binding e_15_Col2_b = new Binding("Boolean");
            e_15_Col2.Binding = e_15_Col2_b;
            e_15.Columns.Add(e_15_Col2);
            DataGridTemplateColumn e_15_Col3 = new DataGridTemplateColumn();
            e_15_Col3.Width = 200F;
            // e_16 element
            TextBlock e_16 = new TextBlock();
            e_16.Name = "e_16";
            e_16.Text = "Template Column";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_15_Col3.Header = e_16;
            Style e_15_Col3_h_s = new Style(typeof(DataGridColumnHeader));
            Setter e_15_Col3_h_s_S_0 = new Setter(DataGridColumnHeader.ForegroundProperty, new SolidColorBrush(new ColorW(255, 165, 0, 255)));
            e_15_Col3_h_s.Setters.Add(e_15_Col3_h_s_S_0);
            e_15_Col3.HeaderStyle = e_15_Col3_h_s;
            Func<UIElement, UIElement> e_15_Col3_ct_dtFunc = e_15_Col3_ct_dtMethod;
            e_15_Col3.CellTemplate = new DataTemplate(e_15_Col3_ct_dtFunc);
            e_15.Columns.Add(e_15_Col3);
            Binding binding_e_15_ItemsSource = new Binding("GridData");
            e_15.SetBinding(DataGrid.ItemsSourceProperty, binding_e_15_ItemsSource);
            items.Add(e_14);
            // e_22 element
            TabItem e_22 = new TabItem();
            e_22.Name = "e_22";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_22.Header = "TreeView";
            // e_23 element
            TreeView e_23 = new TreeView();
            e_22.Content = e_23;
            e_23.Name = "e_23";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_23_ItemsSource = new Binding("TreeItems");
            e_23.SetBinding(TreeView.ItemsSourceProperty, binding_e_23_ItemsSource);
            items.Add(e_22);
            // e_24 element
            TabItem e_24 = new TabItem();
            e_24.Name = "e_24";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_24.Header = "Shapes";
            // e_25 element
            Grid e_25 = new Grid();
            e_24.Content = e_25;
            e_25.Name = "e_25";
            RowDefinition row_e_25_0 = new RowDefinition();
            e_25.RowDefinitions.Add(row_e_25_0);
            RowDefinition row_e_25_1 = new RowDefinition();
            e_25.RowDefinitions.Add(row_e_25_1);
            RowDefinition row_e_25_2 = new RowDefinition();
            e_25.RowDefinitions.Add(row_e_25_2);
            ColumnDefinition col_e_25_0 = new ColumnDefinition();
            e_25.ColumnDefinitions.Add(col_e_25_0);
            ColumnDefinition col_e_25_1 = new ColumnDefinition();
            e_25.ColumnDefinitions.Add(col_e_25_1);
            ColumnDefinition col_e_25_2 = new ColumnDefinition();
            e_25.ColumnDefinitions.Add(col_e_25_2);
            // e_26 element
            Rectangle e_26 = new Rectangle();
            e_25.Children.Add(e_26);
            e_26.Name = "e_26";
            e_26.Height = 100F;
            e_26.Width = 200F;
            e_26.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_26.Fill = new SolidColorBrush(new ColorW(0, 128, 0, 255));
            e_26.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_26.StrokeThickness = 5F;
            e_26.RadiusX = 10F;
            e_26.RadiusY = 10F;
            // e_27 element
            Rectangle e_27 = new Rectangle();
            e_25.Children.Add(e_27);
            e_27.Name = "e_27";
            e_27.Height = 100F;
            e_27.Width = 200F;
            e_27.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_27.Fill = new SolidColorBrush(new ColorW(255, 165, 0, 255));
            Grid.SetColumn(e_27, 1);
            // e_28 element
            Rectangle e_28 = new Rectangle();
            e_25.Children.Add(e_28);
            e_28.Name = "e_28";
            e_28.Height = 100F;
            e_28.Width = 200F;
            e_28.Margin = new Thickness(5F, 5F, 5F, 5F);
            LinearGradientBrush e_28_Fill = new LinearGradientBrush();
            e_28_Fill.StartPoint = new PointF(0F, 0F);
            e_28_Fill.EndPoint = new PointF(1F, 1F);
            e_28_Fill.SpreadMethod = GradientSpreadMethod.Pad;
            e_28_Fill.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0.5F));
            e_28_Fill.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0F));
            e_28.Fill = e_28_Fill;
            LinearGradientBrush e_28_Stroke = new LinearGradientBrush();
            e_28_Stroke.StartPoint = new PointF(0F, 0F);
            e_28_Stroke.EndPoint = new PointF(1F, 1F);
            e_28_Stroke.SpreadMethod = GradientSpreadMethod.Pad;
            e_28_Stroke.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0.5F));
            e_28_Stroke.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0F));
            e_28.Stroke = e_28_Stroke;
            e_28.StrokeThickness = 5F;
            e_28.RadiusX = 10F;
            e_28.RadiusY = 10F;
            Grid.SetColumn(e_28, 2);
            // e_29 element
            Ellipse e_29 = new Ellipse();
            e_25.Children.Add(e_29);
            e_29.Name = "e_29";
            e_29.Height = 100F;
            e_29.Width = 200F;
            e_29.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_29.Fill = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_29.Stroke = new SolidColorBrush(new ColorW(0, 128, 0, 255));
            e_29.StrokeThickness = 10F;
            Grid.SetRow(e_29, 1);
            // e_30 element
            Ellipse e_30 = new Ellipse();
            e_25.Children.Add(e_30);
            e_30.Name = "e_30";
            e_30.Height = 100F;
            e_30.Width = 200F;
            e_30.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_30.Stroke = new SolidColorBrush(new ColorW(255, 165, 0, 255));
            e_30.StrokeThickness = 10F;
            Grid.SetColumn(e_30, 1);
            Grid.SetRow(e_30, 1);
            // e_31 element
            Ellipse e_31 = new Ellipse();
            e_25.Children.Add(e_31);
            e_31.Name = "e_31";
            e_31.Height = 100F;
            e_31.Width = 200F;
            e_31.Margin = new Thickness(5F, 5F, 5F, 5F);
            LinearGradientBrush e_31_Fill = new LinearGradientBrush();
            e_31_Fill.StartPoint = new PointF(0F, 0F);
            e_31_Fill.EndPoint = new PointF(1F, 1F);
            e_31_Fill.SpreadMethod = GradientSpreadMethod.Pad;
            e_31_Fill.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0.5F));
            e_31_Fill.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0F));
            e_31.Fill = e_31_Fill;
            LinearGradientBrush e_31_Stroke = new LinearGradientBrush();
            e_31_Stroke.StartPoint = new PointF(0F, 0F);
            e_31_Stroke.EndPoint = new PointF(1F, 1F);
            e_31_Stroke.SpreadMethod = GradientSpreadMethod.Pad;
            e_31_Stroke.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0.5F));
            e_31_Stroke.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0F));
            e_31.Stroke = e_31_Stroke;
            e_31.StrokeThickness = 10F;
            Grid.SetColumn(e_31, 2);
            Grid.SetRow(e_31, 1);
            // e_32 element
            Line e_32 = new Line();
            e_25.Children.Add(e_32);
            e_32.Name = "e_32";
            e_32.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_32.StrokeThickness = 10F;
            e_32.X1 = 10F;
            e_32.X2 = 150F;
            e_32.Y1 = 10F;
            e_32.Y2 = 150F;
            Grid.SetRow(e_32, 2);
            // e_33 element
            Line e_33 = new Line();
            e_25.Children.Add(e_33);
            e_33.Name = "e_33";
            e_33.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_33.StrokeThickness = 10F;
            e_33.X1 = 100F;
            e_33.X2 = 100F;
            e_33.Y1 = 10F;
            e_33.Y2 = 100F;
            Grid.SetRow(e_33, 2);
            // e_34 element
            Line e_34 = new Line();
            e_25.Children.Add(e_34);
            e_34.Name = "e_34";
            e_34.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_34.StrokeThickness = 10F;
            e_34.X1 = 10F;
            e_34.X2 = 100F;
            e_34.Y1 = 100F;
            e_34.Y2 = 100F;
            Grid.SetRow(e_34, 2);
            // e_35 element
            Rectangle e_35 = new Rectangle();
            e_25.Children.Add(e_35);
            e_35.Name = "e_35";
            e_35.Height = 100F;
            e_35.Width = 200F;
            e_35.Margin = new Thickness(5F, 5F, 5F, 5F);
            ImageBrush e_35_Fill = new ImageBrush();
            BitmapImage e_35_Fill_bm = new BitmapImage();
            e_35_Fill_bm.TextureAsset = "Images/MonoGameLogo";
            ImageManager.Instance.AddImage("Images/MonoGameLogo");
            e_35_Fill.ImageSource = e_35_Fill_bm;
            e_35_Fill.Stretch = Stretch.None;
            e_35.Fill = e_35_Fill;
            e_35.Stroke = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_35.StrokeThickness = 1F;
            e_35.RadiusX = 10F;
            e_35.RadiusY = 10F;
            Grid.SetColumn(e_35, 1);
            Grid.SetRow(e_35, 2);
            items.Add(e_24);
            // e_36 element
            TabItem e_36 = new TabItem();
            e_36.Name = "e_36";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_36.Header = "Animations";
            // e_37 element
            Grid e_37 = new Grid();
            e_36.Content = e_37;
            e_37.Name = "e_37";
            ColumnDefinition col_e_37_0 = new ColumnDefinition();
            e_37.ColumnDefinitions.Add(col_e_37_0);
            ColumnDefinition col_e_37_1 = new ColumnDefinition();
            e_37.ColumnDefinitions.Add(col_e_37_1);
            // e_38 element
            StackPanel e_38 = new StackPanel();
            e_37.Children.Add(e_38);
            e_38.Name = "e_38";
            // animButton1 element
            Button animButton1 = new Button();
            e_38.Children.Add(animButton1);
            animButton1.Name = "animButton1";
            animButton1.TabIndex = 1;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            animButton1.Content = "Mouse Over me!";
            animButton1.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton2 element
            Button animButton2 = new Button();
            e_38.Children.Add(animButton2);
            animButton2.Name = "animButton2";
            animButton2.TabIndex = 2;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            animButton2.Content = "Mouse Over me!";
            animButton2.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton3 element
            Button animButton3 = new Button();
            e_38.Children.Add(animButton3);
            animButton3.Name = "animButton3";
            animButton3.TabIndex = 3;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            animButton3.Content = "Mouse Over me!";
            animButton3.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton4 element
            Button animButton4 = new Button();
            e_38.Children.Add(animButton4);
            animButton4.Name = "animButton4";
            animButton4.TabIndex = 4;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            animButton4.Content = "Mouse Over me!";
            animButton4.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animBorder1 element
            Border animBorder1 = new Border();
            e_37.Children.Add(animBorder1);
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
            e_37.Children.Add(animBorder2);
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
            items.Add(e_36);
            return items;
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
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_e_7_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_8 element
            ListBoxItem e_8 = new ListBoxItem();
            e_8.Name = "e_8";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_8.Content = "Selection 1";
            items.Add(e_8);
            // e_9 element
            ListBoxItem e_9 = new ListBoxItem();
            e_9.Name = "e_9";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_9.Content = "Selection 2";
            items.Add(e_9);
            // e_10 element
            ListBoxItem e_10 = new ListBoxItem();
            e_10.Name = "e_10";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_10.Content = "Selection 3";
            items.Add(e_10);
            // e_11 element
            ListBoxItem e_11 = new ListBoxItem();
            e_11.Name = "e_11";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_11.Content = "Selection 4";
            items.Add(e_11);
            // e_12 element
            ListBoxItem e_12 = new ListBoxItem();
            e_12.Name = "e_12";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_12.Content = "Selection 5";
            items.Add(e_12);
            // e_13 element
            ListBoxItem e_13 = new ListBoxItem();
            e_13.Name = "e_13";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_13.Content = "Selection 6";
            items.Add(e_13);
            return items;
        }
        
        private static UIElement e_15_Col3_ct_dtMethod(UIElement parent) {
            // e_17 element
            StackPanel e_17 = new StackPanel();
            e_17.Parent = parent;
            e_17.Name = "e_17";
            // e_18 element
            TextBlock e_18 = new TextBlock();
            e_17.Children.Add(e_18);
            e_18.Name = "e_18";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_18_Text = new Binding("Text");
            e_18.SetBinding(TextBlock.TextProperty, binding_e_18_Text);
            // e_19 element
            StackPanel e_19 = new StackPanel();
            e_17.Children.Add(e_19);
            e_19.Name = "e_19";
            e_19.Orientation = Orientation.Horizontal;
            // e_20 element
            TextBlock e_20 = new TextBlock();
            e_19.Children.Add(e_20);
            e_20.Name = "e_20";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_20_Text = new Binding("Boolean");
            e_20.SetBinding(TextBlock.TextProperty, binding_e_20_Text);
            // e_21 element
            TextBlock e_21 = new TextBlock();
            e_19.Children.Add(e_21);
            e_21.Name = "e_21";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_21_Text = new Binding("Number");
            e_21.SetBinding(TextBlock.TextProperty, binding_e_21_Text);
            return e_17;
        }
    }
}

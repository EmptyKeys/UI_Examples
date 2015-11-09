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
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Shapes;
    using EmptyKeys.UserInterface.Renderers;
    using EmptyKeys.UserInterface.Themes;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "1.11.0.0")]
    public partial class BasicUI : UIRoot {
        
        private Grid e_0;
        
        private StackPanel e_1;
        
        private Image logo;
        
        private TextBlock e_2;
        
        private TabControl TabControl;
        
        public BasicUI() : 
                base() {
            this.Initialize();
        }
        
        public BasicUI(int width, int height) : 
                base(width, height) {
            this.Initialize();
        }
        
        private void Initialize() {
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
            RowDefinition row_e_4_10 = new RowDefinition();
            row_e_4_10.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_10);
            RowDefinition row_e_4_11 = new RowDefinition();
            row_e_4_11.Height = new GridLength(1F, GridUnitType.Auto);
            e_4.RowDefinitions.Add(row_e_4_11);
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
            e_11.Text = "Numeric";
            Grid.SetRow(e_11, 7);
            // numTextBox element
            NumericTextBox numTextBox = new NumericTextBox();
            e_4.Children.Add(numTextBox);
            numTextBox.Name = "numTextBox";
            numTextBox.Width = 200F;
            numTextBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            numTextBox.HorizontalAlignment = HorizontalAlignment.Left;
            numTextBox.TabIndex = 5;
            numTextBox.ValueFormat = "F0";
            numTextBox.ValueStyle = ((System.Globalization.NumberStyles)(7));
            Grid.SetColumn(numTextBox, 1);
            Grid.SetRow(numTextBox, 7);
            Binding binding_numTextBox_Value = new Binding("NumericTextBoxValue");
            numTextBox.SetBinding(NumericTextBox.ValueProperty, binding_numTextBox_Value);
            // e_12 element
            TextBlock e_12 = new TextBlock();
            e_4.Children.Add(e_12);
            e_12.Name = "e_12";
            e_12.VerticalAlignment = VerticalAlignment.Center;
            e_12.Text = "PasswordBox";
            Grid.SetRow(e_12, 8);
            // e_13 element
            PasswordBox e_13 = new PasswordBox();
            e_4.Children.Add(e_13);
            e_13.Name = "e_13";
            e_13.Width = 200F;
            e_13.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_13.HorizontalAlignment = HorizontalAlignment.Left;
            e_13.TabIndex = 6;
            Grid.SetColumn(e_13, 1);
            Grid.SetRow(e_13, 8);
            Binding binding_e_13_Password = new Binding("Password");
            e_13.SetBinding(PasswordBox.PasswordProperty, binding_e_13_Password);
            // e_14 element
            TextBlock e_14 = new TextBlock();
            e_4.Children.Add(e_14);
            e_14.Name = "e_14";
            e_14.VerticalAlignment = VerticalAlignment.Center;
            e_14.Text = "ComboBox";
            Grid.SetRow(e_14, 9);
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
            Grid.SetRow(combo, 9);
            // e_15 element
            TextBlock e_15 = new TextBlock();
            e_4.Children.Add(e_15);
            e_15.Name = "e_15";
            e_15.VerticalAlignment = VerticalAlignment.Center;
            e_15.Text = "ListBox";
            Grid.SetRow(e_15, 10);
            // e_16 element
            ListBox e_16 = new ListBox();
            e_4.Children.Add(e_16);
            e_16.Name = "e_16";
            e_16.TabIndex = 8;
            e_16.ItemsSource = Get_e_16_Items();
            Grid.SetColumn(e_16, 1);
            Grid.SetRow(e_16, 10);
            // e_23 element
            TextBlock e_23 = new TextBlock();
            e_4.Children.Add(e_23);
            e_23.Name = "e_23";
            e_23.VerticalAlignment = VerticalAlignment.Center;
            e_23.Text = "RadioButton";
            Grid.SetRow(e_23, 11);
            // e_24 element
            StackPanel e_24 = new StackPanel();
            e_4.Children.Add(e_24);
            e_24.Name = "e_24";
            e_24.Orientation = Orientation.Horizontal;
            Grid.SetColumn(e_24, 1);
            Grid.SetRow(e_24, 11);
            // e_25 element
            RadioButton e_25 = new RadioButton();
            e_24.Children.Add(e_25);
            e_25.Name = "e_25";
            e_25.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_25.Content = "Radio Button 1";
            e_25.GroupName = "testGroup1";
            // e_26 element
            RadioButton e_26 = new RadioButton();
            e_24.Children.Add(e_26);
            e_26.Name = "e_26";
            e_26.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_26.Content = "Radio Button 2";
            e_26.GroupName = "testGroup1";
            // e_27 element
            RadioButton e_27 = new RadioButton();
            e_24.Children.Add(e_27);
            e_27.Name = "e_27";
            e_27.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_27.Content = "Radio Button 3";
            e_27.GroupName = "testGroup1";
            // e_28 element
            RadioButton e_28 = new RadioButton();
            e_24.Children.Add(e_28);
            e_28.Name = "e_28";
            e_28.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_28.Content = "Radio Button 4";
            e_28.GroupName = "testGroup2";
            // e_29 element
            RadioButton e_29 = new RadioButton();
            e_24.Children.Add(e_29);
            e_29.Name = "e_29";
            e_29.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_29.Content = "Radio Button 5";
            e_29.GroupName = "testGroup2";
            // e_30 element
            RadioButton e_30 = new RadioButton();
            e_24.Children.Add(e_30);
            e_30.Name = "e_30";
            e_30.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_30.Content = "Radio Button 6";
            e_30.GroupName = "testGroup2";
            items.Add(e_3);
            // e_31 element
            TabItem e_31 = new TabItem();
            e_31.Name = "e_31";
            e_31.Header = "DataGrid";
            // e_32 element
            DataGrid e_32 = new DataGrid();
            e_31.Content = e_32;
            e_32.Name = "e_32";
            e_32.AutoGenerateColumns = false;
            DataGridTextColumn e_32_Col0 = new DataGridTextColumn();
            e_32_Col0.Header = "#";
            Binding e_32_Col0_b = new Binding("Number");
            e_32_Col0.Binding = e_32_Col0_b;
            e_32.Columns.Add(e_32_Col0);
            DataGridTextColumn e_32_Col1 = new DataGridTextColumn();
            e_32_Col1.Width = 200F;
            e_32_Col1.Header = "Text";
            Style e_32_Col1_e_s = new Style(typeof(DataGridCell));
            Setter e_32_Col1_e_s_S_0 = new Setter(DataGridCell.BackgroundProperty, new SolidColorBrush(new ColorW(128, 128, 128, 255)));
            e_32_Col1_e_s.Setters.Add(e_32_Col1_e_s_S_0);
            Setter e_32_Col1_e_s_S_1 = new Setter(DataGridCell.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            e_32_Col1_e_s.Setters.Add(e_32_Col1_e_s_S_1);
            Setter e_32_Col1_e_s_S_2 = new Setter(DataGridCell.VerticalAlignmentProperty, VerticalAlignment.Center);
            e_32_Col1_e_s.Setters.Add(e_32_Col1_e_s_S_2);
            e_32_Col1.ElementStyle = e_32_Col1_e_s;
            Binding e_32_Col1_b = new Binding("Text");
            e_32_Col1.Binding = e_32_Col1_b;
            e_32.Columns.Add(e_32_Col1);
            DataGridCheckBoxColumn e_32_Col2 = new DataGridCheckBoxColumn();
            e_32_Col2.Width = DataGridLength.SizeToHeader;
            e_32_Col2.Header = "Bool";
            Binding e_32_Col2_b = new Binding("Boolean");
            e_32_Col2.Binding = e_32_Col2_b;
            e_32.Columns.Add(e_32_Col2);
            DataGridTemplateColumn e_32_Col3 = new DataGridTemplateColumn();
            e_32_Col3.Width = new DataGridLength(1F, DataGridLengthUnitType.Star);
            // e_33 element
            TextBlock e_33 = new TextBlock();
            e_33.Name = "e_33";
            e_33.Text = "Template Column";
            e_32_Col3.Header = e_33;
            Style e_32_Col3_h_s = new Style(typeof(DataGridColumnHeader));
            Setter e_32_Col3_h_s_S_0 = new Setter(DataGridColumnHeader.ForegroundProperty, new SolidColorBrush(new ColorW(255, 165, 0, 255)));
            e_32_Col3_h_s.Setters.Add(e_32_Col3_h_s_S_0);
            e_32_Col3.HeaderStyle = e_32_Col3_h_s;
            Func<UIElement, UIElement> e_32_Col3_ct_dtFunc = e_32_Col3_ct_dtMethod;
            e_32_Col3.CellTemplate = new DataTemplate(e_32_Col3_ct_dtFunc);
            e_32.Columns.Add(e_32_Col3);
            Binding binding_e_32_ItemsSource = new Binding("GridData");
            e_32.SetBinding(DataGrid.ItemsSourceProperty, binding_e_32_ItemsSource);
            items.Add(e_31);
            // e_39 element
            TabItem e_39 = new TabItem();
            e_39.Name = "e_39";
            e_39.Header = "TreeView";
            // e_40 element
            TreeView e_40 = new TreeView();
            e_39.Content = e_40;
            e_40.Name = "e_40";
            Binding binding_e_40_ItemsSource = new Binding("TreeItems");
            e_40.SetBinding(TreeView.ItemsSourceProperty, binding_e_40_ItemsSource);
            items.Add(e_39);
            // e_41 element
            TabItem e_41 = new TabItem();
            e_41.Name = "e_41";
            e_41.Header = "Chart";
            // e_42 element
            Chart e_42 = new Chart();
            e_41.Content = e_42;
            e_42.Name = "e_42";
            e_42.AxisYMajorUnit = 50F;
            // e_43 element
            LineSeries2D e_43 = new LineSeries2D();
            e_42.Series.Add(e_43);
            e_43.Name = "e_43";
            // p_44 point
            SeriesPoint p_44 = new SeriesPoint();
            e_43.Points.Add(p_44);
            p_44.Argument = 0F;
            p_44.Value = 0F;
            // p_45 point
            SeriesPoint p_45 = new SeriesPoint();
            e_43.Points.Add(p_45);
            p_45.Argument = 1F;
            p_45.Value = 10F;
            // p_46 point
            SeriesPoint p_46 = new SeriesPoint();
            e_43.Points.Add(p_46);
            p_46.Argument = 2F;
            p_46.Value = 20F;
            // p_47 point
            SeriesPoint p_47 = new SeriesPoint();
            e_43.Points.Add(p_47);
            p_47.Argument = 3F;
            p_47.Value = 50F;
            // p_48 point
            SeriesPoint p_48 = new SeriesPoint();
            e_43.Points.Add(p_48);
            p_48.Argument = 4F;
            p_48.Value = 100F;
            // p_49 point
            SeriesPoint p_49 = new SeriesPoint();
            e_43.Points.Add(p_49);
            p_49.Argument = 5F;
            p_49.Value = 200F;
            // p_50 point
            SeriesPoint p_50 = new SeriesPoint();
            e_43.Points.Add(p_50);
            p_50.Argument = 6F;
            p_50.Value = 500F;
            // e_51 element
            LineSeries2D e_51 = new LineSeries2D();
            e_42.Series.Add(e_51);
            e_51.Name = "e_51";
            e_51.Foreground = new SolidColorBrush(new ColorW(255, 165, 0, 255));
            e_51.LineThickness = 1F;
            Binding binding_e_51_DataSource = new Binding("ChartData");
            e_51.SetBinding(LineSeries2D.DataSourceProperty, binding_e_51_DataSource);
            items.Add(e_41);
            // e_52 element
            TabItem e_52 = new TabItem();
            e_52.Name = "e_52";
            e_52.Header = "Shapes";
            // e_53 element
            Grid e_53 = new Grid();
            e_52.Content = e_53;
            e_53.Name = "e_53";
            RowDefinition row_e_53_0 = new RowDefinition();
            e_53.RowDefinitions.Add(row_e_53_0);
            RowDefinition row_e_53_1 = new RowDefinition();
            e_53.RowDefinitions.Add(row_e_53_1);
            RowDefinition row_e_53_2 = new RowDefinition();
            e_53.RowDefinitions.Add(row_e_53_2);
            ColumnDefinition col_e_53_0 = new ColumnDefinition();
            e_53.ColumnDefinitions.Add(col_e_53_0);
            ColumnDefinition col_e_53_1 = new ColumnDefinition();
            e_53.ColumnDefinitions.Add(col_e_53_1);
            ColumnDefinition col_e_53_2 = new ColumnDefinition();
            e_53.ColumnDefinitions.Add(col_e_53_2);
            // e_54 element
            Rectangle e_54 = new Rectangle();
            e_53.Children.Add(e_54);
            e_54.Name = "e_54";
            e_54.Height = 100F;
            e_54.Width = 200F;
            e_54.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_54.Fill = new SolidColorBrush(new ColorW(0, 128, 0, 255));
            e_54.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_54.StrokeThickness = 5F;
            e_54.RadiusX = 10F;
            e_54.RadiusY = 10F;
            // e_55 element
            Rectangle e_55 = new Rectangle();
            e_53.Children.Add(e_55);
            e_55.Name = "e_55";
            e_55.Height = 100F;
            e_55.Width = 200F;
            e_55.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_55.Fill = new SolidColorBrush(new ColorW(255, 165, 0, 255));
            Grid.SetColumn(e_55, 1);
            // e_56 element
            Rectangle e_56 = new Rectangle();
            e_53.Children.Add(e_56);
            e_56.Name = "e_56";
            e_56.Height = 100F;
            e_56.Width = 200F;
            e_56.Margin = new Thickness(5F, 5F, 5F, 5F);
            LinearGradientBrush e_56_Fill = new LinearGradientBrush();
            e_56_Fill.StartPoint = new PointF(0F, 0F);
            e_56_Fill.EndPoint = new PointF(1F, 1F);
            e_56_Fill.SpreadMethod = GradientSpreadMethod.Pad;
            e_56_Fill.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0.5F));
            e_56_Fill.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0F));
            e_56.Fill = e_56_Fill;
            LinearGradientBrush e_56_Stroke = new LinearGradientBrush();
            e_56_Stroke.StartPoint = new PointF(0F, 0F);
            e_56_Stroke.EndPoint = new PointF(1F, 1F);
            e_56_Stroke.SpreadMethod = GradientSpreadMethod.Pad;
            e_56_Stroke.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0.5F));
            e_56_Stroke.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0F));
            e_56.Stroke = e_56_Stroke;
            e_56.StrokeThickness = 5F;
            e_56.RadiusX = 10F;
            e_56.RadiusY = 10F;
            Grid.SetColumn(e_56, 2);
            // e_57 element
            Ellipse e_57 = new Ellipse();
            e_53.Children.Add(e_57);
            e_57.Name = "e_57";
            e_57.Height = 100F;
            e_57.Width = 200F;
            e_57.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_57.Fill = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_57.Stroke = new SolidColorBrush(new ColorW(0, 128, 0, 255));
            e_57.StrokeThickness = 10F;
            Grid.SetRow(e_57, 1);
            // e_58 element
            Ellipse e_58 = new Ellipse();
            e_53.Children.Add(e_58);
            e_58.Name = "e_58";
            e_58.Height = 100F;
            e_58.Width = 200F;
            e_58.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_58.Stroke = new SolidColorBrush(new ColorW(255, 165, 0, 255));
            e_58.StrokeThickness = 10F;
            Grid.SetColumn(e_58, 1);
            Grid.SetRow(e_58, 1);
            // e_59 element
            Ellipse e_59 = new Ellipse();
            e_53.Children.Add(e_59);
            e_59.Name = "e_59";
            e_59.Height = 100F;
            e_59.Width = 200F;
            e_59.Margin = new Thickness(5F, 5F, 5F, 5F);
            LinearGradientBrush e_59_Fill = new LinearGradientBrush();
            e_59_Fill.StartPoint = new PointF(0F, 0F);
            e_59_Fill.EndPoint = new PointF(1F, 1F);
            e_59_Fill.SpreadMethod = GradientSpreadMethod.Pad;
            e_59_Fill.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0.5F));
            e_59_Fill.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0F));
            e_59.Fill = e_59_Fill;
            LinearGradientBrush e_59_Stroke = new LinearGradientBrush();
            e_59_Stroke.StartPoint = new PointF(0F, 0F);
            e_59_Stroke.EndPoint = new PointF(1F, 1F);
            e_59_Stroke.SpreadMethod = GradientSpreadMethod.Pad;
            e_59_Stroke.GradientStops.Add(new GradientStop(new ColorW(0, 162, 255, 255), 0.5F));
            e_59_Stroke.GradientStops.Add(new GradientStop(new ColorW(255, 165, 0, 255), 0F));
            e_59.Stroke = e_59_Stroke;
            e_59.StrokeThickness = 10F;
            Grid.SetColumn(e_59, 2);
            Grid.SetRow(e_59, 1);
            // e_60 element
            Line e_60 = new Line();
            e_53.Children.Add(e_60);
            e_60.Name = "e_60";
            e_60.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_60.StrokeThickness = 10F;
            e_60.X1 = 10F;
            e_60.X2 = 150F;
            e_60.Y1 = 10F;
            e_60.Y2 = 150F;
            Grid.SetRow(e_60, 2);
            // e_61 element
            Line e_61 = new Line();
            e_53.Children.Add(e_61);
            e_61.Name = "e_61";
            e_61.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_61.StrokeThickness = 10F;
            e_61.X1 = 100F;
            e_61.X2 = 100F;
            e_61.Y1 = 10F;
            e_61.Y2 = 100F;
            Grid.SetRow(e_61, 2);
            // e_62 element
            Line e_62 = new Line();
            e_53.Children.Add(e_62);
            e_62.Name = "e_62";
            e_62.Stroke = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_62.StrokeThickness = 10F;
            e_62.X1 = 10F;
            e_62.X2 = 100F;
            e_62.Y1 = 100F;
            e_62.Y2 = 100F;
            Grid.SetRow(e_62, 2);
            // e_63 element
            Rectangle e_63 = new Rectangle();
            e_53.Children.Add(e_63);
            e_63.Name = "e_63";
            e_63.Height = 100F;
            e_63.Width = 200F;
            e_63.Margin = new Thickness(5F, 5F, 5F, 5F);
            ImageBrush e_63_Fill = new ImageBrush();
            BitmapImage e_63_Fill_bm = new BitmapImage();
            e_63_Fill_bm.TextureAsset = "Images/MonoGameLogo";
            e_63_Fill.ImageSource = e_63_Fill_bm;
            e_63_Fill.Stretch = Stretch.None;
            e_63.Fill = e_63_Fill;
            e_63.Stroke = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_63.StrokeThickness = 1F;
            e_63.RadiusX = 10F;
            e_63.RadiusY = 10F;
            Grid.SetColumn(e_63, 1);
            Grid.SetRow(e_63, 2);
            items.Add(e_52);
            // e_64 element
            TabItem e_64 = new TabItem();
            e_64.Name = "e_64";
            e_64.Header = "Animations";
            // e_65 element
            Grid e_65 = new Grid();
            e_64.Content = e_65;
            e_65.Name = "e_65";
            ColumnDefinition col_e_65_0 = new ColumnDefinition();
            e_65.ColumnDefinitions.Add(col_e_65_0);
            ColumnDefinition col_e_65_1 = new ColumnDefinition();
            e_65.ColumnDefinitions.Add(col_e_65_1);
            // e_66 element
            StackPanel e_66 = new StackPanel();
            e_65.Children.Add(e_66);
            e_66.Name = "e_66";
            // animButton1 element
            Button animButton1 = new Button();
            e_66.Children.Add(animButton1);
            animButton1.Name = "animButton1";
            animButton1.TabIndex = 1;
            animButton1.Content = "Mouse Over me!";
            animButton1.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton2 element
            Button animButton2 = new Button();
            e_66.Children.Add(animButton2);
            animButton2.Name = "animButton2";
            animButton2.TabIndex = 2;
            animButton2.Content = "Mouse Over me!";
            animButton2.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton3 element
            Button animButton3 = new Button();
            e_66.Children.Add(animButton3);
            animButton3.Name = "animButton3";
            animButton3.TabIndex = 3;
            animButton3.Content = "Mouse Over me!";
            animButton3.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animButton4 element
            Button animButton4 = new Button();
            e_66.Children.Add(animButton4);
            animButton4.Name = "animButton4";
            animButton4.TabIndex = 4;
            animButton4.Content = "Mouse Over me!";
            animButton4.SetResourceReference(Button.StyleProperty, "buttonAnimStyle");
            // animBorder1 element
            Border animBorder1 = new Border();
            e_65.Children.Add(animBorder1);
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
            e_65.Children.Add(animBorder2);
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
            items.Add(e_64);
            // e_67 element
            TabItem e_67 = new TabItem();
            e_67.Name = "e_67";
            e_67.Header = "Tetris";
            // e_68 element
            Border e_68 = new Border();
            e_67.Content = e_68;
            e_68.Name = "e_68";
            // e_69 element
            Grid e_69 = new Grid();
            e_68.Child = e_69;
            e_69.Name = "e_69";
            e_69.Margin = new Thickness(10F, 10F, 10F, 10F);
            RowDefinition row_e_69_0 = new RowDefinition();
            row_e_69_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_69.RowDefinitions.Add(row_e_69_0);
            RowDefinition row_e_69_1 = new RowDefinition();
            row_e_69_1.Height = new GridLength(420F, GridUnitType.Pixel);
            e_69.RowDefinitions.Add(row_e_69_1);
            ColumnDefinition col_e_69_0 = new ColumnDefinition();
            e_69.ColumnDefinitions.Add(col_e_69_0);
            ColumnDefinition col_e_69_1 = new ColumnDefinition();
            e_69.ColumnDefinitions.Add(col_e_69_1);
            ColumnDefinition col_e_69_2 = new ColumnDefinition();
            e_69.ColumnDefinitions.Add(col_e_69_2);
            // e_70 element
            StackPanel e_70 = new StackPanel();
            e_69.Children.Add(e_70);
            e_70.Name = "e_70";
            e_70.HorizontalAlignment = HorizontalAlignment.Right;
            e_70.Orientation = Orientation.Vertical;
            Grid.SetRow(e_70, 1);
            // e_71 element
            TextBlock e_71 = new TextBlock();
            e_70.Children.Add(e_71);
            e_71.Name = "e_71";
            e_71.Text = "Next";
            // e_72 element
            Border e_72 = new Border();
            e_70.Children.Add(e_72);
            e_72.Name = "e_72";
            e_72.Height = 81F;
            e_72.Width = 81F;
            e_72.BorderBrush = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_72.BorderThickness = new Thickness(0F, 0F, 1F, 1F);
            // tetrisNextContainer1 element
            Canvas tetrisNextContainer1 = new Canvas();
            e_72.Child = tetrisNextContainer1;
            tetrisNextContainer1.Name = "tetrisNextContainer1";
            tetrisNextContainer1.Height = 80F;
            tetrisNextContainer1.Width = 80F;
            // e_73 element
            Border e_73 = new Border();
            e_69.Children.Add(e_73);
            e_73.Name = "e_73";
            e_73.Height = 401F;
            e_73.Width = 201F;
            e_73.BorderBrush = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_73.BorderThickness = new Thickness(0F, 0F, 1F, 1F);
            Grid.SetColumn(e_73, 1);
            Grid.SetRow(e_73, 1);
            // tetrisContainer1 element
            Canvas tetrisContainer1 = new Canvas();
            e_73.Child = tetrisContainer1;
            tetrisContainer1.Name = "tetrisContainer1";
            tetrisContainer1.Height = 400F;
            tetrisContainer1.Width = 200F;
            tetrisContainer1.HorizontalAlignment = HorizontalAlignment.Left;
            tetrisContainer1.VerticalAlignment = VerticalAlignment.Top;
            // e_74 element
            Grid e_74 = new Grid();
            e_69.Children.Add(e_74);
            e_74.Name = "e_74";
            RowDefinition row_e_74_0 = new RowDefinition();
            row_e_74_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_74.RowDefinitions.Add(row_e_74_0);
            RowDefinition row_e_74_1 = new RowDefinition();
            row_e_74_1.Height = new GridLength(1F, GridUnitType.Auto);
            e_74.RowDefinitions.Add(row_e_74_1);
            ColumnDefinition col_e_74_0 = new ColumnDefinition();
            col_e_74_0.Width = new GridLength(1F, GridUnitType.Auto);
            e_74.ColumnDefinitions.Add(col_e_74_0);
            ColumnDefinition col_e_74_1 = new ColumnDefinition();
            col_e_74_1.Width = new GridLength(1F, GridUnitType.Star);
            e_74.ColumnDefinitions.Add(col_e_74_1);
            ColumnDefinition col_e_74_2 = new ColumnDefinition();
            col_e_74_2.Width = new GridLength(1F, GridUnitType.Auto);
            e_74.ColumnDefinitions.Add(col_e_74_2);
            Grid.SetColumnSpan(e_74, 3);
            Binding binding_e_74_DataContext = new Binding("Tetris");
            e_74.SetBinding(Grid.DataContextProperty, binding_e_74_DataContext);
            // e_75 element
            Button e_75 = new Button();
            e_74.Children.Add(e_75);
            e_75.Name = "e_75";
            e_75.Height = 30F;
            e_75.Content = "Start";
            Grid.SetColumnSpan(e_75, 3);
            Binding binding_e_75_Command = new Binding("StartCommand");
            e_75.SetBinding(Button.CommandProperty, binding_e_75_Command);
            // e_76 element
            Grid e_76 = new Grid();
            e_74.Children.Add(e_76);
            e_76.Name = "e_76";
            RowDefinition row_e_76_0 = new RowDefinition();
            row_e_76_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_76.RowDefinitions.Add(row_e_76_0);
            ColumnDefinition col_e_76_0 = new ColumnDefinition();
            e_76.ColumnDefinitions.Add(col_e_76_0);
            ColumnDefinition col_e_76_1 = new ColumnDefinition();
            col_e_76_1.Width = new GridLength(70F, GridUnitType.Pixel);
            e_76.ColumnDefinitions.Add(col_e_76_1);
            ColumnDefinition col_e_76_2 = new ColumnDefinition();
            e_76.ColumnDefinitions.Add(col_e_76_2);
            Grid.SetColumn(e_76, 1);
            Grid.SetRow(e_76, 1);
            // spPlayer1 element
            StackPanel spPlayer1 = new StackPanel();
            e_76.Children.Add(spPlayer1);
            spPlayer1.Name = "spPlayer1";
            spPlayer1.HorizontalAlignment = HorizontalAlignment.Right;
            spPlayer1.Orientation = Orientation.Vertical;
            // e_77 element
            TextBlock e_77 = new TextBlock();
            spPlayer1.Children.Add(e_77);
            e_77.Name = "e_77";
            Binding binding_e_77_Text = new Binding("Score");
            e_77.SetBinding(TextBlock.TextProperty, binding_e_77_Text);
            // e_78 element
            TextBlock e_78 = new TextBlock();
            spPlayer1.Children.Add(e_78);
            e_78.Name = "e_78";
            Binding binding_e_78_Text = new Binding("Lines");
            e_78.SetBinding(TextBlock.TextProperty, binding_e_78_Text);
            // e_79 element
            TextBlock e_79 = new TextBlock();
            spPlayer1.Children.Add(e_79);
            e_79.Name = "e_79";
            Binding binding_e_79_Text = new Binding("Level");
            e_79.SetBinding(TextBlock.TextProperty, binding_e_79_Text);
            // e_80 element
            StackPanel e_80 = new StackPanel();
            e_76.Children.Add(e_80);
            e_80.Name = "e_80";
            e_80.HorizontalAlignment = HorizontalAlignment.Center;
            e_80.Orientation = Orientation.Vertical;
            Grid.SetColumn(e_80, 1);
            // e_81 element
            TextBlock e_81 = new TextBlock();
            e_80.Children.Add(e_81);
            e_81.Name = "e_81";
            e_81.Text = "SCORE";
            // e_82 element
            TextBlock e_82 = new TextBlock();
            e_80.Children.Add(e_82);
            e_82.Name = "e_82";
            e_82.Text = "LINES";
            // e_83 element
            TextBlock e_83 = new TextBlock();
            e_80.Children.Add(e_83);
            e_83.Name = "e_83";
            e_83.Text = "LEVEL";
            // e_84 element
            StackPanel e_84 = new StackPanel();
            e_76.Children.Add(e_84);
            e_84.Name = "e_84";
            e_84.HorizontalAlignment = HorizontalAlignment.Left;
            e_84.Orientation = Orientation.Horizontal;
            // e_85 element
            TextBlock e_85 = new TextBlock();
            e_84.Children.Add(e_85);
            e_85.Name = "e_85";
            e_85.Text = "Use A,S,D,W for left, down, right, rotate";
            items.Add(e_67);
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
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_e_16_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_17 element
            ListBoxItem e_17 = new ListBoxItem();
            e_17.Name = "e_17";
            e_17.Content = "Selection 1";
            items.Add(e_17);
            // e_18 element
            ListBoxItem e_18 = new ListBoxItem();
            e_18.Name = "e_18";
            e_18.Content = "Selection 2";
            items.Add(e_18);
            // e_19 element
            ListBoxItem e_19 = new ListBoxItem();
            e_19.Name = "e_19";
            e_19.Content = "Selection 3";
            items.Add(e_19);
            // e_20 element
            ListBoxItem e_20 = new ListBoxItem();
            e_20.Name = "e_20";
            e_20.Content = "Selection 4";
            items.Add(e_20);
            // e_21 element
            ListBoxItem e_21 = new ListBoxItem();
            e_21.Name = "e_21";
            e_21.Content = "Selection 5";
            items.Add(e_21);
            // e_22 element
            ListBoxItem e_22 = new ListBoxItem();
            e_22.Name = "e_22";
            e_22.Content = "Selection 6";
            items.Add(e_22);
            return items;
        }
        
        private static UIElement e_32_Col3_ct_dtMethod(UIElement parent) {
            // e_34 element
            StackPanel e_34 = new StackPanel();
            e_34.Parent = parent;
            e_34.Name = "e_34";
            // e_35 element
            TextBlock e_35 = new TextBlock();
            e_34.Children.Add(e_35);
            e_35.Name = "e_35";
            Binding binding_e_35_Text = new Binding("Text");
            e_35.SetBinding(TextBlock.TextProperty, binding_e_35_Text);
            // e_36 element
            StackPanel e_36 = new StackPanel();
            e_34.Children.Add(e_36);
            e_36.Name = "e_36";
            e_36.Orientation = Orientation.Horizontal;
            // e_37 element
            TextBlock e_37 = new TextBlock();
            e_36.Children.Add(e_37);
            e_37.Name = "e_37";
            Binding binding_e_37_Text = new Binding("Boolean");
            e_37.SetBinding(TextBlock.TextProperty, binding_e_37_Text);
            // e_38 element
            TextBlock e_38 = new TextBlock();
            e_36.Children.Add(e_38);
            e_38.Name = "e_38";
            Binding binding_e_38_Text = new Binding("Number");
            e_38.SetBinding(TextBlock.TextProperty, binding_e_38_Text);
            return e_34;
        }
    }
}

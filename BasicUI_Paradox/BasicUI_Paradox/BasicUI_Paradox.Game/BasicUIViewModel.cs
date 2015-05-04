using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Mvvm;

namespace BasicUI_Paradox
{
    /// <summary>
    /// Example of MVVM View Model
    /// </summary>
    public class BasicUIViewModel : ViewModelBase
    {
        private string buttonResult;
        private string textBoxText;
        private float sliderValue;
        private int selectedIndex;
        private ExampleClass selectedItem;

        /// <summary>
        /// Gets or sets the button command.
        /// </summary>
        /// <value>
        /// The button command.
        /// </value>
        public ICommand ButtonCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the open message box.
        /// </summary>
        /// <value>
        /// The open message box.
        /// </value>
        public ICommand OpenMessageBox
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the button result.
        /// </summary>
        /// <value>
        /// The button result.
        /// </value>
        public string ButtonResult
        {
            get { return buttonResult; }
            set { SetProperty(ref buttonResult, value); }
        }

        /// <summary>
        /// Gets or sets the text box text.
        /// </summary>
        /// <value>
        /// The text box text.
        /// </value>
        public string TextBoxText
        {
            get { return textBoxText; }
            set { SetProperty(ref textBoxText, value); }
        }

        /// <summary>
        /// Gets or sets the slider value.
        /// </summary>
        /// <value>
        /// The slider value.
        /// </value>
        public float SliderValue
        {
            get { return sliderValue; }
            set { SetProperty(ref sliderValue, value); }
        }

        /// <summary>
        /// Gets the ListBox source.
        /// </summary>
        /// <value>
        /// The ListBox source.
        /// </value>
        public List<ExampleClass> ComboBoxSource
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the index of the selected.
        /// </summary>
        /// <value>
        /// The index of the selected.
        /// </value>
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                SetProperty(ref selectedIndex, value);
            }
        }

        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>
        /// The selected item.
        /// </value>
        public ExampleClass SelectedItem
        {
            get { return selectedItem; }
            set { SetProperty(ref selectedItem, value); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicUIViewModel"/> class.
        /// </summary>
        public BasicUIViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object>(ButtonClick));
            ComboBoxSource = new List<ExampleClass>();
            ComboBoxSource.Add(new ExampleClass { Name = "Item 1" });
            ComboBoxSource.Add(new ExampleClass { Name = "Item 2" });
            ComboBoxSource.Add(new ExampleClass { Name = "Item 3" });
            ComboBoxSource.Add(new ExampleClass { Name = "Item 4" });
            ComboBoxSource.Add(new ExampleClass { Name = "Item 5" });

            SelectedIndex = 1;
            SelectedItem = ComboBoxSource[3];

            OpenMessageBox = new RelayCommand(new Action<object>(OnOpenMessageBox));
        }

        private void OnOpenMessageBox(object obj)
        {
            var messageBoxService = base.GetService<IMessageBoxService>();
            if (messageBoxService != null)
            {
                RelayCommand result = new RelayCommand(new Action<object>(OnMessageBoxResult));
                messageBoxService.Show("Message box text", "Caption", MessageBoxButton.YesNoCancel, result);
            }
        }

        private void OnMessageBoxResult(object obj)
        {
            if (obj != null)
            {
                ButtonResult = obj.ToString();
            }
        }

        private void ButtonClick(object obj)
        {
            if (obj != null)
            {
                ButtonResult = obj.ToString();
            }
        }
    }
}


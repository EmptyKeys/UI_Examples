using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Mvvm;

namespace GameLibrary.ViewModels
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

        /// <summary>
        /// Gets or sets the button command.
        /// </summary>
        /// <value>
        /// The button command.
        /// </value>
        public ICommand ButtonCommand
        {
            get;
            set;
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
            set { SetProperty<string>(ref buttonResult, value); }
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
            set { SetProperty<string>(ref textBoxText, value); }
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
            set { SetProperty<float>(ref sliderValue, value); }
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
            get { return this.selectedIndex; }
            set
            {
                SetProperty<int>(ref this.selectedIndex, value);
            }
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

            SelectedIndex = 2;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Mvvm;

namespace GameUILibrary
{
    /// <summary>
    /// Example of MVVM View Model
    /// </summary>
    public class BasicUIViewModel : ViewModelBase
    {
        private string buttonResult;
        private string textBoxText;
        private bool buttonEnabled;
        private float progressValue;
        private float sliderValue;

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
        /// Gets or sets a value indicating whether [button enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [button enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool ButtonEnabled
        {
            get { return buttonEnabled; }
            set { SetProperty<bool>(ref buttonEnabled, value); }
        }

        /// <summary>
        /// Gets or sets the progress value.
        /// </summary>
        /// <value>
        /// The progress value.
        /// </value>
        public float ProgressValue
        {
            get { return progressValue; }
            set { SetProperty<float>(ref progressValue, value); }
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
        /// Initializes a new instance of the <see cref="BasicUIViewModel"/> class.
        /// </summary>
        public BasicUIViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object>(OnButtonClick));
        }

        private void OnButtonClick(object obj)
        {
            if (obj != null)
            {
                ButtonResult = obj.ToString();
                ProgressValue += 0.5f;
                ButtonEnabled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Mvvm;
using GameData;

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
        private List<TestTreeDataItem> treeItems;
        private List<TestDataGridModel> gridData;
        private ObservableCollection<WindowViewModel> windows;
        private TetrisController tetris;

        /// <summary>
        /// Gets or sets the tetris.
        /// </summary>
        /// <value>
        /// The tetris.
        /// </value>
        public TetrisController Tetris
        {
            get { return tetris; }
            set { SetProperty(ref tetris, value); }
        }        

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
        /// Gets or sets a value indicating whether [button enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [button enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool ButtonEnabled
        {
            get { return buttonEnabled; }
            set { SetProperty(ref buttonEnabled, value); }
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
            set { SetProperty(ref progressValue, value); }
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
        /// Gets or sets the tree items.
        /// </summary>
        /// <value>
        /// The tree items.
        /// </value>
        public List<TestTreeDataItem> TreeItems
        {
            get { return treeItems; }
            set { SetProperty(ref treeItems, value); }
        }

        /// <summary>
        /// Gets or sets the grid data.
        /// </summary>
        /// <value>
        /// The grid data.
        /// </value>
        public List<TestDataGridModel> GridData
        {
            get { return gridData; }
            set { SetProperty(ref gridData, value); }
        }

        /// <summary>
        /// Gets or sets the windows.
        /// </summary>
        /// <value>
        /// The windows.
        /// </value>
        public ObservableCollection<WindowViewModel> Windows
        {
            get { return windows; }
            set { SetProperty(ref windows, value); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicUIViewModel"/> class.
        /// </summary>
        public BasicUIViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object>(OnButtonClick));

            TreeItems = new List<TestTreeDataItem>
            {
                new TestTreeDataItem()
            };

            GridData = new List<TestDataGridModel>
            {
                new TestDataGridModel { Boolean = false, Number = 0, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 1, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = true, Number = 2, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = true, Number = 3, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 4, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 5, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 6, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 7, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 8, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 9, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 10, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 11, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 12, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 13, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 14, Text = "Lorem ipsum dolor sit amet" },
                new TestDataGridModel { Boolean = false, Number = 15, Text = "Lorem ipsum dolor sit amet" },
            };

            Windows = new ObservableCollection<WindowViewModel>();
            Windows.Add(new CustomWindow());            
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

        public void Update(double elapsedTime)
        {
            if (Tetris != null)
            {
                Tetris.Update(elapsedTime);
            }
        }
    }
}

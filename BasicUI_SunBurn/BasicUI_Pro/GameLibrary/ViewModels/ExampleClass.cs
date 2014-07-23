using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Mvvm;

namespace GameLibrary.ViewModels
{
    /// <summary>
    /// Example of model class
    /// </summary>
    public class ExampleClass : ViewModelBase
    {
        private string name;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return name; }
            set { SetProperty<string>(ref name, value); }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Mvvm;

namespace GameData
{
    /// <summary>
    /// Implements example tree data item
    /// </summary>
    public class TestTreeDataItem : BindableBase, ITreeDataItem
    {
        private bool isSelected;
        private bool isExpanded;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsEnabled
        {
            get
            {
                return true;
            }
        }        

        /// <summary>
        /// Gets a value indicating whether tree view item is selected.
        /// </summary>
        /// <value>
        /// <c>true</c> if tree view item is selected; otherwise, <c>false</c>.
        /// </value>
        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        /// <summary>
        /// Gets a value indicating whether tree view item is expanded.
        /// </summary>
        /// <value>
        /// <c>true</c> if tree view item is expanded; otherwise, <c>false</c>.
        /// </value>
        public bool IsExpanded
        {
            get { return isExpanded; }
            set { isExpanded = value; }
        }

        /// <summary>
        /// Gets a value indicating whether tree view item has children.
        /// </summary>
        /// <value>
        /// <c>true</c> if tree view item has children; otherwise, <c>false</c>.
        /// </value>
        public bool HasChildren
        {
            get { return true; }
        }

        /// <summary>
        /// Gets the children for tree view item
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetChildren()
        {
            List<TestTreeDataItem> children = new List<TestTreeDataItem>();
            Random random = new Random(DateTime.Now.Second);
            for (int i = 0; i < random.Next(1, 5); i++)
            {
                children.Add(new TestTreeDataItem());
            }

            return children;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestTreeDataItem"/> class.
        /// </summary>
        public TestTreeDataItem()
        {
            Name = "Tree Item " + Guid.NewGuid();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Name;
        }
    }
}

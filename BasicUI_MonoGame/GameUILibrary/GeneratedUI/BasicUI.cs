using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Controls;
using EmptyKeys.UserInterface.Media;

namespace EmptyKeys.UserInterface.Generated
{
    public partial class BasicUI
    {
        public Canvas TetrisNextContainer
        {
            get
            {
                TabItem item = TabControl.Items[5] as TabItem;
                Canvas canvas = VisualTreeHelper.Instance.FindElementByName(item, "tetrisNextContainer1") as Canvas;
                return canvas;                
            }            
        }

        public Canvas TetrisContainer
        {
            get
            {
                TabItem item = TabControl.Items[5] as TabItem;
                Canvas canvas = VisualTreeHelper.Instance.FindElementByName(item, "tetrisContainer1") as Canvas;
                return canvas;
            }
        }
    }
}

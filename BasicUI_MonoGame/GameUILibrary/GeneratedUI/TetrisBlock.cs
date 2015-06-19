using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Controls;
using EmptyKeys.UserInterface.Media;

namespace EmptyKeys.UserInterface.Generated
{
    public partial class TetrisBlock
    {
        public float Top
        {
            get { return (float)GetValue(Canvas.TopProperty); }
            set { SetValue(Canvas.TopProperty, value); }
        }

        public float Left
        {
            get { return (float)GetValue(Canvas.LeftProperty); }
            set { SetValue(Canvas.LeftProperty, value); }
        }

        public Brush Fill
        {
            get { return rect.Background; }
            set { rect.Background = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Media;

namespace GameUILibrary
{
    public class Tetris
    {
        private readonly CircularQueue<ushort> m_matrixs;
        private Brush _fill;

        public Tetris(CircularQueue<ushort> matrixs, Brush terisBrush)
        {
            m_matrixs = matrixs;
            this.Fill = terisBrush;
        }

        public CircularQueue<ushort> Matrixs
        {
            get { return m_matrixs; }
        }

        public Brush Fill
        {
            get { return _fill; }
            set
            {
                _fill = value;                
                value.Freeze();
            }
        }

        public ushort GetMatrix()
        {
            return Matrixs.Peek();
        }

        public void MatrixTransform()
        {
            Matrixs.Dequeue();
        }
    }
}

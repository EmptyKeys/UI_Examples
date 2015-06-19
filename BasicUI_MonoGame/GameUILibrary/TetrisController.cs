using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Controls;
using EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Media;
using EmptyKeys.UserInterface.Mvvm;

namespace GameUILibrary
{
    /// <summary>
    /// Implements Tetris based on code from https://code.google.com/p/wpf-tetris/
    /// </summary>
    public class TetrisController : BindableBase
    {
        private const int TETRIS_MAX_ROWS = 20;
        private const int TETRIS_MAX_COLUMNS = 10;
        private const int TETRIS_START_ROW = -4;
        private const int TETRIS_START_COLUMN = 3;
        private const int TETRIS_MAX_M = 4;
        private const int TETRIS_MAX_N = 4;
        private const int TETRIS_MAX_LEVEL = 10;
        private const int TETRIS_MIN_LEVEL = 1;
        private const int TETRIS_LINE_SCORE = 100;
        private const double TETRIS_INITIALIZE_MILLISECONDS = 500d;
        private const double TETRIS_INCREMENT_MILLISECONDS = 50d;
        private const float TETRIS_BLOCK_WIDTH = 20f;
        private const float TETRIS_BLOCK_HEIGHT = 20f;

        private static readonly CircularQueue<ushort> TetrisIGroup;
        private static readonly CircularQueue<ushort> TetrisJGroup;
        private static readonly CircularQueue<ushort> TetrisLGroup;
        private static readonly CircularQueue<ushort> TetrisOGroup;
        private static readonly CircularQueue<ushort> TetrisSGroup;
        private static readonly CircularQueue<ushort> TetrisTGroup;
        private static readonly CircularQueue<ushort> TetrisZGroup;
        private static readonly Tetris TetrisI;
        private static readonly Tetris TetrisL;
        private static readonly Tetris TetrisJ;
        private static readonly Tetris TetrisO;
        private static readonly Tetris TetrisS;
        private static readonly Tetris TetrisT;
        private static readonly Tetris TetrisZ;
        private static readonly List<Tetris> Tetris;
        private static readonly Random Rand = new Random();

        public event EventHandler GameOver;

        private bool m_started = false;
        private int m_row = TETRIS_START_ROW;
        private int m_col = TETRIS_START_COLUMN;
        private int _score = 0;
        private int _lines = 0;
        private int _level = TETRIS_MIN_LEVEL;
        private Tetris m_tetris;
        private Tetris m_nextTetris;
        private TetrisBlock[,] m_blocks;
        private TetrisBlock[,] m_nextBlocks;

        private double currentTime;
        private ICommand startCommand;

        static TetrisController()
        {
            /* 
                0100 0000
                0100 1111
                0100 0000
                0100 0000
            */
            TetrisIGroup = new CircularQueue<ushort>(new ushort[] { 17476, 3840 });
            /*
                0010 0100 0011 0000
                0010 0111 0010 0111
                0110 0000 0010 0001
                0000 0000 0000 0000
            */
            TetrisJGroup = new CircularQueue<ushort>(new ushort[] { 8800, 18176, 12832, 1808 });
            /*
                0100 0000 1100 0010
                0100 1110 0100 1110
                0110 1000 0100 0000
                0000 0000 0000 0000
            */
            TetrisLGroup = new CircularQueue<ushort>(new ushort[] { 17504, 3712, 50240, 11776 });
            /*
                0000
                0110
                0110
                0000
            */
            TetrisOGroup = new CircularQueue<ushort>(new ushort[] { 1632 });
            /*
                0100 0011
                0110 0110
                0010 0000
                0000 0000
            */
            TetrisSGroup = new CircularQueue<ushort>(new ushort[] { 17952, 13824 });
            /*
                0010 0010 0000 0010
                0111 0011 0111 0110
                0000 0010 0010 0010
                0000 0000 0000 0000
            */
            TetrisTGroup = new CircularQueue<ushort>(new ushort[] { 9984, 8992, 1824, 9760 });
            /*
                0010 0110
                0110 0011
                0100 0000
                0000 0000
             */
            TetrisZGroup = new CircularQueue<ushort>(new ushort[] { 9792, 25344 });
            TetrisI = new Tetris(TetrisIGroup, Brushes.Red);
            TetrisJ = new Tetris(TetrisJGroup, Brushes.Cyan);
            TetrisL = new Tetris(TetrisLGroup, Brushes.Yellow);
            TetrisO = new Tetris(TetrisOGroup, Brushes.Blue);
            TetrisS = new Tetris(TetrisSGroup, Brushes.Green);
            TetrisT = new Tetris(TetrisTGroup, Brushes.Orange);
            TetrisZ = new Tetris(TetrisZGroup, Brushes.Purple);
            Tetris = new List<Tetris>(new Tetris[] { TetrisI, TetrisJ, TetrisL, TetrisO, TetrisS, TetrisT, TetrisZ });
        }

        private double Milliseconds
        {
            get
            {
                return (TETRIS_INITIALIZE_MILLISECONDS - (Level - 1) * TETRIS_INCREMENT_MILLISECONDS);
            }
        }

        private bool IsRunning
        {
            get { return m_started; }
        }

        /// <summary>
        /// Gets or sets the start command.
        /// </summary>
        /// <value>
        /// The start command.
        /// </value>
        public ICommand StartCommand
        {
            get { return startCommand; }
            set { SetProperty(ref startCommand, value); }
        }

        /// <summary>
        /// Gets the score.
        /// </summary>
        /// <value>
        /// The score.
        /// </value>
        public int Score
        {
            get { return _score; }
            private set { SetProperty(ref _score, value); }
        }

        /// <summary>
        /// Gets the lines.
        /// </summary>
        /// <value>
        /// The lines.
        /// </value>
        public int Lines
        {
            get { return _lines; }
            private set { SetProperty(ref _lines, value); }
        }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public int Level
        {
            get { return _level; }
            set
            {
                int oldLevel = _level;
                int newValue = (value > TETRIS_MAX_LEVEL ? TETRIS_MAX_LEVEL : (value < TETRIS_MIN_LEVEL ? TETRIS_MIN_LEVEL : value));
                SetProperty(ref _level, newValue);
            }
        }        

        /// <summary>
        /// Initializes a new instance of the <see cref="TetrisController"/> class.
        /// </summary>
        /// <param name="tetrisPanel">The tetris panel.</param>
        /// <param name="nextTetrisPanel">The next tetris panel.</param>
        public TetrisController(Panel tetrisPanel, Panel nextTetrisPanel)
        {
            StartCommand = new RelayCommand(new Action<object>(OnStart));

            Initialize(tetrisPanel, nextTetrisPanel);
            CreateNextTetris();
            RenderCurrentTetris(0, 0);
        }

        private void OnStart(object obj)
        {
            Start();
        }

        /// <summary>
        /// Moves down.
        /// </summary>
        public void MoveDown()
        {
            if (IsRunning)
            {
                Tetris tetris = m_tetris;
                ushort matrix = tetris.GetMatrix();
                if (HitTest(matrix, 1, 0))
                {
                    RenderCurrentTetris(0, 0, Brushes.Teal);
                    TryClearLines();

                    if (DetectGameOver())
                    {
                        OnGameOver();
                    }
                    else
                    {
                        CreateNextTetris();
                    }
                }
                else
                {
                    RenderCurrentTetris(1, 0);
                }
            }
        }

        /// <summary>
        /// Moves left.
        /// </summary>
        public void MoveLeft()
        {
            if (IsRunning)
            {
                Tetris tetris = m_tetris;
                ushort matrix = tetris.GetMatrix();
                if (HitTest(matrix, 0, -1))
                {
                    RenderCurrentTetris(0, 0);
                }
                else
                {
                    RenderCurrentTetris(0, -1);
                }
            }
        }

        /// <summary>
        /// Moves right.
        /// </summary>
        public void MoveRight()
        {
            if (IsRunning)
            {
                Tetris tetris = m_tetris;
                ushort matrix = tetris.GetMatrix();
                if (HitTest(matrix, 0, 1))
                {
                    RenderCurrentTetris(0, 0);
                }
                else
                {
                    RenderCurrentTetris(0, 1);
                }
            }
        }

        /// <summary>
        /// Rotates
        /// </summary>
        public void Rotate()
        {
            if (IsRunning)
            {
                Tetris tetris = m_tetris;
                ushort matrix = tetris.GetMatrix();
                if (!HitTest(matrix, 0, 0))
                {
                    tetris.MatrixTransform();
                }

                RenderCurrentTetris(0, 0);
            }
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            if (!m_started)
            {
                currentTime = 0;
                m_started = true;
            }
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
        {
            if (m_started)
            {
                m_started = false;
            }
        }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void Reset()
        {
            ClearBlocks(m_blocks, TETRIS_MAX_ROWS, TETRIS_MAX_COLUMNS);
            ClearBlocks(m_nextBlocks, TETRIS_MAX_M, TETRIS_MAX_N);
            m_started = false;
            m_row = TETRIS_START_ROW;
            m_col = TETRIS_START_COLUMN;
            Score = 0; Level = 1; Lines = 0;
            currentTime = 0;
        }

        private TetrisBlock CreateBlock()
        {
            TetrisBlock block = new TetrisBlock();
            block.Width = TETRIS_BLOCK_WIDTH;
            block.Height = TETRIS_BLOCK_HEIGHT;
            return block;
        }

        private void CreateNextTetris()
        {
            TetrisBlock[,] blocks = m_blocks;
            m_tetris = (m_nextTetris != null ? m_nextTetris : Tetris[Rand.Next(0, 6)]);
            m_nextTetris = Tetris[Rand.Next(0, 6)];
            m_row = TETRIS_START_ROW;
            m_col = TETRIS_START_COLUMN;
            DrawNextTetris();
        }

        private void ClearBlocks(TetrisBlock[,] blocks, int m, int n)
        {
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    blocks[i, j].Fill = null;
                }
            }
        }

        private bool HitTest(ushort matrix, int offsetX, int offsetY)
        {
            HideCurrentTetris();
            TetrisBlock[,] blocks = m_blocks;
            int b = TETRIS_MAX_M * TETRIS_MAX_N - 1;
            for (int i = 0; i < TETRIS_MAX_M; ++i)
            {
                for (int j = 0; j < TETRIS_MAX_N; ++j)
                {
                    int offset = b - (i * TETRIS_MAX_N + j);
                    if (((matrix >> offset) & 1) == 1)
                    {
                        int row = i + m_row + offsetX;
                        int col = j + m_col + offsetY;
                        if (row < 0)
                        {
                            continue;
                        }

                        if (row >= TETRIS_MAX_ROWS || col < 0 || col >= TETRIS_MAX_COLUMNS || blocks[row, col].Fill != null)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void Initialize(Panel tetrisPanel, Panel nextTetrisPanel)
        {            
            TetrisBlock[,] blocks = new TetrisBlock[TETRIS_MAX_ROWS, TETRIS_MAX_COLUMNS];
            for (int i = 0; i < TETRIS_MAX_ROWS; ++i)
            {
                for (int j = 0; j < TETRIS_MAX_COLUMNS; ++j)
                {
                    TetrisBlock block = blocks[i, j] = CreateBlock();
                    block.Top = i * TETRIS_BLOCK_HEIGHT;
                    block.Left = j * TETRIS_BLOCK_WIDTH;
                    tetrisPanel.Children.Add(block);

                    block.Fill = null;
                }
            }

            TetrisBlock[,] nextBlocks = new TetrisBlock[TETRIS_MAX_M, TETRIS_MAX_N];
            for (int i = 0; i < TETRIS_MAX_M; ++i)
            {
                for (int j = 0; j < TETRIS_MAX_N; ++j)
                {
                    TetrisBlock nextBlock = nextBlocks[i, j] = CreateBlock();
                    nextBlock.Top = i * TETRIS_BLOCK_HEIGHT;
                    nextBlock.Left = j * TETRIS_BLOCK_WIDTH;
                    nextTetrisPanel.Children.Add(nextBlock);                    
                }
            }

            m_blocks = blocks;
            m_nextBlocks = nextBlocks;
        }

        private void OnGameOver()
        {
            Stop();
            EventHandler handler = GameOver;
            if (handler != null)
            {
                GameOver(this, EventArgs.Empty);
            }
        }

        private void DrawNextTetris()
        {
            TetrisBlock[,] nextBlocks = m_nextBlocks;
            Tetris nextTetris = m_nextTetris;
            ReDrawTetris(nextBlocks, nextTetris.GetMatrix(), TETRIS_MAX_M, TETRIS_MAX_N, 0, 0, nextTetris.Fill);
        }

        private void ReDrawTetris(TetrisBlock[,] blocks, ushort matrix, int m, int n, int offsetX, int offsetY, Brush fill)
        {
            int b = TETRIS_MAX_M * TETRIS_MAX_N - 1;
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    int offset = b - (i * TETRIS_MAX_N + j);
                    int row = i + offsetX;
                    int col = j + offsetY;
                    if (row < 0 || row >= TETRIS_MAX_ROWS || col < 0 || col >= TETRIS_MAX_COLUMNS)
                    {
                        continue;
                    }

                    blocks[row, col].Fill = (((matrix >> offset) & 1) == 1) ? fill : null;
                }
            }
        }

        private void RenderCurrentTetris(int offsetX, int offsetY)
        {
            RenderCurrentTetris(offsetX, offsetY, null);
        }

        private void RenderCurrentTetris(int offsetX, int offsetY, Brush fill)
        {
            HideCurrentTetris();
            m_row += offsetX;
            m_col += offsetY;
            TetrisBlock[,] blocks = m_blocks;
            Tetris tetris = m_tetris;
            int b = TETRIS_MAX_M * TETRIS_MAX_N - 1;
            ushort matrix = tetris.GetMatrix();
            for (int i = 0; i < TETRIS_MAX_M; ++i)
            {
                for (int j = 0; j < TETRIS_MAX_N; ++j)
                {
                    int row = i + m_row;
                    int col = j + m_col;
                    if (row < 0 || col < 0 || row >= TETRIS_MAX_ROWS || col >= TETRIS_MAX_COLUMNS)
                    {
                        continue;
                    }

                    int offset = b - (i * TETRIS_MAX_N + j);
                    if (((matrix >> offset) & 1) == 1)
                    {
                        blocks[row, col].Fill = (fill != null ? fill : tetris.Fill);
                    }
                }
            }
        }

        private void HideCurrentTetris()
        {
            TetrisBlock[,] blocks = m_blocks;
            Tetris tetris = m_tetris;
            ushort matrix = tetris.GetMatrix();
            int b = TETRIS_MAX_M * TETRIS_MAX_N - 1;
            for (int i = 0; i < TETRIS_MAX_M; ++i)
            {
                for (int j = 0; j < TETRIS_MAX_N; ++j)
                {
                    int offset = b - (i * TETRIS_MAX_N + j);
                    int row = i + m_row;
                    int col = j + m_col;
                    if (row < 0 || row >= TETRIS_MAX_ROWS || col < 0 || col >= TETRIS_MAX_COLUMNS)
                    {
                        continue;
                    }

                    if (((matrix >> offset) & 1) == 1)
                    {
                        blocks[row, col].Fill = null;
                    }
                }
            }
        }

        private void TryClearLines()
        {
            int lines = 0;
            TetrisBlock[,] blocks = m_blocks;
            for (int i = 0; i < TETRIS_MAX_ROWS; ++i)
            {
                bool flag = true;
                for (int j = 0; j < TETRIS_MAX_COLUMNS; ++j)
                {
                    if (blocks[i, j].Fill == null)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    ++lines;
                    for (int j = 0; j < TETRIS_MAX_COLUMNS; ++j)
                    {
                        blocks[i, j].Fill = null;
                    }

                    for (int k = i; k > 0; --k)
                    {
                        for (int j = 0; j < TETRIS_MAX_COLUMNS; ++j)
                        {
                            blocks[k, j].Fill = blocks[k - 1, j].Fill;
                        }
                    }                    
                }
            }

            if (lines > 0)
            {
                Lines += lines;
                Score += TETRIS_LINE_SCORE * (int)Math.Pow(2, lines - 1);
                Level = (Score / 1000) + 1;
            }
        }

        private bool DetectGameOver()
        {
            TetrisBlock[,] blocks = m_blocks;
            for (int i = 0; i < TETRIS_MAX_COLUMNS; ++i)
            {
                if (blocks[0, i].Fill != null)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Update logic
        /// </summary>
        /// <param name="elapsedTime">The elapsed time.</param>
        public void Update(double elapsedTime)
        {
            if (!m_started)
            {
                return;
            }

            currentTime += elapsedTime;

            if (currentTime > Milliseconds)
            {
                currentTime = 0;
                MoveDown();
            }
        }
    }
}

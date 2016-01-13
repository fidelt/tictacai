using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacAI
{
    public partial class PlayBoard : Form
    {
        private Bot bot;

        private int boardSize = 3;
        private bool isPlayerTwoAI;
        private bool isPlayerOneTurn;

        public int[,] board;
        public bool isPlayerOneX;

        public PlayBoard()
        {
            InitializeComponent();
            this.Hide();
        }

        private void SetBoard()
        {
            // Resets the UI and array board
            board = new int[boardSize, boardSize];
            foreach (Button btn in this.Controls.OfType<Button>())
            { 
                btn.Text = String.Empty;
                btn.Enabled = true;
            }

            // Determine first turn
            isPlayerOneTurn = isPlayerOneX = (new Random().Next(10) >= 5);
            if (isPlayerTwoAI)
            {
                bot = new Bot(this);
            }
            SetTurn();
        }

        private void SetTurn()
        {
            StatusStripLabel.Text = (isPlayerOneTurn) ? "Player One's turn" : "Player Two's turn";
            if (!isPlayerOneTurn && isPlayerTwoAI)
            {
                bot.Move();
            }
        }

        private bool CheckEndCondition()
        {
			int x, y;
			int fslashTotal = 0;
			int bslashTotal = 0;
            bool isThereBlanks = false;
			int[] rowTotal = new int[boardSize];
            int[] colTotal = new int[boardSize];

            // Sums board values
            for (y = 0; y < boardSize; y++)
            {
                for (x = 0; x < boardSize; x++)
                {
                    rowTotal[y] += board[y, x];
                    colTotal[x] += board[y, x];
                    bslashTotal += (y == x) ? board[y, x] : 0;

                    if (board[y, x] == 0 && !isThereBlanks)
                    {
                        isThereBlanks = true;
                    }
                }

                fslashTotal += board[y, ((boardSize - 1) - y)];
            }

            // Check for winning condition
            if ((colTotal.Contains(boardSize) || colTotal.Contains(-boardSize)) ||
                (rowTotal.Contains(boardSize) || rowTotal.Contains(-boardSize)) ||
                (fslashTotal == boardSize || fslashTotal == -boardSize) ||
                (bslashTotal == boardSize || bslashTotal == -boardSize))
            {
                foreach (Button btn in this.Controls.OfType<Button>())
                {
                    btn.Enabled = false;
                }
                StatusStripLabel.Text = (isPlayerOneTurn) ? "Player One wins" : "Player Two wins";
                return true;
            }

            if (!isThereBlanks)
            {
                StatusStripLabel.Text = "Tie";
                return true;
            }

            return false;
        }

        public void MarkButton(string position)
        {
            Button btn = this.Controls.Find("button" + position, true).FirstOrDefault() as Button;
            btn.PerformClick();
        }

        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ UI INTERACTIONS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        private void VersusMenuItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            isPlayerTwoAI = (menuItem.Text.Equals(versusHumanMenuItem.Text)) ? false : true;
            SetBoard();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.StartPosition = FormStartPosition.CenterParent;
            about.ShowDialog();
        }

        private void PlayBoardButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = (isPlayerOneTurn == isPlayerOneX) ? "X" : "O";
            btn.Enabled = false;

            int xPosition = (int)Char.GetNumericValue(btn.Name[btn.Name.Length - 1]);
            int yPosition = (int)Char.GetNumericValue(btn.Name[btn.Name.Length - 2]);
            board[yPosition, xPosition] = (isPlayerOneTurn == isPlayerOneX) ? 1 : -1;

            if (!CheckEndCondition())
            {
                isPlayerOneTurn = !isPlayerOneTurn;
                SetTurn();
            }
        }
    }
}
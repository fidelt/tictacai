using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TicTacAI
{
    public partial class PlayBoard : Form
    {
        private Bot bot;
        private bool p1_turn;
        private bool p1_is_x;
        private bool p2_isAI;
        private int boardsize = 3;

        public int[,] board;

        public PlayBoard()
        {
            InitializeComponent();
        }

        private void SetBoard()
        {
            // Resets the UI and array board
            board = new int[boardsize, boardsize];
            foreach (Button btn in this.Controls.OfType<Button>())
            { 
                btn.Text = String.Empty;
                btn.Enabled = true;
            }

            // Determine first turn
            p1_turn = p1_is_x = (new Random().Next(10) >= 5);
            if (p2_isAI)
            {
                bot = new Bot(this);
            }
            ChangeTurn();
        }

        private void ChangeTurn()
        {
            StatusStripLabel.Text = (p1_turn) ? "Player One's turn" : "Player Two's turn";
            if (!p1_turn && p2_isAI)
            {
                bot.RandomPick();
            }
        }

        private void DisplayWin()
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Enabled = false;
            }
            StatusStripLabel.Text = (p1_turn) ? "Player One wins" : "Player Two wins";
        }

        private bool CheckEnd()
        {
			int x, y;
			int fslash_total = 0;
			int bslash_total = 0;
			int[] row_total = new int[boardsize];
            int[] col_total = new int[boardsize];
            List<string> blanks = new List<string>();

            // Sums board values
            for (y = 0; y < boardsize; y++)
            {
                for (x = 0; x < boardsize; x++)
                {
                    row_total[y] += board[y, x];
                    col_total[x] += board[y, x];
                    bslash_total += (y == x) ? board[y, x] : 0;

                    if (board[y, x] == 0)
                    {
                        blanks.Add(string.Format("{0}{1}", y, x));
                    }
                }

                fslash_total += board[y, ((boardsize - 1) - y)];
            }

            // Check for winning condition
            if ((col_total.Contains(boardsize) || col_total.Contains(-boardsize)) ||
                (row_total.Contains(boardsize) || row_total.Contains(-boardsize)) ||
                (fslash_total == boardsize || fslash_total == -boardsize) ||
                (bslash_total == boardsize || bslash_total == -boardsize))
            {
                DisplayWin();
                return true;
            }

            if (blanks.Count == 0)
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
        private void VersusHuman_MenuItem_Click(object sender, EventArgs e)
        {
            p2_isAI = false;
            SetBoard();
        }

        private void VersusComputer_MenuItem_Click(object sender, EventArgs e)
        {
            p2_isAI = true;
            SetBoard();
        }

        private void PlayBoard_Tile_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = (p1_turn == p1_is_x) ? "X" : "O";
            btn.Enabled = false;

            int xpos = (int)Char.GetNumericValue(btn.Name[btn.Name.Length - 1]);
            int ypos = (int)Char.GetNumericValue(btn.Name[btn.Name.Length - 2]);
            board[ypos, xpos] = (p1_turn == p1_is_x) ? 1 : -1;

            if (!CheckEnd())
            {
                p1_turn = !p1_turn;
                ChangeTurn();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacAI
{
    public partial class PlayBoard : Form
    {
        private Bot bot;

        private bool p1_turn;
        private bool p1_is_x;
        private bool p2_isAI;

        public PlayBoard()
        {
            InitializeComponent();
        }

        private void SetBoard()
        {
            // Clears the board
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Text = String.Empty;
                btn.Enabled = true;
            }

            // Determine first turn
            p1_turn = p1_is_x = (new Random().Next(10) >= 5);
            StatusStripLabel.Text = (p1_turn) ? "Player One's turn" : "Player Two's turn";
        }

        private void CheckConditions()
        {
            
        }

        public void Mark_Button(int index)
        {
            Button btn = this.Controls.Find("button" + index.ToString(), true).FirstOrDefault() as Button;
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

        public void PlayBoard_Tile_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = (p1_turn == p1_is_x) ? "X" : "O";
            btn.Enabled = false;

            CheckConditions();
            p1_turn = !p1_turn;
            StatusStripLabel.Text = (p1_turn) ? "Player One's turn" : "Player Two's turn";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacAI
{
    class Bot
    {
        private PlayBoard playBoard;
        private bool isAIEasy = true;

        public Bot(PlayBoard pb)
        {
            playBoard = pb;
        }

        private string RandomPick()
        {
            int x, y;
            List<string> blanks = new List<string>();
            for (y = 0; y < playBoard.board.GetLength(0); y++)
            {
                for (x = 0; x < playBoard.board.GetLength(0); x++)
                {
                    if (playBoard.board[y, x] == 0)
                    {
                        blanks.Add(string.Format("{0}{1}", y, x));
                    }
                }
            }
            return blanks[new Random().Next(blanks.Count)];
        }

        private string MinMax()
        {
            return "";
        }

        public void Move()
        {
            string position = (isAIEasy) ? RandomPick() : MinMax();
            playBoard.MarkButton(position);
        }
    }
}
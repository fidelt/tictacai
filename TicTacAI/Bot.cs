using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacAI
{
    class Bot
    {
        private PlayBoard PlayBoard;

        public Bot(PlayBoard pb)
        {
            PlayBoard = pb;
        }

        public void RandomPick()
        {
            int x, y;
            List<string> blanks = new List<string>();
            for (y = 0; y < PlayBoard.board.GetLength(0); y++)
            {
                for (x = 0; x < PlayBoard.board.GetLength(0); x++)
                {
                    if (PlayBoard.board[y, x] == 0)
                    {
                        blanks.Add(string.Format("{0}{1}", y, x));
                    }
                }
            }
            PlayBoard.MarkButton(blanks[new Random().Next(blanks.Count)]);
        }
    }
}
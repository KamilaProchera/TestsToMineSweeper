using System;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperLibrary.FillInBoard
{
    public class FillInBoardWithM : IFillInBoardWithM
    {
        //Write in M(mine)

        public void WriteInM(int mines, int grid, char[,] board)
        {
            for (int i = 0; i < mines; i++)
            {
                int x = new Random().Next(grid);
                int y = new Random().Next(grid);
                if (board[x, y] == 'M')
                {
                    i--;
                    continue;
                }
                board[x, y] = 'M';
            }

        }
    }
}

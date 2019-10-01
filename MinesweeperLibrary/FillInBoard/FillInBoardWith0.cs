using System;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperLibrary.FillInBoard
{
    public class FillInBoardWith0 : IFillInBoardWith0
    {

        //Print Board with 0 only

        public void FillInBoardWith0Only(int grid, char[,] board)
        {
            for (int i = 0; i < grid; i++)
            {

                for (int j = 0; j < grid; j++)
                {
                    board[i, j] = '0';
                }

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperLibrary.FillInBoard
{
    public class FillInAWholeBoard : IFillInAWholeBoard
    {

        public void FillInABoard(int grid, char[,] board)
        {
            for (int i = 0; i < grid; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < grid; j++)
                {
                    Console.Write(board[i, j]);
                }
            }
        }
    }
}

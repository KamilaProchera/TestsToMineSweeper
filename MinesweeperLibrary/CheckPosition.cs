using System;

namespace MinesweeperLibrary
{
    public class CheckPosition : ICheckPosition
    {
        public char CheckPositionOnBoard(int x, int y, char[,] board)
        {
            return board[x, y];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperLibrary
{
    public class Dig : IDig
    {
        public bool DigShovel(int x, int y, char[,] board, int grid)
        {
            if (board[x, y] == 'M')
            {
                return false;
            }
            var dig = board[x, y];

            board[x, y] = 'W'; //wbite

            if (dig == '0')
            {
                for (int x2 = x - 1; x2 < x + 2; x++)
                {
                    for (int y2 = y - 1; y2 < y + 2; y++)
                    {
                        if (x2 >= grid || y2 >= grid)
                        {
                            continue;
                        }

                        if (x2 < 0 || y2 < 0)
                        {
                            continue;
                        }
                        if (board[x2, y2] == 'M')
                        {
                            continue;
                        }
                        DigShovel(x2, y2, board, grid);
                    }
                }
            }
            return true;
        }
    }
}

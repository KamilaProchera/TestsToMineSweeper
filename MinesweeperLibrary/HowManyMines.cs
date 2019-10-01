using System;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperLibrary
{
    public class HowManyMines : IHowManyMines
    {
        //Fill in how many mines is next to the field

        public void HowManyMinesNextToTheField(int grid, char[,] board)
        {
            for (int Xm = 0; Xm < grid; Xm++)
            {
                for (int Ym = 0; Ym < grid; Ym++)
                {
                    if (board[Xm, Ym] == 'M')
                    {
                        for (int x = Xm - 1; x < Xm + 2; x++)
                        {
                            for (int y = Ym - 1; y < Ym + 2; y++)
                            {
                                if (x >= grid || y >= grid)
                                {
                                    continue;
                                }
                                if (x < 0 || y < 0)
                                {
                                    continue;
                                }
                                if (board[x, y] == 'M')
                                {
                                    continue;
                                }
                                int board_position = (int)board[x, y] + 1;
                                board[x, y] = (char)board_position;

                            }
                        }
                    }

                }

            }

        }

    }
}

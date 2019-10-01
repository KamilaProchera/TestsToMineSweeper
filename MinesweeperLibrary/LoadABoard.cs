using MinesweeperLibrary.FillInBoard;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperLibrary
{
    public class LoadABoard : ILoadABoard
    {
        public char[,] board;
        int grid;

        private readonly IFillInBoardWith0 _fillInBoardWith0;
        private readonly IFillInBoardWithM _fillInBoardWithM;
        private readonly IFillInAWholeBoard _fillInAWholeBoard;
        private readonly IHowManyMines _howManyMines;
        public LoadABoard(IFillInBoardWith0 fillInBoardWith0, IFillInBoardWithM fillInBoardWithM, IFillInAWholeBoard fillInAWholeBoard, IHowManyMines howManyMines)
        {
            _fillInBoardWith0 = fillInBoardWith0;
            _fillInBoardWithM = fillInBoardWithM;
            _fillInAWholeBoard = fillInAWholeBoard;
            _howManyMines = howManyMines;

        }

        public void LoadBoard()
        {
            int board_size = Convert.ToInt32(Console.ReadLine());
            int mines = Convert.ToInt32(Console.ReadLine());
            double gridsize_height_width = Math.Sqrt(board_size);

            grid = Convert.ToInt32(gridsize_height_width);
            board = new char[grid, grid];

            //Print table with 0 only

            _fillInBoardWith0.FillInBoardWith0Only(grid, board);

            //Write in M(mine)

            _fillInBoardWithM.WriteInM(mines, grid, board);

            //Fill in fields next to Mines

            _howManyMines.HowManyMinesNextToTheField(grid, board);

            // Print a whole filled board

            _fillInAWholeBoard.FillInABoard(grid, board);
        }
    }
}

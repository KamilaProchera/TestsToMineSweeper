namespace MinesweeperLibrary
{
    public interface IHowManyMines
    {
        void HowManyMinesNextToTheField(int grid, char[,] board);
    }
}
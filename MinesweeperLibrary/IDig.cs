namespace MinesweeperLibrary
{
    public interface IDig
    {
        bool DigShovel(int x, int y, char[,] board, int grid);
    }
}
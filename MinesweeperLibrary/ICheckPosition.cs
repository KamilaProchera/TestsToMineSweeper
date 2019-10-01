namespace MinesweeperLibrary
{
    public interface ICheckPosition
    {
        char CheckPositionOnBoard(int x, int y, char[,] board);
    }
}
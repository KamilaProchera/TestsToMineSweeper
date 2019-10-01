using MinesweeperLibrary;

namespace Minesweeper
{
    public class Application : IApplication
    {
        ILoadABoard _loadGame;

        public Application(ILoadABoard loadGame)
        {
            _loadGame = loadGame;
        }

        public void Run()
        {
            _loadGame.LoadBoard();
        }
    }
}

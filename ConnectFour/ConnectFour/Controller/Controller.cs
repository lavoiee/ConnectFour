using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Controller
    {
        private ConsoleView _gameConsole;
        private GameBoard _gameBoard;
        private bool _playingGame;

        public Controller()
        {
            InitializeGame();
            ManageGameLoop();
        }

        private void InitializeGame()
        {
            _gameBoard = new GameBoard();
            _gameConsole = new ConsoleView();
            _playingGame = true;
        }
        private void ManageGameLoop()
        {
            
        }
    }
}

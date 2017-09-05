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

        public Controller()
        {
            InitializeGame();
            ManageGameLoop();
        }

        private void InitializeGame()
        {
            _gameConsole = new ConsoleView();
            _gameBoard = new GameBoard();
        }
        private void ManageGameLoop()
        {
            throw new NotImplementedException();
        }
    }
}

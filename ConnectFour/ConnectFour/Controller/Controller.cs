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
        private Player _playerOne;
        private Player _playerTwo;
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
            _playerOne = new Player();
            _playerTwo = new Player();
            _playingGame = true;
        }
        private void ManageGameLoop()
        {
            while (_playingGame)
            {

            }   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Controller
    {
        #region FIELDS

        private ConsoleView _gameConsole;
        private GameBoard _gameBoard;
        private Player _playerOne;
        private Player _playerTwo;
        private bool _playingGame;

        #endregion

        #region CONSTRUCTORS

        public Controller()
        {
            InitializeGame();
            ManageGameLoop();
        }

        #endregion

        #region METHODS

        private void InitializeGame()
        {
            _gameBoard = new GameBoard();         
            _playerOne = new Player();
            _playerTwo = new Player();
            _gameConsole = new ConsoleView(_playerOne, _playerTwo);
            _playingGame = true;
        }

        private void ManageGameLoop()
        {
            while (_playingGame)
            {

            }   
        }

        #endregion 
    }
}

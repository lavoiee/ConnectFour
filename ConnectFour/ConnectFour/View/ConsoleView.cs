using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class ConsoleView
    {

        #region ENUMS

        private enum ViewStatus
        {
            PlayerInitialization,
            PlayingGame
        }

        #endregion

        #region FIELDS

        Player _playerOne;
        Player _playerTwo;
        GameBoard _gameBoard;

        #endregion

        #region PROPERTIES
        
        #endregion


        #region CONSTRUCTORS

        public ConsoleView(Player playerOne, Player playerTwo, GameBoard gameBoard)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
            _gameBoard = gameBoard;

            InitializeDisplay();
        }

        #endregion

        #region METHODS

        public void GetContinueKey()
        {
            Console.ReadKey();
        }

        private void InitializeDisplay()
        {

        }

        #endregion
    }
}

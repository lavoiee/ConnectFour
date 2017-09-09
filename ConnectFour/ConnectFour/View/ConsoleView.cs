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

        private enum ViewState
        {
            PlayerInitialization,
            PlayingGame
        }

        #endregion

        #region FIELDS
        //
        // Temporary objects to pass object references.
        //
        Player _playerOne;
        Player _playerTwo;
        GameBoard _gameBoard;
        private ViewState _currentViewState;

        private ViewState CurrentViewState
        {
            get { return _currentViewState; }
            set { _currentViewState = value; }
        }


        #endregion

        #region PROPERTIES

        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Constructor for ConsoleView.
        /// </summary>
        /// <param name="playerOne"></param>
        /// <param name="playerTwo"></param>
        /// <param name="gameBoard"></param>
        public ConsoleView(Player playerOne, Player playerTwo, GameBoard gameBoard)
        {
            _currentViewState = ViewState.PlayerInitialization;

            _playerOne = playerOne;
            _playerTwo = playerTwo;
            _gameBoard = gameBoard;

            InitializeDisplay();
        }

        #endregion

        #region METHODS
        /// <summary>
        /// Method to stay the screen until user enters a key.
        /// </summary>
        public void GetContinueKey()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Method to set up the console.
        /// </summary>
        private void InitializeDisplay()
        {
        }

        #endregion
    }
}

﻿using System;
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
        /// <summary>
        /// Constructor for the controller.
        /// </summary>
        public Controller()
        {
            InitializeGame();
            ManageGameLoop();
        }

        #endregion

        #region METHODS
        /// <summary>
        /// Method to initialize the game and set up objects.
        /// </summary>
        private void InitializeGame()
        {
            _gameBoard = new GameBoard();         
            _playerOne = new Player();
            _playerTwo = new Player();
            _gameConsole = new ConsoleView(_playerOne, _playerTwo, _gameBoard);
            _playingGame = true;
        }

        /// <summary>
        /// Method to manage the game loop.
        /// </summary>
        private void ManageGameLoop()
        {
            while (_playingGame)
            {

            }   
        }

        #endregion 
    }
}

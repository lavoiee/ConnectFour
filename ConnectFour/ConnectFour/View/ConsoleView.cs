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

        #endregion

        #region PROPERTIES
        
        #endregion


        #region CONSTRUCTORS

        public ConsoleView(Player playerOne, Player playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;

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

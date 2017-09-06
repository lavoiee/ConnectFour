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

        public ConsoleView(Player playerOne, Player playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;

            InitializeDisplay();
        }

        private void InitializeDisplay()
        {
        }
    }
}

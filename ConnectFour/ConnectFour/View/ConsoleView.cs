using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class ConsoleView
    {
        Player _playerOne;
        Player _playerTwo;

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

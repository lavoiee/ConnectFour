using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Player
    {
        #region ENUMERABLES

        #endregion

        #region FIELDS
        private string _name;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Player()
        {

        }
        public Player(string name)
        {
            _name = name;
        }
        #endregion

        #region METHODS
        #endregion
    }
}

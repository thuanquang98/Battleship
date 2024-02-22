using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Exceptions
{
    internal class IllegalMoveException: Exception
    {
        public IllegalMoveException() { }
        public IllegalMoveException(string msg): base(msg) { }

        public IllegalMoveException(string msg, Exception innerException): base(msg, innerException) { }

    }
}

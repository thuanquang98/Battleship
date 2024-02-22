using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Exceptions
{
    public class PositionException: Exception
    {
        public PositionException(string msg): base(msg) {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    internal abstract class Player
    {
        private List<Ship> ships;
        public abstract void print();

    }
}

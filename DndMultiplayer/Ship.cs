using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    internal abstract class Ship
    {
        private int Health { get; set; }
        public abstract void Print();
    }
}

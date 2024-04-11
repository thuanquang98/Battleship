using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Model
{
    public abstract class Cell
    {
        public const char InvisibleState = ' ';

        public bool Shot { get; set; } = false;

        public abstract char CellState();
    }
}

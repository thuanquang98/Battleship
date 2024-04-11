using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Model
{
    internal class WaterCell : Cell
    {
        public override char CellState()
        {
            return Shot ? 'X' : ' ';
        }
    }
}

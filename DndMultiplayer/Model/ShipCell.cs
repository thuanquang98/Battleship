using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Model
{
    internal class ShipCell : Cell
    {
        public override char CellState()
        {
            return Shot? 'O': '=';
        }
    }
}

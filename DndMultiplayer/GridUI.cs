using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    internal interface GridUI
    {
        public void UpdateGrid();
        public void PrintGrid();
        public void SetUI(Human player);
    }
}

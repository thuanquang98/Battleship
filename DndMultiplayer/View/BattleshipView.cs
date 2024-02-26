using BattleshipMultiplayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.View
{
    internal interface BattleshipView
    {
        public void DisplayGrid();
        public void DisplayError(string msg);

        public void DisplayWinner(Player player);

        public BattleshipView GetView();
    }
}

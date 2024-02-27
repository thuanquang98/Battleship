using BattleshipMultiplayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.View
{
    public interface GridView
    {
        public void DisplayGrid();
        public void DisplayError(string msg);

        public void DisplayOptions();

    }
}

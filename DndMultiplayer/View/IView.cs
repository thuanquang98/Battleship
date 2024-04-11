using BattleshipMultiplayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.View
{
    public interface IView
    {
        public void Display();

        public char GetPlayerInput();

    }
}

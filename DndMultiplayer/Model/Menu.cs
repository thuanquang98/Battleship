using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Model
{
    internal class Menu
    {
        public static string GetMenuMessage()
        {
            return "(1) Singleplayer\n" +
                   "(2) Multiplayer\n" +
                   "(h) Help\n" +
                   "(q) Quit\n";
        }

        public static string GetQuitMessage()
        {
            return "You have successfully quit the game!";
        }
    }
}

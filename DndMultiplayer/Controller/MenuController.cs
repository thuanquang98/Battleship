using BattleshipMultiplayer.Model;
using BattleshipMultiplayer.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Controller
{
    internal class MenuController : IController
    {
        private readonly MenuView _view;


        public MenuController(MenuView view)
        {
            _view = view;
        }

        public void Process(char input)
        {
            if (input == '1')
            {
                //start singleplayer
            } else if (input == '2')
            {
                //start multiplayer
            } else if (input == 'h')
            {
                //display help menu
            } else if (input == 'q')
            {
                //display quit and exit the program
            }
        }
    }
}

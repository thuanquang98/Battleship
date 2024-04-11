using BattleshipMultiplayer.Controller;
using BattleshipMultiplayer.Model;
using BattleshipMultiplayer.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Application
{
    public class BattleshipApplication
    {

        private IView _view;
        private IController _controller;
        private bool _running;

        public BattleshipApplication()
        {
            _running = true;
            MenuView menuView = new MenuView();
            _view = menuView;
            _controller = new MenuController(menuView);           
        }

        public void Start()
        {
            //TODO: this function should be rewritten to include mvc for menu
            _view.Display();
            while (_running)
            {
                //view get player input
                char input = _view.GetPlayerInput();
                //controller process input
                _controller.Process(input);
                //view display
                _view.Display();
            }
        }

        
    }
}

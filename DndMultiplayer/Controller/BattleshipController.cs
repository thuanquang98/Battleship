using System;
using System.Linq;
using System.Text;
using BattleshipMultiplayer.API;
using BattleshipMultiplayer.API.Events;
using BattleshipMultiplayer.Model;
using BattleshipMultiplayer.View;

namespace BattleshipMultiplayer.Controller
{
    internal class BattleshipController: GameListener
    {
        private Human player;
        private GridView gridView;

        public BattleshipController(Human player, GridView view)
        {
            this.player = player;
            this.gridView = view;
        }

        public BattleshipController()
        {
            player = new HumanPlayer(-1, "Thuan");
        }

        //start the game by establishing link with the models and view
        public void Start()
        {

        }

        public void Notify(Event ev)
        {
            throw new NotImplementedException();
        }

        public void SetEventHandler(EventManager evManager)
        {
            evManager.RegisterListener(this);
        }
    }
}

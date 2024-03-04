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
        private readonly BattleshipGame _game;

        public BattleshipController(BattleshipGame game)
        {
            _game = game;
        }

        public void Notify(Event ev)
        {
            throw new NotImplementedException();
        }

        public void ProcessInput()
        {
            string? input = Console.ReadLine();

            try
            {
                //split the command based on "space"
                //if the first input is "quit"
                //create a "quit" event

            }catch (Exception ex)
            {

            }
        }

        public void SetEventHandler(EventManager evManager)
        {
            evManager.RegisterListener(this);
        }
    }
}

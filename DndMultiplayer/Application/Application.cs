
using BattleshipMultiplayer.Controller;
using BattleshipMultiplayer.Model;
using BattleshipMultiplayer.View;
using System.Collections.Concurrent;

namespace BattleshipMultiplayer.Application
{
    public class BattleshipApplication: GameLogic
    {
        private BattleshipGame game;
        private BattleshipController controller;
        private BattleshipTextView textView;

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            game = new BattleshipGame();
            controller = new BattleshipController(game);

        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

}




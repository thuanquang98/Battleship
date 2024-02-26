using BattleshipMultiplayer.API;
using BattleshipMultiplayer.API.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Model
{
    internal class BattleshipGame: GameListener
    {
        private IPlayable self;
        private bool gameOver;
        private Turn turn;

        public BattleshipGame(IPlayable p1)
        {
            self = p1;
            gameOver = false;

        }

        public void Notify(Event ev)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();            
        }

    }
}

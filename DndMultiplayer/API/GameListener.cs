using BattleshipMultiplayer.API.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.API
{
    internal interface GameListener
    {
        public void Notify(Event ev);
    }
}

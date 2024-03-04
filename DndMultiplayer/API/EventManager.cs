using BattleshipMultiplayer.API.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.API
{
    public interface EventManager
    {
        public void RegisterListener(GameListener listener);
        public void BroadCast(Event ev);
    }
}

using BattleshipMultiplayer.API.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.API
{
    public interface GameEventManager
    {
        public void AddGameListener(GameListener listener);
        public void NotifyListenersWith(GameEvent ev);
    }
}

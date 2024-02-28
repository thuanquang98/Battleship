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
        public void BroadCastEvent();
        public void Notify(GameListener listener);
    }
}

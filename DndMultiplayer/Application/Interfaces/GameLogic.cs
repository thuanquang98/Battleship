using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    internal interface GameLogic
    {
        public void Init();
        public void Run();

        public void Stop();
    }
}

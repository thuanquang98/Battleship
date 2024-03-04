using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Application
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Application app = new Application();
            app.Init();
            app.Run();
            app.Stop();
        }
    }
}

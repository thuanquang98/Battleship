using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    internal class Ship
    {
        public int Health;
        public bool IsAlive { get; }
        public void Print() //for debug purpose
        {
            Console.WriteLine($"Health: {Health}, Is Alive?: {IsAlive}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    public class Ship
    {
        public ShipType type;

        public Ship() { }



        public int Health;
        public bool IsAlive { get; }



        public void ShowInfo() //for debug purpose
        {
            Console.WriteLine($"Health: {Health}, Is Alive?: {IsAlive}");
        }
    }
}

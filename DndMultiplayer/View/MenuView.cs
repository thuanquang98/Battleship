using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.View
{
    internal class MenuView: IView
    {
        private void PrintMenu()
        {
            Console.WriteLine();
        }

        public void Display(string msg)
        {
            throw new NotImplementedException();
        }

        public char GetPlayerInput()
        {
            return Console.ReadKey().KeyChar;
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}

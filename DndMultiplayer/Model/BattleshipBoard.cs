using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.Model
{
    public class BattleshipBoard : Board
    {
        private const int BOARD_HEIGHT = 10;
        private const int BOARD_WIDTH = 10;
        private const int MAX_SHIPS = 5;
        private readonly List<Ship> ships;
        public BattleshipBoard() : base(BOARD_WIDTH, BOARD_HEIGHT)
        {
            ships = new List<Ship>();
        }

        public bool PlaceShip(Ship ship)
        {
            bool placed = true;

            if (ships.Count < MAX_SHIPS)
            {
                ships.Add(ship);
            }
            else
            {
                placed = false;
            }

            return placed;
        }

        public bool RemoveShip(Ship ship)
        {
            bool removed = false;

            

            return removed;
        }

        public int RemainingShips()
        {
            return ships.Count;
        }
    }
}

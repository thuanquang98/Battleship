using BattleshipMultiplayer.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    public class Position
    {
        private readonly int row;
        private readonly int col;

        public Position(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new PositionException($"({x},{y}) can't be negative)");
            row = x;
            col = y;
        }

        public int Row { get { return row; } }
        public int Col { get { return col; } }
    }
}

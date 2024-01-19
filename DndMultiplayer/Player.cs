using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    internal abstract class Player
    {
        protected GameLogic gameState;
        private Status[,] playerBoard;

        public void SetState(GameLogic gl, Status[,] board)
        {
            gameState = gl;
            playerBoard = board;
        }
        public abstract void Print();

    }
}

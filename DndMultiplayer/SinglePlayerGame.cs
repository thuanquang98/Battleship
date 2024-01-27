using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    internal class SinglePlayerGame : GameLogic
    {
        private Player p1;
        private Player p2;

        private const int BOARD_SIZE = 10;

        private Status[,] p1Board;
        private Status[,] p2Board;

        public SinglePlayerGame() {
            p1 = new HumanPlayer();
            p2 = new BotPlayer();

            p1Board = new Status[BOARD_SIZE,BOARD_SIZE];
            p2Board = new Status[BOARD_SIZE,BOARD_SIZE];

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    p1Board[i, j] = Status.NONE;
                    p2Board[i, j] = Status.NONE;
                } 
            }

            p1.SetState(this, p1Board, new List<Ship>());
            p2.SetState(this, p2Board, new List<Ship>());
            
        }
        public void Start()
        {
            Console.WriteLine("Started Game...");
           
            int playerStart = (int)new Random().NextInt64(0,2);
            if (playerStart == 0)
            { // if 0 then human start first
                Console.WriteLine("Human Player starts first");
                p1.PlayMove();
            }
            else
            {   // if 1, then AI start first
                Console.WriteLine("AI Player starts first");            
                p2.PlayMove();
            }
            
            //after the player play move update move
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        
    }
}

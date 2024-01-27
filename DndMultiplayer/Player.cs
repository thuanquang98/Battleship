using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    internal class Player
    {
        protected List<Ship> Ships {  get; set; }
        protected GameLogic Game {  get; set; }
        protected Status[,] PlayerBoard {  get; set; }
        protected Status[,] EnemyBoard { get; set; }
      
    }
}

using BattleshipMultiplayer.API;
using BattleshipMultiplayer.API.Events;
using BattleshipMultiplayer.Application;
using BattleshipMultiplayer.Exceptions;
using BattleshipMultiplayer.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.View
{
    public class GridTextView: GridView, GameListener
    {
        private const int DEFAULT_WIDTH = 10;
        private const int DEFAULT_HEIGHT = 10;
        //player interact with
        char[,] textGrid;
        private EventManager game;
        public GridTextView(EventManager eventHandler)
        {
            this.game = eventHandler;
            game.RegisterListener(this);
        }

        //grid design
        /*
         * \| A | B | C | D | E | F | G | H | I | J |
         * 0|   |   |   |   |   |   |   |   |   |   | 
         * 1|   |   |   |   |   |   |   |   |   |   |
         * 2|   |   |   |   |   |   |   |   |   |   |
         * 3|   |   |   |   |   |   |   |   |   |   |
         * 4|   |   |   |   |   |   |   |   |   |   |
         * 5|   |   |   |   |   |   |   |   |   |   |
         * 6|   |   |   |   |   |   |   |   |   |   |
         * 7|   |   |   |   |   |   |   |   |   |   |
         * 8|   |   |   |   |   |   |   |   |   |   |
         * 9|   |   |   |   |   |   |   |   |   |   |
         */

        public void DisplayError(string msg)
        {
            Console.WriteLine(msg);
        }

        public void DisplayGrid()
        {
            string water = " ~ |";
            string[] playerTextGrid = new string[DEFAULT_HEIGHT + 1];
            string[] enemyTextGrid = new string[DEFAULT_HEIGHT + 1];

            playerTextGrid[0] = "\\|";
            enemyTextGrid[0] = "\\|";

            //display the x-coordinate
            for (int i = 0; i < DEFAULT_WIDTH; i++)
            {
                playerTextGrid[0] += " " + (char)('A' + i) + " |";
                enemyTextGrid[0] += " " + (char)('A' + i) + " |";
            }

            for (int i = 1; i <= DEFAULT_HEIGHT; i++)
            {
                playerTextGrid[i] = (i - 1).ToString() + "|";
                enemyTextGrid[i] = (i - 1).ToString() + "|";
                for (int j = 0; j < DEFAULT_WIDTH; j++)
                {
                    playerTextGrid[i] += water;
                    enemyTextGrid[i] += water;
                }
            }

            //print the player board
            for (int i = 0; i <= DEFAULT_HEIGHT; i++)
            {
                Console.WriteLine(playerTextGrid[i]);
            }
            Console.WriteLine();
            //print the opponent board
            for (int i = 0; i <= DEFAULT_HEIGHT; i++)
            {
                Console.WriteLine(enemyTextGrid[i]);
            }
        }

        private void DisplayStats()
        {
            //display player's name
            //how many ships remaining
            //accuracy
            //number of abilities used
            //

            throw new NotImplementedException();
        }

        public void DisplayOptions()
        {
            throw new NotImplementedException();
        }

        
        public void Notify(Event ev)
        {

            //to initalize view
            
            //to 
            

            throw new NotImplementedException();
        }
    }
}

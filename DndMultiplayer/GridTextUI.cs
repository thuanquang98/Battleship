using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    internal class GridTextUI : GridUI
    {
        private Status[,] playerBoard;
        private Status[,] enemyBoard;
        private const int WIDTH = 10;
        private const int HEIGHT = 10;
        private Human player;


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

        public void PrintGrid()
        {
            
            string right_margin = "\n";
            string empty_cell = "  |";
            string boat = " \u1F6E5 |";
            string[] textGrid = new string[HEIGHT + 1];

            textGrid[0] += "\\|";

            //display the x-coordinate
            for (int i = 0; i < WIDTH; i++)
            {
                textGrid[0] += " " + ('A' + i) + " |";
            }

            textGrid[0] += right_margin;

            for (int i = 0; i < HEIGHT; i++)
            {
                textGrid[i] += i.ToString() + "|";
                for (int j = 0; j < WIDTH; j++)
                {
                    string curr_row = "";
                    if (playerBoard[i,j] == Status.MISS)
                    {
                        curr_row += " ~ |";
                    }
                    else if (playerBoard[i, j] == Status.HIT)
                    {
                        curr_row += " X |";
                    }else if (playerBoard[i, j] == Status.OBJECT)
                    {
                        curr_row += boat;
                    }
                    else
                    {
                        curr_row += empty_cell;
                    }
                    textGrid[i] = curr_row;
                }

                textGrid[i] += right_margin;
                
            }

            Console.WriteLine(textGrid.ToString());
        }

        public void SetUI(Human player)
        {
            this.player = player;
            playerBoard = new Status[HEIGHT, WIDTH];
            enemyBoard = new Status[HEIGHT, WIDTH];
        }

        public void UpdateGrid(int row, int col)
        {
            
        }

        public void UpdateGrid()
        {
            throw new NotImplementedException();
        }
    }
}

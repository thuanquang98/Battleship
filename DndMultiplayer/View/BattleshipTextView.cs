using BattleshipMultiplayer.API;
using BattleshipMultiplayer.API.Events;
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
    public class BattleshipTextView: IView
    {
        private readonly List<GameListener> listeners;
        private bool myTurn;
        private Board _myBoard;

        public BattleshipTextView()
        {
            listeners = new List<GameListener>();          
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

        //TODO: fill player grid with their object
        public static void Display(Board playerBoard)
        {

            char[,] playerTextGrid = new char[playerBoard.BoardWidth,playerBoard.BoardHeight];

            //fill water
            ResetBoard(playerTextGrid);

            //TODO: fill player grid with their object


            //clear the board
            Console.Clear();
            //print the player board
            PrintPlayerBoard(playerTextGrid);
        }

        private static void ResetBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++) 
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = '~';
                }
            }
        }

        private static void PrintPlayerBoard(char[,] board)
        {
            string[] grid = new string[board.GetLength(0) + 1];
            StringBuilder xGrid = new StringBuilder();
            xGrid.Append("\\ |");
            //display the coordinate
            for (int i = 0; i < board.GetLength(1); i++)
            {
                xGrid.Append(" " + (char)('A' + i) + " |");
            }

            Console.WriteLine(xGrid);

            for (int i = 0; i < board.GetLength(0); i++)
            {
                StringBuilder line = new StringBuilder();
                line.Append((i).ToString() + " |");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    line.Append(" " + board[i, j] + " |");
                }

                Console.WriteLine(line);
            }

        }

        private static void DisplayStats(Board board)
        {
            //display player's name
            //how many ships remaining
            //accuracy
            //number of abilities used
            //

            throw new NotImplementedException();
        }

        public void PrintOptions()
        {
            Console.WriteLine("(1) - Attack\n" +
                              "(2) - Abilities\n" +
                              "(h) - Help\n" +
                              "(q) - Quit");
        }

        //TODO: just print the available powers of this player
        private void PrintAvailableAbilities()
        {

        }

        public void SetGameState(Board board, bool turn)
        {
            
        }

        public bool GameOver()
        {
            //update graphics and display it

            //ask for input from player
            char input = GetPlayerInput();

            //take input and give it to controller
        }

        public char GetPlayerInput()
        {
            return Console.ReadKey().KeyChar;
        }
    }
}

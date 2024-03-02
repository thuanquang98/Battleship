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
    public class BattleshipTextView: GridView, GameListener
    {
        //link to the game
        private readonly BattleshipGame _game;
        private bool _running;

        public BattleshipTextView(BattleshipGame game)
        {
            _game = game;
            _running = false;
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
        public void DisplayGrid()
        {
            Board playerBoard = _game.GetPlayerBoard();
            Board enemyBoard = _game.GetOpponentBoard();

            char[,] playerTextGrid = new char[playerBoard.GetBoardHeight(),playerBoard.GetBoardWidth()];
            char[,] enemyTextGrid = new char[playerBoard.GetBoardHeight(),playerBoard.GetBoardWidth()];

            //fill water
            FillWater(playerTextGrid);
            FillWater(enemyTextGrid);

            //TODO: fill player grid with their object

            //print the player board
            PrintPlayerBoard(playerTextGrid);
            //space between the board
            Console.WriteLine();
            //print the opponent board
            PrintPlayerBoard(enemyTextGrid);
        }

        private void FillWater(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++) 
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = '~';
                }
            }
        }

        private void PrintPlayerBoard(char[,] board)
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

        public void Start()
        {
            _running = true;
        }

        
        public void Notify(Event ev)
        {

            if (ev is StartEvent)
            {
                Start();
            } else if (ev is GameEvent)
            {
                if (_running)
                {
                    DisplayGrid();
                }
            } else if (ev is StopEvent)
            {
                throw new NotImplementedException();
            }
        }

        public void SetEventHandler(EventManager evManager)
        {
            evManager.RegisterListener(this);
        }
    }
}

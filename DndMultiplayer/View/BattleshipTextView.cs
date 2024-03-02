﻿using BattleshipMultiplayer.API;
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
        private const int DEFAULT_WIDTH = 10;
        private const int DEFAULT_HEIGHT = 10;
        //player interact with
        private BattleshipGame _game;
        public BattleshipTextView(BattleshipGame game)
        {
            _game = game;
            _game.RegisterListener(this);
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
            Board playerBoard = _game.GetPlayerBoard();
            Board enemyBoard = _game.GetOpponentBoard();

            char water = '~';
            char[,] playerTextGrid = new char[playerBoard.GetBoardHeight(),playerBoard.GetBoardWidth()];
            char[,] enemyTextGrid = new char[playerBoard.GetBoardHeight(),playerBoard.GetBoardWidth()];

            //fill water
            FillWater(playerTextGrid);
            FillWater(enemyTextGrid);

            //fill player grid with their object

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
            grid[0] = "\\|";
            //display the coordinate
            for (int i = 0; i < board.GetLength(1); i++)
            {
                grid[0] += " " + (char)('A' + i) + " |";
            }

            for (int i = 1; i < grid.GetLength(0); i++)
            {
                StringBuilder line = new StringBuilder();
                line.Append((i - 1).ToString() + " |");
                for (int j = 0; j < grid.GetLength(1); j++)
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

        
        public void Notify(Event ev)
        {

            if (ev is InitializeEvent)
            {

            } else if (ev is )
            

            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * This _board class represents the state of the _board and it will return
 * the player's _board and also the state of the opponent's side based on what is known
 * 
 * **/
namespace BattleshipMultiplayer.Model
{
    public class Board
    {

        private Status[,] _board;
        private readonly int width;
        private readonly int height;
        private const int DEFAULT_BOARD_LENGTH = 10;

        public Board(int width, int height)
        {
            this.height = height;
            this.width = width;
            _board = InitBoard();
        }
        //default 10x10 _board
        public Board()
        {
            this.width = DEFAULT_BOARD_LENGTH;
            this.height = DEFAULT_BOARD_LENGTH;
        }

        private Status[,] InitBoard()
        {
            throw new NotImplementedException();
        }
        
        //update the status of the cell at [row][col]
        public void SetCell(int row, int col, Status status)
        {
            _board[row, col] = status;
        }

        public int GetBoardWidth() { return this.width; }

        public int GetBoardHeight() { return this.height; }

        public Status[,] Grid { 
            get => _board; 
            set
            {
                if (value.GetLength(0) == width && value.GetLength(1) == height)
                {
                    this._board = value;
                }
            } 
        }

    }

}

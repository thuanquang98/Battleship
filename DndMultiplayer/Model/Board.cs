using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * This __board class represents the state of the __board and it will return
 * the player's __board and also the state of the opponent's side based on what is known
 * 
 * **/
namespace BattleshipMultiplayer.Model
{
    public class Board
    {

        private Cell[,] _grid;
        private readonly int _width;
        private readonly int _height;

        public Board(int width, int height)
        {
            _height = height;
            _width = width;
            InitBoard();
        }

        private void InitBoard()
        {
            _grid = new Cell[this._width, this._height];

            for (int i = 0; i < _grid.GetLength(0); i++)
            {
                for (int j = 0; j < _grid.GetLength(1); j++)
                {
                    _grid[i, j] = new WaterCell();
                }
            }
        }
        
        //update the status of the cell at [row][col]
        public void SetCellState(int row, int col, bool shot)
        {
            _grid[row, col].Shot = shot;
        }

        public void SetCell(int row, int col, Cell cell)
        {
            _grid[row, col] = cell;
        }

        //deep copy of grid
        public char[,] GetBoardState(bool visible)
        {
            char[,] copiedBoard = new char[this._width, this._height];

            if (!visible)
            {
                for (int i = 0; i < copiedBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < copiedBoard.GetLength(1); j++)
                    {
                        copiedBoard[i, j] = _grid[i, j].Shot ? _grid[i, j].CellState() : Cell.InvisibleState;
                    }
                }
            }
            else
            {

                for (int i = 0; i < copiedBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < copiedBoard.GetLength(1); j++)
                    {
                        copiedBoard[i, j] = _grid[i, j].CellState();
                    }
                }
            }


            return copiedBoard;
        }

        public int BoardWidth => _width;

        public int BoardHeight => _height;

    }

}

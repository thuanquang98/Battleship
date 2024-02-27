using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * This board class represents the state of the board and it will return
 * the player's board and also the state of the opponent's side based on what is known
 * 
 * **/
namespace BattleshipMultiplayer.Model
{
    internal class Board
    {

        private char[,] board;
        private int width;
        private int height;


        public Board(int length)
        {
            height = length;
            width = length;
            board = InitBoard();
        }
        //default 10x10 board
        public Board()
        {
            width = 10;
            height = 10;
        }

        private char[,] InitBoard()
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomBoard()
        {
            validateMove();
        }

        public void UpdateTopBoard()
        {
            validateMove();
        }

        private void validateMove()
        {

        }

    }

}

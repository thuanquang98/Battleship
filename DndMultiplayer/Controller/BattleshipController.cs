using System;
using System.Linq;
using System.Text;
using BattleshipMultiplayer.API;
using BattleshipMultiplayer.API.Events;
using BattleshipMultiplayer.Model;
using BattleshipMultiplayer.View;

namespace BattleshipMultiplayer.Controller
{
    public class BattleshipController: IController
    {
        private const int BOARD_HEIGHT = 10;
        private const int BOARD_WIDTH = 10;
        private readonly Player _playerOne;
        private readonly Player _playerTwo;
        private bool _playerOneTurn;
        private readonly Board _battleshipBoard;

        //play with bots
        public BattleshipController()
        {
            _playerOne = new HumanPlayer(1, "Thuan");
            _playerTwo = new BotPlayer("JFK");

            _battleshipBoard = new Board(BOARD_WIDTH, BOARD_HEIGHT);
            _playerOne.SetInfo
        }

        public BattleshipController(Player p1, Player p2, Board board)
        {
            _battleshipBoard = board;
            _playerOne = p1;
            _playerTwo = p2;
        }

        public void SetAnswer()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            int playerStart = new Random().Next(2);

            if (playerStart == 0)
            {
                _playerOneTurn = true;
                _playerOne.PlayMove();              
            }
            else
            {
                _playerOneTurn = false;
                _playerTwo.PlayMove();              
            }

        }
    }

}

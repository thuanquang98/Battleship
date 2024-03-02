using BattleshipMultiplayer.API;
using BattleshipMultiplayer.API.Events;
using BattleshipMultiplayer.Model;

namespace BattleshipMultiplayer.Application
{
    public class BattleshipGame : EventManager
    {
        private IPlayable _self;
        private bool _gameOver;
        private Turn _turn;
        private Board _playerBoard;
        private Board _opBoard;

        public BattleshipGame()
        {
            _gameOver = false;
        }

        public void SetBoard(int width, int height)
        {
            _playerBoard = new Board(width, height);
            _opBoard = new Board(width, height);
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void RegisterListener(GameListener listener)
        {
            throw new NotImplementedException();
        }

        public void BroadCastEvent()
        {
            throw new NotImplementedException();
        }

        public void Notify(GameListener listener)
        {
            throw new NotImplementedException();
        }

        public Board GetPlayerBoard() {  return _playerBoard; }

        public Board GetOpponentBoard() { return _opBoard; }
    }
}

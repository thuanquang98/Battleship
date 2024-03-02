using BattleshipMultiplayer.API;
using BattleshipMultiplayer.API.Events;
using BattleshipMultiplayer.Model;

namespace BattleshipMultiplayer.Application
{
    public class BattleshipGame : EventManager
    {
        private Player _player1;
        private Player _player2;
        private bool _gameOver;
        private Turn _turn;
        private Board _playerBoard;
        private Board _opBoard;

        private List<GameListener> _listeners;

        public BattleshipGame()
        {
            _gameOver = false;
            _playerBoard = new Board();
            _opBoard = new Board();
            _player1 = new HumanPlayer(-1, "Thuan");
            _player2 = new BotPlayer(-1, "AI");
            _listeners = new List<GameListener>();
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
            _listeners.Add(listener);
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

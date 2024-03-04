using BattleshipMultiplayer.API;
using BattleshipMultiplayer.API.Events;
using BattleshipMultiplayer.Controller;
using BattleshipMultiplayer.View;

namespace BattleshipMultiplayer.Model
{
    public class BattleshipGame : EventManager
    {
        private Player _player1;
        private Player _player2;
        private Turn _turn;
        private bool _running;
        private Board _playerBoard;
        private Board _opBoard;

        private readonly List<GameListener> _listeners;

        public BattleshipGame()
        {
            _running = false;          
            _player1 = new HumanPlayer(-1, "Thuan");
            _player2 = new BotPlayer(-1, "AI");
            _listeners = new List<GameListener>();
        }

        public void Init()
        {
            
            Array values = Enum.GetValues(typeof(Turn));
            _turn = (Turn)values.GetValue(new Random().Next(values.Length));
            _playerBoard = new Board();
            _opBoard = new Board();
            _running = true;
        }

        public void Init(int width, int height)
        {
            
            Array values = Enum.GetValues(typeof(Turn));
            _turn = (Turn)values.GetValue(new Random().Next(values.Length));
            _playerBoard = new Board(width, height);
            _opBoard = new Board(width, height);
            _running = true;
        }

        public void RegisterListener(GameListener listener)
        {
            _listeners.Add(listener);
        }

        public void BroadCast(Event ev)
        {
            foreach (GameListener listener in _listeners)
            {
                listener.Notify(ev);
            }
        }

        public Board GetPlayerBoard() { return _playerBoard; }

        public Board GetOpponentBoard() { return _opBoard; }

    }
}

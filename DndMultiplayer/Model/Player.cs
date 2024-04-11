using BattleshipMultiplayer.Controller;
using BattleshipMultiplayer.View;

namespace BattleshipMultiplayer.Model
{
    public class Player: IPlayable
    {
        private readonly BattleshipTextView ui;
        private string _playerName;
        private Board playerBoard;
        public Player(string name, int width, int height)
        {
            _playerName = name;
        }

        public void PlayMove()
        {
            throw new NotImplementedException();
        }

        public void SetInfo(IController game)
        {
            throw new NotImplementedException();
        }

    }
}
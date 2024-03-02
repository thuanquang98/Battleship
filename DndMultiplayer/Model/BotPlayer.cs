using BattleshipMultiplayer.Model;

namespace BattleshipMultiplayer
{
    internal class BotPlayer :  Player, IPlayable
    {
        public BotPlayer(int id, string name) : base(id, name)
        {
        }

        public void PlayMove()
        {
            throw new NotImplementedException();
        }

    }
}
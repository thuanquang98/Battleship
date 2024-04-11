using BattleshipMultiplayer.Model;

namespace BattleshipMultiplayer
{
    public class HumanPlayer : Player 
    {
        private readonly uint _id;
        public HumanPlayer(uint id, string name, int width, int height) : base(name, width, height)
        {
            _id = id;
        }

    }
}
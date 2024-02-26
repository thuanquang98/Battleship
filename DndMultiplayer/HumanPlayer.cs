using BattleshipMultiplayer.Model;

namespace BattleshipMultiplayer
{
    public class HumanPlayer : Player, IPlayable, Human 
    {
        public HumanPlayer(int id, string name) : base(id, name)
        {
        }

        public void PlayMove()
        {
            throw new NotImplementedException();
        }

        public void setAnswer()
        {
            throw new NotImplementedException();
        }

        public void setInfo(int row, int column)
        {
            throw new NotImplementedException();
        }
    }
}
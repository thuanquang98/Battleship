using BattleshipMultiplayer;
using BattleshipMultiplayer.Model;
using BattleshipMultiplayer.View;

namespace BattleShipTest
{
    [TestClass]
    public class BattleshipViewTest
    {
        [TestMethod]
        public void PrintGridUITest()
        {

            BattleshipGame game = new BattleshipGame();
            BattleshipTextView view = new BattleshipTextView(game);

            view.SetEventHandler(game);

            view.DisplayGrid();
        }
    }
}
using BattleshipMultiplayer;
using BattleshipMultiplayer.Application;
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
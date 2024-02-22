using BattleshipMultiplayer;

namespace BattleShipTest
{
    [TestClass]
    public class GridUITest
    {
        [TestMethod]
        public void PrintGridUI()
        {
            GridUI ui = new GridTextUI();
            ui.SetUI(new HumanPlayer());
            
        }
    }
}
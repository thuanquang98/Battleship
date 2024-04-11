using BattleshipMultiplayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void BuildBoardTest()
        {
            int WIDTH = 10;
            int HEIGHT = 10;
            Board board = new Board(WIDTH, HEIGHT);

            Assert.AreEqual(WIDTH, board.BoardWidth, "Board Width set in constructor is not correct");
            Assert.AreEqual(HEIGHT, board.BoardHeight, "Board Height set in constructor is not correct");

            //should be set as WaterCell
            char[,] boardChars = board.GetBoardState(true);

            for(int i = 0; i < boardChars.GetLength(0); i++)
            {
                for (int j = 0; j < boardChars.GetLength(1); j++)
                {
                    Assert.AreEqual(' ', boardChars[i, j], "This cell char is not set as ' '");
                }
            }
        }
    }
}

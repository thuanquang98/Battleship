using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipMultiplayer.Model;
using BattleshipMultiplayer.View;

namespace BattleshipMultiplayer.Controller
{
    internal class BattleshipController
    {
        private Human player;
        private BattleshipView gridView;

        public BattleshipController(Human player, BattleshipView view)
        {
            this.player = player;
            this.gridView = view;
        }

        public BattleshipController()
        {
            player = new HumanPlayer(-1, "Thuan");
        }

        //start the game by establishing link with the models and view
        public void Start()
        {

            bool gameBuilt = CreateGame();

            if (gameBuilt)
            {

            }
        }

        private bool CreateGame()
        {
            bool success = false;

            try
            {
                BattleshipGame game = new BattleshipGame(player);

                success = true;
            }catch (Exception ex)
            {
                Console.WriteLine("Fatal problem occurred:");
                Console.WriteLine(ex.Message);
            }
            

            return success;
        }

    }
}

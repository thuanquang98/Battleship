
using BattleshipMultiplayer.Controller;
using System.Collections.Concurrent;

namespace BattleshipMultiplayer
{
    static class Application
    {
        private static string menu_msg = "Welcome to Battleships!\n Enter '1' for single player, enter '2' for Multiplayer\nEnter 'q' to quit the game";

        static void Main()
        {   
            

            try
            {
                BattleshipController controller = new BattleshipController();

                controller.SetGame();

                controller.Build();

                controller.Run();
                
            }catch (Exception ex)
            {
                Console.WriteLine("Error has occurred;");
                Console.WriteLine(ex.Message);   
            }
            int x, y = 5;
            Console.WriteLine();

        }
        
    }
    
}




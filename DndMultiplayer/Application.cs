
using System.Collections.Concurrent;

namespace BattleshipMultiplayer
{
    static class Application
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Battleships!\n Enter 's' for single player, enter 'm' for Multiplayer\nEnter 'q' to quit the game");
            string? input = null;

            do
            {
                input = Console.ReadLine();
                if (input == "s")
                {
                    GameLogic gameLogic = new SinglePlayerGame();
                    gameLogic.Start();
                    break;
                }
                else if (input == "m")
                {
                    GameLogic gameLogic = new MultiplayerGame();
                    gameLogic.Start();
                    break;
                }
                else if (input == "q")
                {                
                    Console.WriteLine("Exit game successfully...");
                    break;
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid command\n Enter 's' for single player, enter 'm' for Multiplayer\nEnter 'q' to quit the game");
                }
            } while (true);    

            
        }
        
    }
    
}




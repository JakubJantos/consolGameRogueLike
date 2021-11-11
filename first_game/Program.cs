using System;

namespace first_game
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayersName playersName = new PlayersName();
            PlayerOrigin playerOrigin = new PlayerOrigin();
            MapRendering mapRendering = new MapRendering();
            PlayerMovment playerMovment = new PlayerMovment();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nHello Stranger, welcome to ROU SHA!\n" +
                              "My name is (NPC name) and Who are you?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nwrite your name here: ");
            Console.ResetColor();

            //calling the method from PlayerName class
            playersName.names();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nTel me '{playersName.getName()}' from where are you cumming to us?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nwrite yours origin: ");
            Console.ResetColor();

            // calling the method from PlayerOrigin class
            playerOrigin.Origins();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPres any key to see the map");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.Clear();

            //calling the method that render map
            mapRendering.MapRender(true);

            Console.ReadKey(true);
            Console.Clear();

            //calling the method that render level
            mapRendering.MapRender(false);
            
            
            playerMovment.Move();
            
            Console.SetCursorPosition(0,mapRendering.getLevel().Length);
            
        }
    }
}
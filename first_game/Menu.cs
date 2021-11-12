using System;

namespace first_game
{
    public class Menu
    {
        
        MapRendering mapRendering = new MapRendering();

        public void PrintMenu()
        {
            
            Console.Clear();
            Play play = new Play();
            Console.WriteLine("P = play");
            Console.WriteLine("M = Map");
            Console.WriteLine("X = Exit");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.P)
            {
                Console.Clear();
                play.StartGame();
            }
            else if (keyInfo.Key == ConsoleKey.M)
            {
                Console.Clear();
                mapRendering.MapRender(true);
                Console.ReadKey(true);
                Console.Clear();
                PrintMenu();
            }
            else if (keyInfo.Key == ConsoleKey.X)
            {
                Console.Clear();
            }

        }

        public void InGameMenu()
        {
            
            Console.Clear();
            Console.WriteLine("M = Map");
            Console.WriteLine("P = Play");
            
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.M)
            {
                Console.Clear();
                mapRendering.MapRender(true);
                Console.ReadKey(true);
                InGameMenu();
            }else if (keyInfo.Key == ConsoleKey.P)
            {
                Console.Clear();
            }
        }
    }
}
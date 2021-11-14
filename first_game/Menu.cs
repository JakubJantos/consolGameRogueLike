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
            Console.WriteLine("C = Controls");
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
            else if (keyInfo.Key == ConsoleKey.C)
            {
                PrintControls();
            }
            else if (keyInfo.Key == ConsoleKey.X)
            {
                Console.Clear();
            }
            else
            {
                PrintMenu();
            }
        }
        public void InGameMenu()
        {
            Console.Clear();
            Console.WriteLine("M = Map");
            Console.WriteLine("P = Play");
            Console.WriteLine("E = Eq");
            
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            
            if (keyInfo.Key == ConsoleKey.M)
            {
                Console.Clear();
                mapRendering.MapRender(true);
                Console.ReadKey(true);
                InGameMenu();
            }
            else if (keyInfo.Key == ConsoleKey.P)
            {
                Console.Clear();
            }
            else if (keyInfo.Key == ConsoleKey.E)
            {
                printeq();
            }
            else
            {
                InGameMenu();
            }
        }
        void printeq()
        {
            Console.Clear();
            Console.WriteLine("eq is not implemented jet");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.X)
            {
                Console.Clear();
            }
            else
            {
                printeq();
            } 
        }
        void PrintControls()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Up arrow = move up" +
                              "\nDown arrow = move down" +
                              "\nLeft arrow = move left" +
                              "\nRight arrow = move right" +
                              "\nE = open equipment" +
                              "\nSpace = atak" +
                              "\nX = close / go back");
            Console.ResetColor();
            
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            
            if (keyInfo.Key == ConsoleKey.X)
            {
                PrintMenu();    
            }
            else
            {
                PrintControls();
            }
        }
    }
}
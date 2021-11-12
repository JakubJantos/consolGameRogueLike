using System;
using System.Threading;

namespace first_game
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] logo = {
                "   _____________   ",
                " _|_           _|_ ",
                "| |_|         |_| |",
                "|                 |",
                "|      R O U      |",
                "|      S H A      |",          
                "|  _           _  |", 
                "|_|_|         |_|_|",
                "  |_____________|  "
            };
            for (int i = 0; i < logo.Length; i++)
            {
                Console.WriteLine(logo[i]);
                Thread.Sleep(200);
            }
            
            Menu menu = new Menu();
            menu.PrintMenu();
        }

    }
}
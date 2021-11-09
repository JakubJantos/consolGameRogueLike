﻿using System;

namespace first_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nHello Stranger, welcome to (name of world)!\n" +
                              "My name is (NPC name) and Who are you?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nwrite your name here: ");
            Console.ResetColor();
            
            //calling the method from PlayerName class
            PlayersName playersName = new PlayersName();
            playersName.names();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nTel me '{playersName.getName()}' from where are you cumming to us?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nwrite yours origin: ");
            Console.ResetColor();

            // calling the method from PlayerOrigin class
            PlayerOrigin playerOrigin = new PlayerOrigin();
            playerOrigin.Origins();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPres any key to see the map");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.Clear();
            
            //calling the method from Map rendering class
            MapRendering mapRendering = new MapRendering();
            mapRendering.mapRender();

            Console.ReadKey(true);
            Console.Clear();

            foreach (String row in mapRendering.getLevel())
            {
                Console.WriteLine(row);
            }

            
        }
    }
}
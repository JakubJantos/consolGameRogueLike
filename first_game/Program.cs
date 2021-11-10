using System;

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

            int playerColumn = 3;
            int playerRow = 2;

            while (true)
            {
                Console.SetCursorPosition(playerColumn, playerRow);
                String player = "@";
                Console.Write(player);

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                Console.SetCursorPosition(playerColumn, playerRow);
                String curentRow = mapRendering.getLevel()[playerRow];
                char curentCel = curentRow[playerColumn];
                Console.Write(curentCel);

                int targetColumn = playerColumn;
                int targetRow = playerRow;

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    targetRow = playerRow - 1;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    targetRow = playerRow +1;
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    targetColumn = playerColumn + 1;

                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    targetColumn = playerColumn - 1;
                }

                if (targetRow >= 0 && targetRow < mapRendering.getLevel().Length)
                {
                    playerRow = targetRow;
                }

                if (targetColumn >= 0 && targetColumn < mapRendering.getLevel()[playerRow].Length){   
                    
                  playerColumn = targetColumn;
                }
            }
            Console.SetCursorPosition(0,mapRendering.getLevel().Length);
        }
    }
}
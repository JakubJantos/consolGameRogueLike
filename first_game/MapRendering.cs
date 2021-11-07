using System;
using System.Threading;

namespace first_game
{
    public class MapRendering
    {
        public void mapRender()
        {
            String[] map =
            {
                "        |  #########  |",
                "        |  #    #  #  |",
                "        |  #   ##  #  |",
                "        |  #    #  #  |",
                "        |  #    #  #  |",
                "        |  #       #  |",
                "        |  #    #  #  |",
                "        |  #########  |"
            };

            String[] scroll =
            {
                "      _______________",
                " ()==(              (@==()",
                "      '______________'|",
                "        |             |",
                "      __)_____________|    ",
                " ()==(               (@==()",
                "      '--------------'"
            };

            int halfLenghtOfScroll = scroll.Length / 2+1;

            for (int i = 0; i < halfLenghtOfScroll ; i++)
            {
                Console.WriteLine(scroll[i]);
            }

            int mapRowsPositioning = Console.CursorTop;

            foreach (String row in map)
            {
                Console.SetCursorPosition(0, mapRowsPositioning);
                Console.WriteLine(row);
                
                    
                for (int i = halfLenghtOfScroll; i < scroll.Length ; i++)
                {
                    Console.WriteLine(scroll[i]);
                            
                }
                mapRowsPositioning++;
                Thread.Sleep(700);
            }
            
        }
    }
}
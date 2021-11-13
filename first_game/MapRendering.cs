using System;
using System.Threading;

namespace first_game
{
    
    public class MapRendering
    {
        static String[] level = //proper map in string array maybe change it to a random generated maps
        {
            "#########",
            "#    #  #",
            "#   ##  #",
            "#    #  #",
            "#    #  #",
            "#       #",
            "#    #  #",
            "#########"
        };

        static String[] scroll = 
        {
            "      _______________",
            " ()==(              (@==()",
            "      '______________'|",
            "        |             |",
            "      __)_____________|    ",
            " ()==(               (@==()",
            "      '--------------'"
        };
        int halfLenghtOfScroll = scroll.Length / 2+1; // getting half of scroll array and add it to variable
        int mapRowsPositioning;
        public void MapRender(bool levelOrMap)
        {
            if (levelOrMap)
            {
                //loop to print out first half of scroll graphics
                for (int i = 0; i < halfLenghtOfScroll ; i++)
                {
                    Console.WriteLine($"{scroll[i]}");
                }
                
                mapRowsPositioning = Console.CursorTop;//getting the value of position of cursor in console     

                foreach (String row in level)
                {
                    Console.SetCursorPosition(0, mapRowsPositioning);
                    Console.WriteLine($"        |  {row}  |");
                
                    // printing a down half of scroll graphics    
                    for (int i = halfLenghtOfScroll; i < scroll.Length ; i++)
                    {
                        Console.WriteLine(scroll[i]);
                    }
                    mapRowsPositioning++; // increasing a console cursor to make down part of scroll always visible 
                    Thread.Sleep(400); //sleep for a while to get cool effect of rolling out a scroll
                }   
            }
            else
            {
                foreach (String row in level)
                {
                    Console.WriteLine(row);
                }
            }
            
        }
        public static String[] getLevel()
        {
            return level;
        }
    }
}
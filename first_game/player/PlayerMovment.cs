using System;

namespace first_game
{
    public class PlayerMovment
    {
        int playerColumn = 3;
        int playerRow = 2;
        String player = "@";
        char curentCel;
        int targetColumn;
        int targetRow;
        char xWallDetected;
        char yWallDetected;
        
        public void Move()
        {
            MapRendering mapRendering = new MapRendering();

            String[] lvl = mapRendering.getLevel();
            
            while (true)
            {
                Display(playerColumn,playerRow,player);

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                
                curentCel = lvl[playerRow][playerColumn];

                Display(playerColumn,playerRow,curentCel.ToString());
                
                targetColumn = playerColumn;
                targetRow = playerRow;

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    targetRow = playerRow - 1;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    targetRow = playerRow + 1;
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    targetColumn = playerColumn + 1;

                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    targetColumn = playerColumn - 1;
                }
                else
                {
                    Console.Clear();
                    break;
                }
                
                xWallDetected = lvl[playerRow][targetColumn];
                yWallDetected = lvl[targetRow][playerColumn];
                
                if (targetRow >= 0 && targetRow < lvl.Length && yWallDetected != '#')
                {
                    playerRow = targetRow;
                }

                if (targetColumn >= 0 && targetColumn < lvl[playerRow].Length && xWallDetected != '#')
                {

                    playerColumn = targetColumn;
                }
            }
        }//move

        public void Display(int yAxis, int xAxis, String txt)
        {
            Console.SetCursorPosition(yAxis, xAxis);
            Console.Write(txt);
        }
        
    }//class
}
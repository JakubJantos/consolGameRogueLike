using System;

namespace first_game
{
    public class PlayerMovment
    {
        int playerColumn = 3;
        int playerRow = 2;
        String player = "@";
        
        public void Move()
        {
            MapRendering mapRendering = new MapRendering();

            String[] lvl = mapRendering.getLevel(); 
            char curentCel = lvl[playerRow][playerColumn];
            int targetColumn = playerColumn;
            int targetRow = playerRow;
            char xWallDetected = lvl[playerRow][targetColumn];
            char yWallDetected = lvl[targetRow][playerColumn];
            
            while (true)
            {
                Display(playerColumn,playerRow,player);

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                Display(playerColumn,playerRow,curentCel.ToString());

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
                    break;
                }
                
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

        public void Display(int yAxis, int xAxis, String chero)
        {
            Console.SetCursorPosition(yAxis, xAxis);
            Console.Write(chero);
        }
        
    }//class
}
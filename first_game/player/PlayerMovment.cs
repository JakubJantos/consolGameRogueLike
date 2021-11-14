using System;

namespace first_game
{
    public class PlayerMovment
    {
        char curentCel;
        int targetColumn;
        int targetRow;
        char xWallDetected;
        char yWallDetected;
        
        String[] lvl = MapRendering.getLevel();
        
        Player player = new Player(7,6, "@");
        
        public void Move()
        {
            player.IsDet = true;
            while (player.IsDet.Equals(true))
            {
                //display a player
                Display(player.XAxis,player.YAxis,player.Avatar);
                //w8 for player pres key
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                //geting current position of player and adding that to variable 
                curentCel = lvl[player.YAxis][player.XAxis];
                //replacing place after player move whyw proper sign
                Display(player.XAxis,player.YAxis,curentCel.ToString());
                
                targetColumn = player.XAxis;
                targetRow = player.YAxis;

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    targetRow = player.YAxis - 1;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    targetRow = player.YAxis + 1;
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    targetColumn = player.XAxis + 1;

                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    targetColumn = player.XAxis - 1;
                }
                else if (keyInfo.Key == ConsoleKey.X)
                {
                    Console.Clear();
                    break;
                }
                
                Items.DisplayItem();
                WallColision();
                
                if (targetColumn == 7 && targetRow == 1)
                {
                    Console.Clear();
                    player.IsDet = false;
                    Console.WriteLine("GAME OWER!");
                }
            }
        }//move

        public void WallColision()
        {
            xWallDetected = lvl[player.YAxis][targetColumn];
            yWallDetected = lvl[targetRow][player.XAxis];
                
            if (targetRow >= 0 && targetRow < lvl.Length && yWallDetected != '#')
            {
                player.YAxis = targetRow;
            }

            if (targetColumn >= 0 && targetColumn < lvl[player.YAxis].Length && xWallDetected != '#')
            {

                player.XAxis = targetColumn;
            }    
        }
        
        public static void Display(int XAxis, int YAxis, String txt)
        {
            Console.SetCursorPosition(XAxis, YAxis);
            Console.Write(txt);
        }
        
    }//class
}
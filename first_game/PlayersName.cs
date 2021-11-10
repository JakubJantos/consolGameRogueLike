using System;

namespace first_game
{
    public class PlayersName
    {
        // getting a player input and assign it to the variable 
        static String name = Console.ReadLine();

        //public static String nameStartingWhywUpper = char.ToUpper(name[1]) + name.Substring(1).ToLower();

        String getNameWhywUpper()
        {
            if (!String.IsNullOrEmpty(name))
            {
                String nameUpper = char.ToUpper(name[0]) + name.Substring(1).ToLower();
                return nameUpper;
            }
            else
            {
                return " ";
            }
             
        }
        
        public void names()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (name.ToLower() == "stranger")// checking if player insert name as e "stranger" then print a proper message
            {
                Console.WriteLine($"\nHA!! I know it, so welcome '{getNameWhywUpper()}'.");
            }else if (String.IsNullOrWhiteSpace(name))// checking if player dont insert any name then print a proper message
            {
                name = "Stranger";
                Console.WriteLine($"\nSo I'll col you '{name}' then.");
            }
            else // if player insert any other text it'll be consider as a name to the end of the game 
            {
                Console.WriteLine($"\nSo welcome '{getNameWhywUpper()}' in ours small village."); //welcome the player 
            }
            Console.ResetColor();
        }

        public string getName()
        {
            return getNameWhywUpper();
        }
    }
}
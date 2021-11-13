using System;

namespace first_game
{
    public class PlayerOrigin
    {
        //getting the player input and assign it to the variable
        static String origin = Console.ReadLine();

        public void Origins()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (string.IsNullOrWhiteSpace(origin)) // checking if player dont insert any origin then print a proper message
            {
                origin = "Nowhere";
                Console.WriteLine($"\nYou dont wont to tell me? ok then I'll say  you come from '{origin}'");
            }
            else // if player insert any other text it'll be consider as player origin
            {
                Console.WriteLine($"\nI newer hear about '{origin}' it must be small place just like ours village");
            }
            Console.ResetColor();
        }

        public static String getOrigin()
        {
            return origin;
        }
    }
}
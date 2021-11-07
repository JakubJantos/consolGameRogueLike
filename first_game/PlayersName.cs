using System;

namespace first_game
{
    public class PlayersName
    {
        static String name = Console.ReadLine();

        String nameStartingWhywUpper = char.ToUpper(name[0]) + name.Substring(1);
        public void names()
        {
            if (name.ToLower() == "stranger")
            {
                Console.WriteLine($"HA!! I know it, so welcome {nameStartingWhywUpper}.");
            }else if (String.IsNullOrWhiteSpace(name))
            {
                name = "Stranger";
                Console.WriteLine($"So I'll col you {nameStartingWhywUpper} then.");
            }
            else
            {
                Console.WriteLine($"So welcome {nameStartingWhywUpper} in ours small village.");
            }
        }

        public string getName()
        {
            return nameStartingWhywUpper;
        }
    }
}
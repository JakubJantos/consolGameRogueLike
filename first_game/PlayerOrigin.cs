using System;

namespace first_game
{
    public class PlayerOrigin
    {
        String origin = Console.ReadLine();

        public void Origins()
        {
            if (string.IsNullOrWhiteSpace(origin))
            {
                origin = "Nowhere";
                Console.WriteLine($"You dont wont to tell me? ok then I'll say  you come from {origin}");
            }
            else
            {
                Console.WriteLine($"I newer hear abouth {origin} it must be small place just like ouers vilage");
            }
        }
    }
}
using System;

namespace first_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Stranger, welcome to (name of world)!\n" +
                              "My name is (NPC name) and Who are you? ");
            Console.WriteLine("Name: ");
            
            String name = Console.ReadLine();

            if (name.ToLower() == "stranger")
            {
                Console.WriteLine($"HA!! I know it, so welcome {name}.");
            }else if (String.IsNullOrWhiteSpace(name))
            {
                name = "Stranger";
                Console.WriteLine($"So I'll col you {name} then.");
            }
            else
            {
                Console.WriteLine($"So welcome {name} in ours small village.");
            }
        
    
            
            Console.WriteLine($"Tel me {name} from where are you cumming to us?");
            Console.WriteLine("Origin: ");
            String origin = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(origin))
            {
                origin = "Nowhere";
                Console.WriteLine($"You dont wont to tell me? ok then I'll say  you come from {origin}");
            }
            else
            {
                Console.WriteLine($"I newer hear abouth {origin} it must be small place just like ouers vilage");
            }
            
            //String map = 
            
            Console.WriteLine("pres any key to contine...");
            Console.ReadKey(true);
        }
    }
}
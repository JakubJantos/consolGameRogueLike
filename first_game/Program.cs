using System;

namespace first_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Stranger, welcome to (name of world)!\nWho are you? ");
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
            
            
            Console.WriteLine("pres any key to contine...");
            Console.ReadKey(true);
        }
    }
}
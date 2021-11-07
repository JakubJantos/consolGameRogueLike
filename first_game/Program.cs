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

            PlayersName playersName = new PlayersName();
            playersName.names();
            
            Console.WriteLine($"Tel me {playersName.getName()} from where are you cumming to us?");
            Console.WriteLine("Origin: ");

            PlayerOrigin playerOrigin = new PlayerOrigin();
            playerOrigin.Origins();
            
            Console.WriteLine("pres any key to contine...");
            Console.ReadKey(true);
            Console.Clear();

            MapRendering mapRendering = new MapRendering();
            mapRendering.mapRender();
        }
    }
}
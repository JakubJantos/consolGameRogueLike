using System;

namespace first_game
{
    public class Dialogs
    {
        public void StartingDialogs()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nHello Stranger, welcome to ROU SHA!\n" +
                              "My name is (NPC name) and Who are you?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nwrite your name here: ");
            Console.ResetColor();

            //calling the method from PlayerName class
            PlayersName playersName = new PlayersName();
            playersName.names();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nTel me '{PlayersName.getName()}' from where are you cumming to us?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nwrite yours origin: ");
            Console.ResetColor();

            // calling the method from PlayerOrigin class
            PlayerOrigin playerOrigin = new PlayerOrigin();
            playerOrigin.Origins();
        }
    }
}
using System;

namespace first_game
{
    public class Items
    {        
        String name;
        String type;
        String signature;
        int power;
        int xPosition;
        int yPosition;
        
        public Items(string name, string type,string signature, int power, int xPosition, int yPosition)
        {
            this.name = name;
            this.type = type;
            this.signature = signature;
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.power = power;
        }

        public static void DisplayItem()
        {
            bool isColectet = false;
            do
            {
                Items items = new Items("Wooden Shield", "Armor", "%", 20, 4, 1);

                Console.SetCursorPosition(items.xPosition, items.yPosition);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(items.signature);
                Console.ResetColor();

                Player player = new Player();
                int playerXAxis = player.XAxis;
                int playerYAxis = player.YAxis;

                if (playerXAxis == items.xPosition && playerYAxis == items.yPosition)
                {
                    player.Armor = items.power;
                    Console.SetCursorPosition(MapRendering.getLevel()[0].Length + 2, 4);
                    Console.WriteLine(player.Armor);
                    isColectet = true;
                }
            } while (isColectet == true);
        }
        
    }
}
using System;
using System.Collections.Generic;

namespace first_game
{
    public class Player
    {
        String name;
        String origin;
        private String avatar;
        int HP;
        int armor;
        List<Items> eq = new List<Items>();
        
        public void CreatePlayer()
        {
            PlayersName playersName = new PlayersName();
            name = playersName.getName();
            PlayerOrigin playerOrigin = new PlayerOrigin();
            origin = playerOrigin.getOrigin();
            avatar = "@";
            HP = 100;
            armor = 0;
            eq.Add(new Items("wooden sword", "weapon", 10));
            eq.Add(new Items("Wooden sheld","armor",20));
        }

        public void DisplayStats()
        {
            MapRendering mapRendering = new MapRendering();

             int lengtOfMap= mapRendering.getLevel()[0].Length;
             
             Console.SetCursorPosition(lengtOfMap + 2,1);
             Console.WriteLine($"HP = {HP}");
             Console.SetCursorPosition(lengtOfMap + 2,2);
             Console.WriteLine($"Armor = {armor}");
        }
    }
}
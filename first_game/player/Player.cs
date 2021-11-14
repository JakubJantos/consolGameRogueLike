using System;
using System.Collections.Generic;
using System.Threading;

namespace first_game
{
    public class Player
    {
        String name;
        String origin;
        int xAxis;
        int yAxis;
        String avatar;
        int HP;
        int armor;
        bool isDet;
        List<Items> eq = new List<Items>();
        
        public Player()
        {
        }

        public Player(string name, string origin, int hp, int armor)
        {
            this.name = name;
            this.origin = origin;
            HP = hp;
            this.armor = armor;
        }

        public Player(int xAxis, int yAxis, string avatar)
        {
            this.xAxis = xAxis;
            this.yAxis = yAxis;
            this.avatar = avatar;
        }

        public void DisplayStats()
        {
            Player player = new Player(PlayersName.getName(),PlayerOrigin.getOrigin(),100,0);
            
            int lengtOfMap= MapRendering.getLevel()[0].Length;
             
             Console.SetCursorPosition(lengtOfMap + 2,1);
             Console.WriteLine($"Name = {player.Name}");
             Console.SetCursorPosition(lengtOfMap + 2,2);
             Console.WriteLine($"Hp = {player.Hp}");
             Console.SetCursorPosition(lengtOfMap + 2, 3);
             Console.WriteLine($"Armor = {player.Armor}");
        }
        
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Origin
        {
            get => origin;
            set => origin = value;
        }

        public int XAxis
        {
            get => xAxis;
            set => xAxis = value;
        }

        public int YAxis
        {
            get => yAxis;
            set => yAxis = value;
        }

        public string Avatar
        {
            get => avatar;
            set => avatar = value;
        }

        public int Hp
        {
            get => HP;
            set => HP = value;
        }

        public int Armor
        {
            get => armor;
            set => armor = value;
        }

        public bool IsDet
        {
            get => isDet;
            set => isDet = value;
        }

        public List<Items> Eq
        {
            get => eq;
            set => eq = value;
        }
    }
}

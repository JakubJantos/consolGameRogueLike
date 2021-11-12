using System;

namespace first_game
{
    public class Items
    {        
        String name;
        String type;
        int power;
        
        public Items(string name, string type, int power)
        {
            this.name = name;
            this.type = type;
            this.power = power;
        }
        public Items WodenSword = new Items("sword","weapon",20);
        public Items WodenSheld = new Items("sheld", "armor", 5);
    }
}
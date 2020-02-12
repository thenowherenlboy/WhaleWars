using System;

namespace WhaleWars
{
    public class Weapon : Item
    {
        public int upperdamage;
        public int lowerdamage;
        public int range;
      
    }

    public class Sword : Weapon
    {
        public Sword()
        {
            Name = "Singing Sword";
            Upperdamage = 10;
            Lowerdamage = 4;

        }
    }

    public class Wand : Weapon
    {
        public Wand()
        {
            Name = "Wonder Wand";
            Upperdamage = 15;
            Lowerdamage = 8;
            
        }
    }
    public class Bow : Weapon
    {
        public Bow()
        {
            Name = "Rain Bow";
            Upperdamage = 4;
            Lowerdamage = 1;
            
        }
    }
    public class Blowhole : Weapon
    {
        public Blowhole()
        {
            Name = "Blow"
        }
    }

    // array = ["blowhole", "12", "
}
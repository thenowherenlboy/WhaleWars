using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    public class Armor : Item
    {
        public CharClass charClass;
        public int defenseModifier { get; set; }
        public Armor(string name, int def, CharClass classClass)
        {
            Name = name;
            charClass = classClass;
            defenseModifier = def;           
        }

        public Armor()
        {
            Name = "melvin";
            charClass = CharClass.fighter;
            defenseModifier = 0;
        }
    }

    public class Plating : Armor
    {
        public Plating()
        {
            Name = "Bobby Blow's Bronze Armour";
            charClass = CharClass.fighter;
            defenseModifier = 10;
        }
    }

    public class Chainmail : Armor
    {
        public Chainmail()
        {
            Name = " Silver Glittery Rainacorn Scales";
            charClass = CharClass.ranger;
            defenseModifier = 2;
        }
    }
     
    public class Cloth : Armor
    {
        public Cloth()
        {
            Name = "Reptilian Magical Cloth";
            charClass = CharClass.mage;
            defenseModifier = 5;
        }
    }

}

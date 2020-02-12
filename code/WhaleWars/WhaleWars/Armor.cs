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

    public class Bronze : Armor
    {
        public Bronze()
        {
            Name = "Bobby Blow's Bronze Armour";
            charClass = CharClass.fighter;
            defenseModifier = 1;
        }
    }
}

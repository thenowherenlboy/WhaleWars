using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    public class Armor : Item
    {
        CharClass _CharClass;
        private int defenseModifier { get; set; }
        public Armor(string name, int def, CharClass classClass)
        {
            Name = name;
            _CharClass = classClass;
            defenseModifier = def;           
        }
    }

    public class Bronze : Armor
    {
        public Bronze();
        {
         Name = "Bronze Armor";
         CharClass _CharClass = CharClass.fighter;
        int defenseModifier = 1;
         
         
        }
    }

}

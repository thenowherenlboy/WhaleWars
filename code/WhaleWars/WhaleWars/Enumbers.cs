using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    public enum Sector : byte { Krupula, Morhann, DeegosBogeySphere, Blowholia }
    public enum PlanetType : byte { barren, ocean, lava, ice, temperate, storm }
    public enum CharClass : byte { fighter, ranger, mage }
    public enum ElementTypes : byte { Lightning, Fire, Ice }
    public enum WeaponList 
    {
        Sword,
        Knife,
        Bow,
        Blowhole,
        Chimichanga,
        Wand,
        UltraBoof
    }

    public enum WeaponType
    {
        melee,
        ranged,
        magic
    }

}

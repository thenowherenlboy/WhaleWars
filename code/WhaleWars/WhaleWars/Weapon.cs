using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{

    public class Weapon 
    {
        public WeaponList Name { get; set; } // instead of string, use enum for more efficiency 
        public int Damage { get; set; }
        public int Defense { get; set; }

        public Weapon(WeaponList weapon, int damage, int defense)  // Constructor needs these 3 parameters to create. This is only used for the CreateWeapons() method. 
        {
            this.Name = weapon;
            this.Damage = damage;
            this.Defense = defense;
        }


        public static List<Weapon> CreateWeapons() {  //Method that uses a list of type Weapon to create all weapons necessary for the game. 
            List<Weapon> weapons = new List<Weapon>();
            weapons.AddRange(new Weapon[]
            {
                new Weapon(WeaponList.Sword, 6, 4),
                new Weapon(WeaponList.Knife, 7, 3),
                new Weapon(WeaponList.Bow, 2, 8),
                new Weapon(WeaponList.Blowhole, 9, 1),
                new Weapon(WeaponList.Chimichanga, 8, 2),
                new Weapon(WeaponList.Wand, 5, 5),
                new Weapon(WeaponList.UltraBoof, 10, 10)
            });
            return weapons;
                }
    }
}

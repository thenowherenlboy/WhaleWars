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



        public static Weapon CreateWeapon(WeaponList weap) //Method that uses a list of type Weapon to create all weapons necessary for the game. 
        {
            switch (weap)
            {

                case WeaponList.Sword:
                    Weapon Sword = new Weapon(weap, 6, 4);
                    return Sword;


                case WeaponList.Knife:
                    Weapon Knife = new Weapon(weap, 7, 3);
                    return Knife;


                case WeaponList.Bow:
                    Weapon Bow = new Weapon(weap, 2, 8);
                    return Bow;


                case WeaponList.Blowhole:
                    Weapon Blowhole = new Weapon(weap, 9, 1);
                    return Blowhole;

                case WeaponList.Chimichanga:
                    Weapon Chimichanga = new Weapon(weap, 8, 2);
                    return Chimichanga;



                case WeaponList.Wand:
                    Weapon Wand = new Weapon(weap, 5, 5);
                    return Wand;


                case WeaponList.UltraBoof:
                    Weapon UltraBoof = new Weapon(weap, 10, 10);
                    return UltraBoof;


                default:
                    return null;
            }
        }
    }
}

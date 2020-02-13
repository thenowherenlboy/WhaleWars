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


        public static Weapon CreateWeapons(WeaponList weap) //Method that uses a list of type Weapon to create all weapons necessary for the game. 
        {  
            switch (weap){
            
                case WeaponList.Sword:
                    Weapon CharWeapon = new Weapon(weap, 6, 4);
                    return CharWeapon;
                    break;

                case WeaponList.Knife:
                    Weapon CharWeapon = new Weapon(weap, 7, 3);
                    return CharWeapon;
                    break;

                case WeaponList.Bow:
                    Weapon CharWeapon = new Weapon(weap, 2, 8);
                    return CharWeapon;
                    break;

                case WeaponList.Blowhole:
                    Weapon CharWeapon = new Weapon(weap, 9, 1);
                    return CharWeapon;
                    break;
                  
                case WeaponList.Chimichanga:
                    Weapon CharWeapon = new Weapon(weap, 8, 2);
                    return CharWeapon;
                    break;

                case WeaponList.Wand:
                    Weapon CharWeapon = new Weapon(weap, 5, 5);
                    return CharWeapon;
                    break;

                case WeaponList.UltraBoof:
                    Weapon CharWeapon = new Weapon(weap, 10, 10);
                    return CharWeapon;
                    break;
            }            
            
        }
    }
}

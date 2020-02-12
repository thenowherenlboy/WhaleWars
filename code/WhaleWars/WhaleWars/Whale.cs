using System;
using System.Collections.Generic;

namespace WhaleWars 
{
    public class Whale
    {
        public string Name { get; set;}
        public int Health  { get; set;}
        public int Defense { get; set;}
        public int Offense { get; set;}
        public CharClass _CharClass { get; set;}
        private List<Item> inventory = new List<Item>();
        private Weapon equippedWeapon;  //ready weapon
        public void SetWeapon(Weapon weapon) // equip weapon if in inventory
        {
            foreach (Item item in inventory)
            {
                if (item.Equals(weapon))
                {
                    equippedWeapon = weapon;
                }
                else 
                {
                    equippedWeapon = null;
                }
            }
        }

        public string GetInventory()
        {
            string outString = "";
            foreach (Item item in inventory)
            {
                outString += item.Name + "\n";
            }
            return outString;
        }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }
        public void RemoveItem(Item item) // to remove on-time use items..
        {
            inventory.Remove(item);
        }
    }
}
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
        public CharClass CC { get; set;}

        
        public Whale(string _name, CharClass cc, int _health, int _defense, int _offense)
        {
            Name = _name;
            CC = cc;
            Health = _health;
            Defense = _defense;
            Offense = _offense;
        } //Creates an easily referenced intializer so you dont have to type out each property of the given Whale

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
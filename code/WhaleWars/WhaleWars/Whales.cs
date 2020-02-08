using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    public class Whales
    {
        
        protected int Health { get; set; }

    
        public void travel(Planet destination)
        {
            string dest = destination.ToString();
            Console.WriteLine($"You are arrived at planet {dest}.");
        }
        public void Attack(Object target, Weapon weapon)
        {
                       
        }
    }

    public class Orca : Whales //Warrior class
    {
        public Orca() 
        {
            Health = 50;
        }
       
    }

    public class Narwhal : Whales //Mage class
    {
        public Narwhal()
        {
            Health = 50;
        }
    }

    public class Beluga : Whales // Ranger Class
    {
        public Beluga()
        {
            Health = 50;
        }
    }
    
}

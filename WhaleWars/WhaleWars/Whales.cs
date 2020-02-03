using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    public class Whales
    {
        protected int speed { get; set; }
        protected int mass { get; set; }
        protected int capacity { get; set; }

        public Whales()
        {
            speed = 5;
            mass = 500;
            capacity = 25;
        }

        public Whales(int sp, int ms, int ca)
        {
            speed = sp;
            mass = ms;
            capacity = ca;
        }

        public void travel(Planet destination)
        {
            string dest = destination.ToString();
            Console.WriteLine($"You are arrived at planet {dest}.");
        }
    }

    public class Orca : Whales
    {
        public Orca()
        {
            speed = 20;
            mass = 250;
            capacity = 5;
        }

        public void Attack(Object target)
        {
            // STUB
           
        }
    }
    
}

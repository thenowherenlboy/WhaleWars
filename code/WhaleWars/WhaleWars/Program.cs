using System;

namespace WhaleWars
{
    class Program
    {
        public static void Main(string[] args)
        {
           /* Whale barney = new Whale("barney", CharClass.fighter, 10, 2, 2);

            Planet sumPlanet = new Planet("Blowholia Prime", PlanetType.ocean, 5,4,Sector.Blowholia);

            string Location = sumPlanet.Name;
            int Turn = 0;
            Console.Title = "Whale Wars";


            while (Turn < 20)
            {
                Turn++;
                HUD(barney.Name, Location, Turn, barney.Health, barney.Offense, barney.Defense);
                Console.WriteLine("Press enter to simulate turns progressing... turn number " + Turn + " ... ");
                Console.ReadKey();
                
            }

            Console.WriteLine("Simulation of game ending");
            Console.ReadKey(); */

            Weapon charwp = Weapon.CreateWeapon(WeaponList.Sword);
            Console.WriteLine(charwp.Name);
            Console.WriteLine(charwp.Damage);
            Console.WriteLine(charwp.Defense);
        }
    }
}
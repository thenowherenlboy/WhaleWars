using System;

namespace WhaleWars
{
    class Program
    {
        public static void Main(string[] args)
        {
            Whale barney = new Whale();
            barney.Health = 10;
            barney._CharClass = CharClass.fighter;
            barney.Defense = 2;
            barney.Offense = 2;
            barney.Name = "Barney";

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
            Console.ReadKey();

        }

        public static void HUD(string player, string location, int turn, int Health, int Attack, int Defence)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("*************************************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Whale-Wars");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================================================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("    " + player);
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(location);
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("turn " + turn + " /20");
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Health + " Health ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Attack + " Attack ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(Defence + " Defence \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================================================================\n\n\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" The Combat and Story Text will Apear hear! ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" When you take Damage it will apear in RED! ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" When you Attack it will apear in YELLOW! ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" When you Heal it will apear in GREEN!\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================================================================");

        }
    }
}
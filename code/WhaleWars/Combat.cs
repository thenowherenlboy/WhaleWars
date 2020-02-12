using System;

namespace WhaleWars
{
	public class Combat
	{
        public static void Battle(Whale user, Whale target)
        {
            Planet sumPlanet = new Planet("Blowholia Prime", PlanetType.ocean, 5, 4, Sector.Blowholia);
            string Location = sumPlanet.Name;

            while (user.Health > 0 && target.Health > 0)
            {
                HUD(user.Name, Location, user.Health, user.Offense, user.Defense);
                MageMoves(user, target);
                HUD(user.Name, Location, user.Health, user.Offense, user.Defense);
                EnemyAI(target, user);
            }
        } //Used as a test battle between two entities.
        public static int MageMoves(Whale user, Whale target)
        {
            Console.WriteLine("Select a skill to use\n" +
                "1) Magic Missle\n" +
                "2) Fire Ball\n" +
                "3) Blood Syphon\n" +
                "4) ArcaneShield");

            int Input = Convert.ToInt32(Console.ReadLine());

            switch (Input)
            {
                case int n when n == 1: return MagicMissle(user, target);
                case int n when n == 2: return FireBall(user, target);
                case int n when n == 3: return BloodSyphon(user, target);
                case int n when n == 4: return ArcaneShield(user);
            }

            return Wand(user, target);
        } //Allows the user to pick a skill
        public static int Wand(Whale user, Whale target)
        {
            target.Health -= (user.Offense - target.Defense);
            return target.Health;
        } //Basic attack
        public static int MagicMissle(Whale user, Whale target)
        {
            target.Health -= user.Offense;
            return target.Health;
        } //Deals more damage than basic attack
        public static int FireBall(Whale user, Whale target)
        {
            target.Health -= (user.Offense + 2);
            return target.Health;
        } //Deals more damage than Magic Missle
        public static int BloodSyphon(Whale user, Whale target)
        {
            target.Health -= user.Offense;
            user.Health += user.Offense;
            return target.Health;
        } //Deals damage and absorbes health
        public static int ArcaneShield(Whale user)
        {
            Console.WriteLine("You are surrounded with a purple barrier.");
            user.Defense += 20;
            return user.Defense;
        } //Increases Defense
        public static void HUD(string player, string location, int Health, int Attack, int Defence)
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

        } //Moved the Hud into the combat area, as its not needed in transition.
        public static int EnemyAI(Whale user, Whale target)
        {
            Random r = new Random();
            int ai = r.Next(1, 5);

            switch (ai)
            {
                case int n when n == 1: return MagicMissle(user, target);
                case int n when n == 2: return FireBall(user, target);
                case int n when n == 3: return BloodSyphon(user, target);
                case int n when n == 4: return ArcaneShield(user);
            }

            return Wand(user, target);
        }
    }
}


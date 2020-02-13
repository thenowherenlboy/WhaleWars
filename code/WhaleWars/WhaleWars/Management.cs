using System;

namespace WhaleWars
{
    public class Management
    {

        const int TYPESPEED = 30;


        public static void mgmt()
        {
            title();
            Whale UserChoice = new Whale("name", CharClass.fighter, 1, 1, 1);
            { UserChoice = GameStart(UserChoice); }

            ConsoleInterface.HUD(UserChoice.Name, "Planet", 0, UserChoice.Health, UserChoice.Offense, UserChoice.Defense);

        }
        public static void title()
        {
            //Console.SetWindowSize(100, 50);
            //Console.BufferHeight = 100;
            //Console.BufferWidth = 150;

            Typewrite("A long time ago...\n", TYPESPEED);
            Typewrite("In an ocean of space....\n", TYPESPEED);
            Typewrite("Far Far away...\n", TYPESPEED);
            Typewrite("There was a whale...\n", TYPESPEED);
            Typewrite("Floating aimlessly through space...\n", TYPESPEED);
            Typewrite("", TYPESPEED);
            printTitle();
            Welcome();
            Console.ReadKey();
        }
        static void Typewrite(string message, int speed)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(speed);
            }
        }
        static void printTitle()
        {
            Console.Title = "ASCII Art";
            string title = @"
 __      __ __            __            __      __                      
/  \    /  \  |__ _____  |  |   ____   /  \    /  \_____ _______  ______
\   \/\/   /  |  \\__  \ |  | _/ __ \  \   \/\/   /\__  \\_  __ \/  ___/
 \        /|   Y  \/ __ \|  |_\  ___/   \        /  / __ \|  | \/\___ \ 
  \__/\  / |___|  (____  /____/\___  >   \__/\  /  (____  /__|  /____  >
       \/       \/     \/          \/         \/        \/           \/                                  
                                                                 ";
            Typewrite(title, 5);
        }
        
        static void Welcome()
        {
            Typewrite("A Group-One production.\n\t\t\t\t\t\t\t\t A Chartese Desentery Ameoba Game.\n", TYPESPEED);
        }

        public static Whale GameStart(Whale UserChoice)
        {
            Console.WriteLine("Please input a name\n");
            string name = Console.ReadLine();

            Console.WriteLine("Please chose a class\n");
            string pick = Console.ReadLine();
            int ClassPicker = Convert.ToInt32(pick);

            switch (ClassPicker)
            {
                case int n when n == 1: { UserChoice = new Whale(name, CharClass.fighter, 10, 5, 5); return UserChoice; }
                case int n when n == 2: { UserChoice = new Whale(name, CharClass.ranger, 10, 6, 4); return UserChoice; }
                case int n when n == 3: { UserChoice = new Whale(name, CharClass.mage, 10, 7, 2); return UserChoice; }
                default: break;
            }
            return UserChoice;

        }
    }
}
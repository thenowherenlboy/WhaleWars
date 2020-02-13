using System;

namespace WhaleWars
{
    public class Management
    {


        public static void mgmt()
        {
            title();

            ConsoleInterface.HUD();

        }
        public static void title()
        {
            //Console.SetWindowSize(100, 50);
            //Console.BufferHeight = 100;
            //Console.BufferWidth = 150;

            Typewrite("A long time ago...\n");
            Typewrite("In an ocean of space....\n");
            Typewrite("Far Far away...\n");
            Typewrite("There was a whale...\n");
            Typewrite("Floating aimlessly through space...\n");
            Typewrite("");
            printTitle();
            Welcome();
            Console.ReadKey();
        }
        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(60);
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
            TypewriteFast(title);
        }
        static void TypewriteFast(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(5);
            }
        }
        static void Welcome()
        {
            Typewrite("A Group-One production.\n");
        }

        //public static void GameStart()
        //{
        //    Console.WriteLine("Please input a name\n");
        //    string name = Input();
        //    Console.WriteLine("Please chose a class\n");
        //    int ClassPicker = Convert.ToInt32(Input());

        //    Whale UserChoice = new Whale(name, CharClass.fighter, 0, 0, 0);

        //    switch (ClassPicker)
        //    {
        //        case int n when n == 1: { UserChoice = new Whale(name, CharClass.fighter, 10, 5, 5); break; }
        //        case int n when n == 2: { UserChoice = new Whale(name, CharClass.ranger, 10, 6, 4); break; }
        //        case int n when n == 3: { UserChoice = new Whale(name, CharClass.mage, 10, 7, 2); break; }
        //    }



        //}
    }
}
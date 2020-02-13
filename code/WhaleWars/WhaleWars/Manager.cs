using System;

namespace WhaleWars
{
	public class Managemenet
	{
		public static void mgmt()
		{
            title();

            ConsoleInterface.HUD(); 
                
		}
		public static void title()
        {
            Console.SetWindowSize(100, 50);
            Console.BufferHeight = 100;
            Console.BufferWidth = 150;

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
    }
}
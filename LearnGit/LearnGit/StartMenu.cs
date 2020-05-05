using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGit
{
    class StartMenu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            new StartMenu();
        }

        public StartMenu()
        {
            while (true)
            {
                string input = Console.ReadLine();
                Console.WriteLine();
                string order = input.ToLower();

                if (order == "h" || order == "help")
                {
                    Console.WriteLine("help\n");
                }
                else if (order == "q" || order == "quit")
                {
                    break;
                }
                else if (order == "p" || order == "prime")
                {
                    new PrimeChecker();
                    Console.WriteLine("Welcome back to the Main Menu.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please type in 'h' or 'help' for help");
                }
            }
        }
    }
}

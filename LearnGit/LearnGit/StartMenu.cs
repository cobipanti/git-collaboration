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
                Console.Clear();
                //Console.WriteLine(input);

                string order = input.ToLower();

                if (order == "h" || order == "help")
                {
                    Console.WriteLine("Enter the letter within the brackets [] to enter a command\n" +
                        "[H]elp\n[Q]uit\n[P]rime Number Checker\nTemperature [C]onverter");
                }
                else if (order == "q")
                {
                    break;
                }
                else if (order == "p")
                {
                    new PrimeChecker();
                    Console.WriteLine("Welcome back to the Main Menu. Enter h for help\n");
                }
                else if (order == "c")
                {
                    new TempConvert();
                    Console.WriteLine("Welcome back to the Main Menu. Enter h for help\n");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please type in 'h' or 'help' for help");
                }
            }
        }
    }
}

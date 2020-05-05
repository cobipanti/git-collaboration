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

            Console.WriteLine("  _    _          _   _            __          __                 _       _ \n" +
                @" | |  | |        | | | |           \ \        / /                | |     | |" + "\n"+
                @" | |__| |   ___  | | | |   ___      \ \  /\  / /    ___    _ __  | |   __| |" + "\n" +
                @" |  __  |  / _ \ | | | |  / _ \      \ \/  \/ /    / _ \  | '__| | |  / _` |" + "\n" +
                @" | |  | | |  __/ | | | | | (_) |      \  /\  /    | (_) | | |    | | | (_| |" + "\n" +
                @" |_|  |_|  \___| |_| |_|  \___/        \/  \/      \___/  |_|    |_|  \__,_|");

            Console.WriteLine("Learning Git Homework by Cobi Panti\n" +
                "Features include: Simple [C]alculator, [T]emperature Converter, and [P]rime Number Checker.\n" +
                "Type in [h] for help and [q] to quit.");

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
                        "[H]elp\n[Q]uit\nSimple [C]alculator\n[P]rime Number Checker\n[T]emperature Converter");
                }
                else if (order == "q")
                {
                    break;
                }
                else if (order == "p")
                {
                    new PrimeChecker();
                    Console.WriteLine("Welcome back to the Main Menu. Enter [h] for help\n");
                }
                else if (order == "t")
                {
                    new TempConvert();
                    Console.WriteLine("Welcome back to the Main Menu. Enter [h] for help\n");
                }
                else if (order == "c")
                {
                    new SimpleCalculator();
                    Console.WriteLine("Welcome back to the Main Menu. Enter [h] for help\n");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please type in [h] for help");
                }
            }
        }
    }
}

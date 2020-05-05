using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGit
{
    class PrimeChecker
    {

        public PrimeChecker()
        {
            Console.WriteLine("Please enter a number to check if its a prime number or not.");

            while (true)
            {

                string pInput = Console.ReadLine();
                Console.Clear();
                //Console.WriteLine(pInput);

                int num;
                bool canConvert = int.TryParse(pInput, out num);


                if (canConvert)
                {
                    bool isPrime = true;
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine($"{num} is a prime number.\n");
                    }
                    else
                    {
                        Console.WriteLine($"{num} is NOT a prime number.\n");
                    }
                }

                else
                {
                    string pOrder = pInput.ToLower();
                    if(pOrder == "q" || pOrder == "quit")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid input.\n");
                    }
                }
            }
        }
    }
}

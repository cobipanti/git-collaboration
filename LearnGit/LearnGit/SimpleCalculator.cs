using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGit
{
    class SimpleCalculator
    {

        public SimpleCalculator()
        {
            double? memoryNum = null;

            Console.WriteLine("Welcome to the Simple Calculator.");
            Console.WriteLine("Write a character between [a]ddition, [s]ubtraction, [m]ultiplication, or [d]ivision.\n" +
                            "then enter two numbers seperated with a space. An example:\n" +
                            "a 23 759\n" +
                            "to calculate 23 + 759\n" +
                            "The answer will be saved in memory and you can use a command and a number to follow up on your calculation. An example:\n" +
                            "a 3 8\n" +
                            "11\n" +
                            "m 6\n" +
                            "66\n" +
                            "to multiply 3+8 by 6");

            while (true)
            {
                string cInput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(cInput);
                string[] cInputs = cInput.Split(' ');

                if (cInputs.Length == 3)
                {
                    char operation;
                    double num1;
                    double num2;
                    bool canConvert0 = char.TryParse(cInputs[0], out operation);
                    bool canConvert1 = double.TryParse(cInputs[1], out num1);
                    bool canConvert2 = double.TryParse(cInputs[2], out num2);

                    if (canConvert0 && canConvert1 && canConvert2)
                    {
                        if(operation == 'a')
                        {
                            memoryNum = num1 + num2;
                            Console.WriteLine(memoryNum);
                        }
                        else if(operation == 's')
                        {
                            memoryNum = num1 - num2;
                            Console.WriteLine(memoryNum);
                        }
                        else if(operation == 'm')
                        {
                            memoryNum = num1 * num2;
                            Console.WriteLine(memoryNum);
                        }
                        else if(operation == 'd')
                        {
                            memoryNum = num1 / num2;
                            Console.WriteLine(memoryNum);
                        }
                        else
                        {
                            Console.WriteLine("There could be an operation error.");
                        }
                    }
                }
                else if (cInputs.Length == 2)
                {
                    char operation;
                    double num1;
                    bool canConvert0 = char.TryParse(cInputs[0], out operation);
                    bool canConvert1 = double.TryParse(cInputs[1], out num1);

                    if(memoryNum != null)
                    {
                        if (canConvert0 && canConvert1)
                        {
                            if (operation == 'a')
                            {
                                memoryNum = memoryNum + num1;
                                Console.WriteLine(memoryNum);
                            }
                            else if (operation == 's')
                            {
                                memoryNum = memoryNum - num1;
                                Console.WriteLine(memoryNum);
                            }
                            else if (operation == 'm')
                            {
                                memoryNum = memoryNum * num1;
                                Console.WriteLine(memoryNum);
                            }
                            else if (operation == 'd')
                            {
                                memoryNum = memoryNum / num1;
                                Console.WriteLine(memoryNum);
                            }
                            else
                            {
                                Console.WriteLine("There could be an operation error.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Memory is null. Please use three parameters. Refer to the help command.");
                    }
                }
                else if (cInputs.Length == 1)
                {
                    string cOrder = cInputs[0];

                    if (cOrder == "h")
                    {
                        Console.WriteLine("Write a character between [a]ddition, [s]ubtraction, [m]ultiplication, or [d]ivision.\n" +
                            "then enter two numbers seperated with a space. An example:\n" +
                            "a 23 759\n" +
                            "to calculate 23 + 759\n" +
                            "The answer will be saved in memory and you can use a command and a number to follow up on your calculation. An example:\n" +
                            "a 3 8\n" +
                            "11\n" +
                            "m 6\n" +
                            "66\n" +
                            "to multiply 3+8 by 6");
                    }
                    else if (cOrder == "q")
                    {
                        break;
                    }
                    else if (cOrder == "c")
                    {
                        memoryNum = null;
                        Console.Clear();
                        Console.WriteLine("Answer cleared.");
                    }

                }

            }

        }


    }
}

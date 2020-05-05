using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGit
{
    class TempConvert
    {
        private double finalCel;
        private double finalFah;
        private double finalKel;

        public TempConvert()
        {
            Console.WriteLine("Type the letter of the unit you want to use\n" +
                "[C]elsius, [F]ahrenheit, or [K]elvin\n" +
                "followed by a space then a number. An example:\n" +
                "c 24\n" +
                "to convert 24 degrees celsius.\n" +
                "Type [q] to go back to the Main menu");
            while (true)
            {
                string tInput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(tInput);
                string[] tInputs = tInput.Split(' ');

                if (tInputs.Length == 2)
                {
                    double num;
                    char unit;
                    bool canConvert1 = double.TryParse(tInputs[1], out num);
                    bool canConvert0 = char.TryParse(tInputs[0], out unit);

                    if (canConvert1 && canConvert0)
                    {
                        if (unit == 'c')
                        {
                            fromCelsius(num);
                        }
                        else if (unit == 'f')
                        {
                            fromFahrenheit(num);
                        }
                        else if (unit == 'k')
                        {
                            fromKelvin(num);
                        }
                        else
                        {
                            Console.WriteLine("Error. There may be a unit error. Please type c, f, or k only.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error. There may be a unit or number error.");
                    }
                }
                else if (tInputs.Length == 1)
                {
                    string tOrder = tInputs[0];

                    if (tOrder == "h")
                    {
                        Console.WriteLine("Type the letter of the unit you want to use\n" +
                            "[C]elsius, [F]ahrenheit, or [K]elvin\n" +
                            "followed by a space then a number. An example:\n" +
                            "c 24\n" +
                            "to convert 24 degrees celsius.");
                    }
                    else if (tOrder == "q")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please refer to help by typing [h].");
                    }
                }
                else
                {
                    Console.WriteLine("Error. You may have entered an invalid command or too many parameters.");
                }
            }
        }

        private void fromCelsius(double cel)
        {
            finalFah = Math.Round(((cel * 9 / 5) + 32),3);
            finalKel = Math.Round((cel + 273.15),3);
            finalCel = Math.Round(cel,3);

            Console.WriteLine($"Celsius\t\t| {finalCel}");
            Console.WriteLine($"Fahrenheit\t| {finalFah}");
            Console.WriteLine($"Kelvin\t\t| {finalKel}");

        }

        private void fromFahrenheit(double fah)
        {
            finalCel = Math.Round(((fah - 32) * 5 / 9),3);
            finalKel = Math.Round((finalCel + 273.15),3);
            finalFah = Math.Round(fah);

            Console.WriteLine($"Fahrenheit\t| {finalFah}");
            Console.WriteLine($"Celsius\t\t| {finalCel}");
            Console.WriteLine($"Kelvin\t\t| {finalKel}"); 
        }

        private void fromKelvin(double kel)
        {
            finalCel = Math.Round((kel-273.15),3);
            finalFah = Math.Round(((finalCel * 9 / 5) + 32),3);
            finalKel = Math.Round(kel,3);

            Console.WriteLine($"Kelvin\t\t| {finalKel}");
            Console.WriteLine($"Celsius\t\t| {finalCel}");
            Console.WriteLine($"Fahrenheit\t| {finalFah}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam12
{
    class Program
    {
        static void Main(string[] args)
        {
             Assignment1();
           // FuelConsumption();
        }

        private static void Assignment1()
        {
            double fahrenheit, celsius;

            Console.WriteLine("Please input your number in Celcius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9) / 5 + 32;

            Console.WriteLine($"Your number in Fahrenheit: {fahrenheit}");

            Console.WriteLine();  /* Just to make an empty row for styling */

            double infahrenheit, incelsius;

            Console.WriteLine("Please input your number in Fahrenheit: ");
            infahrenheit = Convert.ToInt32(Console.ReadLine());

            incelsius = (infahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Your number in Celsius: {incelsius}");
            double convCelsius = (incelsius * 9) / 5 + 32;   // Converse Celsius to Fahrenheit again in order to substract both to see the difference! 

            if (fahrenheit > convCelsius)
            {
                var sum1 = fahrenheit - convCelsius;
                Console.WriteLine($"Your number {fahrenheit} is by {sum1} (Fahrenheit) bigger than {incelsius}");
            }
            else if (convCelsius > fahrenheit)
            {
                var sum2 = convCelsius - fahrenheit;
                Console.WriteLine($"Your number {incelsius} is by {sum2} (Fahrenheit) bigger than {fahrenheit}");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }

        }

        private static void FuelConsumption()
        {
            double lt, ml; /* lt (Liters) , ml (Miles) */
            Console.WriteLine("Welcome to US/EU conversion of mpg and L/100km!");

            Console.WriteLine("Please input Liters per 100km: ");
            lt = Convert.ToDouble(Console.ReadLine());
            ml = (235.2145 / lt);
            Console.WriteLine($"The conversion to Miles per Gallon is: {ml}");

            double mpg, lpk; /* (mpg) Miles per Gallon, (lpk) Liters per 100km. */

            Console.WriteLine("Please input Miles per Gallon: ");
            mpg = Convert.ToDouble(Console.ReadLine());
            lpk = (235.2145 / mpg);
            Console.WriteLine($"The conversion to Liters per 100km is: {lpk}");

        }






    }
}

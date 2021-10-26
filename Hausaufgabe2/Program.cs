using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            // First Function 



            Console.WriteLine();
            Console.WriteLine();

            var num = 5 * 666;
            Console.WriteLine($"The result is {num}.");
            // Second function 

            Console.WriteLine();
            Console.WriteLine();


            int num1 = -1 + 4 * 6;
            int num2 = (35 + 5) % 7;
            int num3 = 14 + -4 * 6 / 11;
            int num4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine($"{num1},{ num2},{num3},{num4}"); 
            

        }

    }

}


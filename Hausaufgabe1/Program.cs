using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausaufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write three numbers for the multiplication: ");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = num1 * num2 * num3;
            Console.WriteLine($"The result from the multiplication is  {num4}");
            // Task 4

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please add a number to between 1-10 to multiply it by 4:  ");
            int zahl1 = 4;
            int Eingabe = int.Parse(Console.ReadLine());
            int Ausgabe = zahl1 * Eingabe;
            Console.WriteLine($"Your result: {Ausgabe}");
            // Task 5

            Console.WriteLine();
            Console.WriteLine();

            var nani = new int[] { 1, 2, 3, 4, 5 };
            double hi = Queryable.Average(nani.AsQueryable()); // Dieser Befehl findet die durchschnittliche Zahl
            Console.WriteLine($"The average of these numbers is: {hi}");
              // Task 6



        }
    }
}

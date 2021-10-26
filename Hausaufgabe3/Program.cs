
using System;

namespace Probieren
{
    class Program
    {

        static void Main(string[] args)
        {
        //  Rectangle2();
        // Rectangle1();
        //   Numbers();
        FormValidation();
        }
       
           private static void Numbers()
            {
                Console.Write("Please enter your height in centimeters: ");
                int height = int.Parse(Console.ReadLine());

                if (height > 190)
                {
                    Console.WriteLine("Basketball");

                }
                else if (height > 175)
                {
                    Console.WriteLine("Athletics");
                }
                else
                {
                    Console.WriteLine("Horse riding");
                }
            }
        private static void Rectangle2()
        {
            Console.WriteLine("Num 1: ");
            int A01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Num 2: ");
            int A02 = int.Parse(Console.ReadLine());

            Console.WriteLine("Num 3: ");
            int A03 = int.Parse(Console.ReadLine());

            Console.WriteLine("Num 4: ");
            int A04 = int.Parse(Console.ReadLine());

            Console.WriteLine("Num 5: ");
            int A05 = int.Parse(Console.ReadLine());

            Console.WriteLine("Num 6: ");
            int A06 = int.Parse(Console.ReadLine());

            Console.WriteLine("Num 7: ");
            int A07 = int.Parse(Console.ReadLine());

            Console.WriteLine("Num 8: ");
            int A08 = int.Parse(Console.ReadLine());

            long sum = 0;
            int count = 0;

            if (10 <= A01 && A01 <= 20)
            {
                count++;
                sum = sum + A01;

            }

            if (10 <= A02 && A02 <= 20)
            {
                count++;
                sum = sum + A02;

            }
            if (10 <= A03 && A03 <= 20)
            {
                count++;
                sum = sum + A03;

            }
            if (10 <= A04 && A04 <= 20)
            {
                count++;
                sum = sum + A04;

            }
            if (10 <= A05 && A05 <= 20)
            {
                count++;
                sum = sum + A05;

            }
            if (10 <= A06 && A06 <= 20)
            {
                count++;
                sum = sum + A06;

            }
            if (10 <= A07 && A07 <= 20)
            { 
                count++;
                sum = sum + A07;

            }
            if (10 <= A08 && A08 <= 20) ;
            {
                count++;
                sum = sum + A08;

            }
            Console.WriteLine("Count of number between 10 and 20 is: " + count);
            Console.WriteLine("Sum of number between 10 and 20 is: " + sum);

        }
         
        private static void Rectangle1()
        {
              Console.WriteLine("Side A: ");
             int A = int.Parse(Console.ReadLine());

             Console.WriteLine("Side B: ");
             int B = int.Parse(Console.ReadLine());

             Console.WriteLine("Side C: ");
             int C = int.Parse(Console.ReadLine());

           if ((A == B) || (B == C) || (A == C))
             {
                 Console.WriteLine("There are two equal sides. ");

             }
             else
             {
                 Console.WriteLine("There are no equal sides!");
             } 

             if (A == B && B == C)
             {
                 Console.WriteLine("There are 3 equal sides.");
                 Console.WriteLine("A,B and C are equal");
             }

             else if (A == B)
             {
                 Console.WriteLine("A and B are equal.");
             }

             else if (B == C)
             {
                 Console.WriteLine("B and C are equal");
             }
             else if (A == C)
             {
                 Console.WriteLine("A and C are equal");
             }
           
        }

        private static void FormValidation()
        {
            Console.WriteLine("Please enter your first Name: ");
            var firstName = (Console.ReadLine());
            Console.WriteLine("Please enter your last Name: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Please enter your birth date: ");
            var dateOfBirth = Console.ReadLine();
            Console.WriteLine("Please enter your student number: ");
            var studentNumber = Console.ReadLine();


            if (firstName == string.Empty)
            {
                Console.WriteLine("I'm sorry, but your name is not valid.");
            }
            else if (firstName.Length > 100)
            {
                Console.WriteLine("I'm sorry but your name is not valid.");
            }
            else
            {
                Console.WriteLine($"Greetings Mr. {firstName} {lastName}");
            }

            Console.WriteLine();

            if (lastName ==string.Empty)
            {
                Console.WriteLine("I'm sorry, but your name is not valid.");
            }
            else if (firstName.Length > 100)
            {
                Console.WriteLine("I'm sorry but your name is not valid.");
            }
            else
            {
                Console.WriteLine($"Greetings Mr. {firstName} {lastName}");
            }

            Console.WriteLine();
            
            if (dateOfBirth < 00.00.1921)
            {
                Console.WriteLine("Happy Birthday");

            }

        }

    }
    }


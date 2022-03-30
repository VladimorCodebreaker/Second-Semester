using System;
namespace DSandAlgo_8.Lecture
{
	public class Fibbonaci
	{
		public static int FindFibonacci(double n)
        {
			if (n == 1 || n == 2)
            {
				return 1;
            }
			else
            {
				return FindFibonacci(n - 1) + FindFibonacci(n - 2);
            }
			
        }

		public static void Run()
        {
			Console.WriteLine(FindFibonacci(10));
			Console.WriteLine(FindFibonacci(50));
        }
	}
}


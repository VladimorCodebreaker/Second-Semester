using System;
namespace DSandAlgo_8.Lecture
{
	public class Fibonacci_Prime
	{
		public static int Method(int n)
        {
			if (n == 1 || n == 2)
            {
				return 1;
            }
			else
            {
				return Method(n - 1) + Method(n - 2);
            }
        }
	}
}


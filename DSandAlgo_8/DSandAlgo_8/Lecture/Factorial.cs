using System;
using System.Linq;

namespace DSandAlgo_8.Lecture
{
	public class Factorial
	{
		public static int CalculateFactorial(int n)
        {
			if (n == 0)
            {
				return 1;
            }
			else
            {
				return n * CalculateFactorial(n - 1);
            }
        }
	}
}


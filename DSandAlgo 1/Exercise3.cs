using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_1
{
    class Exercise3
    {
        public long Calcsum(int[,] matrix, int row) // O(n*m), O(n)
        {
            long sum = 0; // O(1)
            for (int col = 0; col < matrix.GetLength(0); col++) // O(n)
            { 
                sum += matrix[row, col]; // Adding to a variable is O(1) but it seems we have something with recursion here ??
            }
            if (row + 1 < matrix.GetLength(1)) // O(1)
            { 
                sum += Calcsum(matrix, row + 1);
            }
            Console.WriteLine(Calcsum(matrix, 0)); // O(1)

            return sum;
        }
        // Time Complexity O(n)
        // Explanation:
        // This is a bit tricky since I don't really understand the code here. 
        // Nevertheless the first "for loop" loops through the first dimension of the array "GetLength(0)"
        // then it seems to add the row and column for each iteration
        // In the if statement it peeks into the second dimension and adds the next row (row + 1)
        // If we don't care about the if statement since it doesn't loop through the matrix, the complexity should be constant
        // Thus I conclude that the time complexity is O of n, linear time complexity
    }
}

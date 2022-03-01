using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_1
{
    class Exercise2
    {
        public long Complexity(int[,] matrix) // O(m*n)
        {
            long count = 0; // O(1)
            for (int row = 0; row < matrix.GetLength(0); row++) // O(n)
            {
                if (matrix[row, 0] % 2 == 0) // O(1)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++) // O(m)
                    {
                        if (matrix[row, col] > 0) // O(1)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        // Time Complexity is      O((m)+(O1) * (n)+(O1))  or in short   O(m*n)
        // Explanation:
        // Two dimensional arrays have a time complexity of m*n since we have for the first dimension m and for the second n. 
        // "If" statements have a constant time complexity O(1)
        // Since in the first for loop we loop through the first dimension it has a time complexity of O(n)
        // In the second for loop it's O(m) for the second dimension.
        // In the end we have to multiply both to get the result 


        public static void Matrix()
        {
            int[,] arr2D_i = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //reading all the elements through for loop
            for (int i = 0; i < arr2D_i.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D_i.GetLength(1); j++)
                {
                    Console.Write(arr2D_i[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

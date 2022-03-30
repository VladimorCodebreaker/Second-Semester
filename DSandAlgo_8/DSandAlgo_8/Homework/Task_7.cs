using System;
namespace DSandAlgo_8.Homework
{
    public class Task_7
    {
        private static void Path(int[,] matrix, int n)
        {
            bool[,] visited = new bool[n, n];
            bool flag = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 1 && !visited[i, j])
                    {
                        if (Path(matrix, i, j, visited))
                        {
                            flag = true;
                            break;
                        }
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Boundaries(int i, int j, int[,] matrix)
        {
            if (i >= 0 && i < matrix.GetLength(0) && j >= 0 && j < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        public static bool Path(int[,] matrix, int i, int j, bool[,] visited)
        {
            if (Boundaries(i, j, matrix) && matrix[i, j] != 0 && !visited[i, j])
            {
                visited[i, j] = true;

                if (matrix[i, j] == 2)
                {
                    return true;
                }

                bool up = Path(matrix, i - 1, j, visited);

                if (up)
                {
                    return true;
                }

                bool left = Path(matrix, i, j - 1, visited);

                if (left)
                {
                    return true;
                }

                bool down = Path(matrix, i + 1, j, visited);

                if (down)
                {
                    return true;
                }

                bool right = Path(matrix, i, j + 1, visited);

                if (right)
                {
                    return true;
                }
            }
            return false; // no path
        }

        public static void Run()
        {
            int[,] matrix =
            {
                { 2, 3, 0, 1},                   // 1 - Beginning
                { 3, 0, 0, 3},                   // 2 - End
                { 3, 3, 0, 3 },                  // 0 - Boundary
                { 0, 3, 3, 3 }                   // 3 - Free zone
            };

            Path(matrix, 4);
        }
    }
}


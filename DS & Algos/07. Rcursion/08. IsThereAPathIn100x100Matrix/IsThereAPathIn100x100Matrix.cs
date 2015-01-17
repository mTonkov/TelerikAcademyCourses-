using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IsThereAPathIn100x100Matrix
{/*Modify the above program to check whether a path exists between two cells without finding all possible paths. 
  * Test it over an empty 100 x 100 matrix.
*/
    class IsThereAPathIn100x100Matrix
    {
        private static char[,] matrix;
        public static void Main()
        {
            matrix = new char[100, 100];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = ' ';
                }
            }

            FindPaths(4, 0, 55, 75);
        }

        private static void FindPaths(int startRow, int startCol, int endRow, int endCol)
        {
            if (startRow < 0 || startRow >= matrix.GetLength(0) || startCol < 0 || startCol >= matrix.GetLength(1))
            {
                return;
            }
            else if (startRow == endRow && startCol == endCol)
            {
                PrintPath(matrix);
            }
            else if (matrix[startRow, startCol] != ' ')
            {
                return;
            }

            matrix[startRow, startCol] = '>';
            FindPaths(startRow - 1, startCol, endRow, endCol);
            FindPaths(startRow, startCol + 1, endRow, endCol);
            FindPaths(startRow + 1, startCol, endRow, endCol);
            FindPaths(startRow, startCol - 1, endRow, endCol);
            matrix[startRow, startCol] = ' ';
        }

        private static void PrintPath(char[,] matrix)
        {
            Console.WriteLine("Found the path:");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

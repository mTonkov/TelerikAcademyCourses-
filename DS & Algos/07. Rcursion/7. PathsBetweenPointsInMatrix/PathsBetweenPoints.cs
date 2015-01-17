using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PathsBetweenPointsInMatrix
{/*We are given a matrix of passable and non-passable cells. 
  * Write a recursive program for finding all paths between two cells in the matrix.
*/
    public class PathsBetweenPoints
    {
       private static char[,] matrix = new char[,]{
                {' ',' ',' ','#',' ',' ',' '},
                {' ','#',' ',' ',' ','#',' '},
                {' ','#',' ','#',' ',' ',' '},
                {' ','#',' ','#',' ','#',' '},
                {' ','#',' ',' ',' ','#','$'}
            };

        public static void Main()
        {
            FindPaths(4, 0, 4, 6);
        }

        private static void FindPaths(int startRow, int startCol, int endRow, int endCol)
        {
            if (startRow < 0 || startRow >= matrix.GetLength(0) || startCol < 0 || startCol >= matrix.GetLength(1))
            {
                return;
            }

            if (startRow == endRow && startCol == endCol)
            {
                PrintPath(matrix);
            }

            if (matrix[startRow,startCol] != ' ')
            {
                return;
            }

            matrix[startRow, startCol] = '>';
            FindPaths(startRow - 1, startCol, endRow, endCol);
            FindPaths(startRow, startCol+ 1, endRow, endCol);
            FindPaths(startRow + 1, startCol, endRow, endCol);
            FindPaths(startRow, startCol- 1, endRow, endCol);
            matrix[startRow, startCol] = ' ';
        }

        private static void PrintPath(char[,] matrix)
        {
            Console.WriteLine("Found the path:");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]+" ");
                }
                Console.WriteLine();
            }
        }

    }
}

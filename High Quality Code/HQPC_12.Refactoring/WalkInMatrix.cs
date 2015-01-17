namespace WalkingInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WalkInMatrix
    {
        public static void Main()
        {
            Console.WriteLine("Enter the size of the matrix:");
            string input = Console.ReadLine();
            int matrixSize = 0;

            while (!int.TryParse(input, out matrixSize) || matrixSize > 100 || matrixSize < 1)
            {
                Console.WriteLine("Please enter a number in the range [1, 100]");
                input = Console.ReadLine();
            }

            int[,] matrix = new int[matrixSize, matrixSize];
            int cellValue = 1;
            int row = 0, 
                col = 0;

            while (Matrix.FindAvailableCell(matrix, out row, out col))
            {
                int directionX = 1;
                int directionY = 1;
                while (true)
                {
                    matrix[row, col] = cellValue;
                    cellValue++;

                    if (Matrix.IsAnyDirectionPossible(matrix, row, col))
                    {
                        while (row + directionX >= matrixSize || row + directionX < 0 || col + directionY >= matrixSize || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                        {
                            Matrix.ChangeDirection(ref directionX, ref directionY);
                        }
                    }
                    else
                    {
                        break;
                    }

                    row += directionX;
                    col += directionY;
                }
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}

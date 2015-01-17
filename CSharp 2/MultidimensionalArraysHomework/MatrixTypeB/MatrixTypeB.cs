using System;
//Write a program that fills and prints a matrix of size (n, n)

class MatrixTypeB
{
    static void Main(string[] args)
    {
        Console.WriteLine("Size of matrix b) ?:");
        int n = int.Parse(Console.ReadLine());
        int cell = 1;
        int[,] matrix = new int[n, n];

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = cell;
                    cell++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = cell;
                    cell++;
                }
            }
        }

        for (int row = 0; row < n; row++) //Print Matrix
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("\t" + matrix[row, col]);
                //Console.Write(matrix[row, col].ToString().PadRight(3));

            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

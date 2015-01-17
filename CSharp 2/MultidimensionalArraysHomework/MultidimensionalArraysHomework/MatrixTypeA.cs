using System;
//Write a program that fills and prints a matrix of size (n, n)
class MatrixTypeA
{
    static void Main(string[] args)
    {
        Console.WriteLine("Size of matrix a) ?:");
        int n = int.Parse(Console.ReadLine());
        int cell = 1;
        int[,] matrix = new int [n,n];

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = cell;
                cell++;
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


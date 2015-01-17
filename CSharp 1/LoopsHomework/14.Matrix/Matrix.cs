
// * Write a program that reads a positive integer number N (N < 20) from console and outputs in the console 
// the numbers 1 ... N numbers arranged as a spiral.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the matrix");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int startRow = 0;
            int endRow = n - 1;
            int startCol = 0;
            int endCol = n - 1;
            int counter = 1;

            while (counter <= n*n)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    matrix[startRow, col] = counter;
                    counter++;
                }

                startRow++;

                for (int row = startRow; row <= endRow; row++)
                {
                    matrix[row, endCol] = counter;
                    counter++;
                }

                endCol--;

                for (int col = endCol; col >= startCol; col--)
                {
                    matrix[endRow, col] = counter;
                    counter++;
                }

                endRow--;

                for (int row = endRow; row >= startRow; row--)
                {
                    matrix[row, startCol] = counter;
                    counter++;
                }

                startCol++;                
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3} ",matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}

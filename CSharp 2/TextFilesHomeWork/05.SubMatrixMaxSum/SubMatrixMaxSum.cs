using System;
using System.IO;
//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file

namespace SubMatrixMaxSum
{
    class SubMatrixMaxSum
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = 4; 
            // the main task is to read the numbers in the files, so I directly read the example, without asking the user for matrix size
            StreamReader reader = new StreamReader(@"..\..\matrix.txt");
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            int row = 0;
            string line = reader.ReadLine();
            string[] numbersInLine = new string[sizeOfMatrix];

            while (line != null) //reading the file and storing the matrix
            {
                numbersInLine = line.Split(' ');
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    matrix[row, col] = int.Parse(numbersInLine[col]);
                }
                row++;
                line = reader.ReadLine();
            }
            reader.Close();

            int maxSum = 0;
            int sum = 0;

            for (row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    sum = matrix[row, col] + matrix[row+1, col] + matrix[row, col+1] + matrix[row+1, col+1];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            StreamWriter write = new StreamWriter(@"..\..\maxSum.txt");
            using (write)
            {
                write.WriteLine(maxSum);
            }
        }
    }
}

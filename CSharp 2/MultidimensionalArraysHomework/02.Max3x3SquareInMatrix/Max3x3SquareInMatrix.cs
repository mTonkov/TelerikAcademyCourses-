using System;
//Write a program that reads a rectangular matrix of size N x M and 
//finds in it the square 3 x 3 that has maximal sum of its elements

class Max3x3SquareInMatrix
{
    static void Main(string[] args)
    {
        int[,] matrix = {
            {5,6,8,4,9,5,3,4,1},
            {6,0,4,9,7,5,2,4,6},
            {2,4,7,4,1,2,3,1,2},
            {3,6,5,9,9,9,1,7,9},
            {6,5,4,8,9,6,5,6,3},
            {7,8,4,0,3,0,4,1,2},
            };
        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;
        int currentSum;

        for (int row = 0; row < matrix.GetLength(0) - 3; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 3; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                             matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                             matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }


        for (int row = 0; row < matrix.GetLength(0); row++) //print matrix
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col].ToString().PadRight(2));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("The square with maximum sum in the above matrix is \n{0} \nand consists of :", bestSum);

        for (int row = bestRow; row < bestRow + 3; row++) //print max sum square
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write(matrix[row, col].ToString().PadRight(2));
            }
            Console.WriteLine();
        }
    }
}

using System;
//Write a program that fills and prints a matrix of size (n, n)

class MatrixTypeD
{
    static void Main(string[] args)
    {
        Console.WriteLine("Size of matrix c) ?:");
        int n = int.Parse(Console.ReadLine());
        int cell = 1;
        int[,] matrix = new int[n, n];
        int startRow = 0;
        int startCol = 0;
        int endRow = n - 1;
        int endCol = n - 1;

        while (cell <= n * n)
        {
            int row = startRow; // coordinates of the starting point
            int col = startCol;

            for (row = startRow; row <= endRow; row++) // starts filling the matrix from top left->down
            {
                matrix[row, col] = cell;
                cell++;
            }
            startCol++; // changes the border of the sub-matrix which is left for filling
            row--; // helps me keep the correct value of the "row" or "col" coordinate of the matrix, 
            //where the "cell" value will be kept

            for (col = startCol; col <= endCol; col++)//fills the matrix from bottom left->right
            {
                matrix[row, col] = cell;
                cell++;
            }
            endRow--;
            col--;

            for (row = endRow; row >= startRow; row--)//fills the matrix from bottom right->up
            {
                matrix[row, col] = cell;
                cell++;
            }
            endCol--;
            row++;

            for (col = endCol; col >= startCol; col--)//fills the matrix from top right->left
            {
                matrix[row, col] = cell;
                cell++;
            }
            startRow++;
            col++;
        }

        for (int row = 0; row < n; row++) //Print Matrix
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col].ToString().PadRight(4));
            }
            Console.WriteLine();
            //Console.WriteLine();
        }
    }
}


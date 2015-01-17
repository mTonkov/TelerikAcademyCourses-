using System;
//Write a program that fills and prints a matrix of size (n, n)

class MatrixTypeC
{
    static void Main(string[] args)
    {
        Console.WriteLine("Size of matrix c) ?:");
        int n = int.Parse(Console.ReadLine());
        int cell = 1;
        int startRow = n - 1; //determines the row where the matrix will start
        int startCol = 0; //determines the column where the matrix will start
        int[,] matrix = new int[n, n];
        int r;
        int c;

        while (startRow <= n-1 && startCol <= n - 1)
        {//this point is the opposite of the starting point and there should be the end of the filling

            r = startRow;
            c = startCol;

            while (r <= n - 1 && c <= n - 1) 
            {// Fills the matrix diagonally, starting from a cell on the first column or row
                matrix[r, c] = cell;
                cell++;
                r++;
                c++;
            }

            // Filling the matrix diagonally starts from the last row of the first column
            if (startRow > 0 && startCol == 0)// each diagonal starts from matrix[row-1, column]
            {
                startRow--;
            }
            else if (startRow == 0 && startCol >= 0)//when row==0, column increases by 1 on each iteration
            {
                startCol++;
            }
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

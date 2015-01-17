using System;
//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 

class LongestSequenceInMatrix
{
    static void Main(string[] args)
    {
        string[,] matrix = {
                               {"ha","fifi","ho","hi"},
                               {"fo","ha","hi","xx"},
                               {"xxx","ho","ha","xx"}
                           };

        //string[,] matrix = {
        //                       {"s","qq","s"},
        //                       {"pp","pp","s"},
        //                       {"pp","qq","s"}
        //                   };

        int bestLength = 0;
        string bestElement = null;
        string sequenceType = null; //diagonal, horizontal or vertical
        int matrixHeight = matrix.GetLength(0);
        int matrixWidth = matrix.GetLength(1);

        for (int row = 0; row < matrixHeight; row++)
        {
            for (int col = 0; col < matrixWidth; col++)
            {
                int counter = 1;

                //checks for sequence horizontally(on the rows) if there is any
                if (col + 1 < matrixWidth)//the condition prevents IndexOutOfRange Exception
                {
                    while (matrix[row, col] == matrix[row, col + 1]) 
                    /* the two "if"s can be removed because they have the same purpose, and can 
                    * be put in the "while", but I think it is easier to read written on stages, 
                    * despite the more code to read*/
                    {
                        counter++;
                        col++;
                        if (!(col + 1 < matrixWidth))//the condition prevents IndexOutOfRange Exception and stops 
                        {
                            break;
                        }
                    }
                }
                if (counter > bestLength)
                {
                    bestLength = counter;
                    bestElement = matrix[row, col];
                    sequenceType = "horizontally";
                }

                if (row + 1 < matrixHeight && col + 1 < matrixWidth)
                {
                    while (matrix[row, col] == matrix[row + 1, col + 1])
                    //checks for sequence on diagonal top left-> bottom right
                    {
                        counter++;
                        row++;
                        col++;

                        if (!(row + 1 < matrixHeight && col + 1 < matrixWidth))
                        // if there is any danger of OutOfRange Exception -> break
                        {
                            break;
                        }
                    }
                }
                if (counter > bestLength)
                {
                    bestLength = counter;
                    bestElement = matrix[row, col];
                    sequenceType = "diagonally top left-> bottom right";
                }

                if (row + 1 < matrixHeight)
                {
                    while (matrix[row, col] == matrix[row + 1, col])
                    //checks for sequence vertically(on the col), if any
                    {
                        counter++;
                        row++;

                        if (!(row + 1 < matrixHeight))
                        {
                            break;
                        }
                    }
                }
                if (counter > bestLength)
                {
                    bestLength = counter;
                    bestElement = matrix[row, col];
                    sequenceType = "vertically";
                }

                if (row - 1 >= 0 && col + 1 < matrixWidth)
                {
                    while (matrix[row, col] == matrix[row - 1, col + 1])
                    //checks for sequence on diagonal bottom left-> top right
                    {
                        counter++;
                        row--;
                        col++;

                        if (!(row - 1 >= 0 && col + 1 < matrixWidth))
                        // if there is any danger of OutOfRange Exception -> break
                        {
                            break;
                        }
                    }
                }
                if (counter > bestLength)
                {
                    bestLength = counter;
                    bestElement = matrix[row, col];
                    sequenceType = "diagonally bottom left -> top right";
                }
            }
        }


        for (int row = 0; row < matrix.GetLength(0); row++) // print matrix
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }

        //print longest sequence
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Longest sequence in the matrix has the symbol\n \"{0}\" \n with {1} occurencies \"{2}\"",
                            bestElement, bestLength, sequenceType);
    }
}

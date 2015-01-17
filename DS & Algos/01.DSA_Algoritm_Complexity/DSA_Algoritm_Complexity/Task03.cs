using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Algoritm_Complexity
{
    class Task03
    {//* What is the expected running time of the following C# code? Explain why.
        long CalcSum(int[,] matrix, int row)
        {
            long sum = 0;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                sum += matrix[row, col]; 
            }
            if (row + 1 < matrix.GetLength(1))
                sum += CalcSum(matrix, row + 1);
            return sum;
        }
        // Console.WriteLine(CalcSum(matrix, 0));
        /*
         First of all, I think there is a mistake with the naming - in the for-loop 'col' is used to iterate over the matrix rows (matrix.GetLength(0)) and in the if-clause (row + 1 < matrix.GetLength(1)). 
         * Of course, if the number of rows and cols is equal, there won't be a problem.
         * About complexity, the function iterates over the columns of the row that is passed as parameter 
         * and then recursively increments the row to iterate to the last one.
         * The complexity depends on the row that is passed, which in the worst case is 0, 
         * and the function will iterate over the whole matrix which means quadratic complexity (N*M) or (N*N)
         */
    }
}

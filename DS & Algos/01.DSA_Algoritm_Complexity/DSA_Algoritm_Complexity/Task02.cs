using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Algoritm_Complexity
{
    class Task02
    {   /*What is the expected running time of the following C# code? Explain why.*/
        long CalcCount(int[,] matrix)
        {
            long count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] > 0)
                        {
                            count++; 
                        }
                    }
                }
            }
            return count;
        }/*
          *There is a for-loop over a matrix's rows, where if the first digit on the row is EVEN, 
          * a nested for-loop is started iterating on the row. 
          * The worst case would be if each row starts with an EVEN number,
          * which means that the inner loop will be started 'N'(number of rows) times and 
          * the nested loop will iterate on the number of columns 'M'. 
          * So, algoritm's complexity is (N*M), which is a quadratic complexity. 
          * (N*M) can be represented as N*(C*N), where C is a constant - for example:
          * matrix with 4 rows and 6 columns, would make complexity of 4*6 = 4*(4*1.5)
          */
    }
}

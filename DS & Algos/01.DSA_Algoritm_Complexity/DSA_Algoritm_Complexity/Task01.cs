using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Algoritm_Complexity
{
    class Task01
    {/* What is the expected running time of the following C# code? Explain why. Assume the array's size is n.*/
        long Compute(int[] arr)
        {
            long count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int start = 0, end = arr.Length - 1;
                while (start < end)
                {
                    if (arr[start] < arr[end])
                    { 
                        start++; 
                        count++; 
                    }
                    else
                    {
                        end--;
                    }
                }
            }
            return count;
        }
    }
}
/* 
 The current algoritm is comprised of two loops iteratin from 0 to arr.Length - 1.
 The nested while-loop makes the same iterations as the for-loop, and it does it for each iteration of the for-loop.
 Both loops iterate over the array's length of N elements. 
 So, algoritm's complexity (N*N), which is also known as quadratic complexity
 */

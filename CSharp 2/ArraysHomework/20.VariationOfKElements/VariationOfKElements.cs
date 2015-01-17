using System;
/*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. */

class VariationOfKElements
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int rows = n;

        for (int i = 1; i < k; i++)
        {
            rows *= n;
        }

        int[] arr = new int[k];

        for (int i = 0; i < k; i++)
        {
            arr[i] = 1;
        }

        for (int row = 0; row < rows; row++)
        {
            for (int i = 1; i <= n; i++)
            {
                arr[k - 1] = i;
                Console.WriteLine(string.Join(" ", arr));
            }

            int stop = 0;
            for (int index = 0; index < k; index++)
            {
                if (arr[index] >= n)
                {
                    stop++;
                }
                if (stop == k)
                {
                    Environment.Exit(0);
                }
            }

            for (int j = k-1; j > 0; j--)
            {
                if (j + 1 < k && arr[j + 1] == n)
                {
                    arr[j] = arr[j] + 1;
                    //if (j + 2 < k && arr[j + 2] == n)
                    //{
                        arr[j + 1] = 0;
                    //}
                    //else
                    //{
                    //    arr[j + 1] = 1;
                    //}
                }
            }
        }
    }
}


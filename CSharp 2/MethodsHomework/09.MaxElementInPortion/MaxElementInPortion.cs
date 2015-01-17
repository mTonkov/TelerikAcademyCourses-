using System;
using System.Collections.Generic;
//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

namespace MaxElementInPortion
{
    class MaxElementInPortion
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 4, 5, 6, 3, 5, 2, 4, 9, 8, 6, 1, 2, 4, 7, 9, 8, 6, 5, 2, 7, 3 };
                                    // First Part of Task
            //Console.WriteLine("Please enter index to start searching for max element");
            //int inputIndex = int.Parse(Console.ReadLine());

            //if (inputIndex >= arrayOfNumbers.Length || inputIndex < 0)
            //{
            //    Console.WriteLine("Your input is out of the array!");
            //}
            //else
            //{
            //    Console.WriteLine(MaxElementInPartOfArray(arrayOfNumbers, inputIndex));
            //}

                            //Second Part of Task
            Console.WriteLine("Array in Ascending order:");
            AscendingSort(arrayOfNumbers);
            Console.WriteLine();
            
            Console.WriteLine("Array in Descending order:");
            DescendingSort(arrayOfNumbers);
        }

        static int MaxElementInPartOfArray(int[] array, int index)
        {
            int max = 0;
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static void DescendingSort(int[] array)
        {
            int[] arrayToSort = (int[])array.Clone();//creating a copy of the initial array to protect the original data
            List<int> descendingArray = new List<int>();

            int max = 0; // will keep the max value, which is left in the array and will be added to the List
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                max = MaxElementInPartOfArray(arrayToSort, 0); // takes the max element in the initial array
                int indexOfMax = Array.IndexOf(arrayToSort, max); // takes the index of the max element in the array
                Array.Clear(arrayToSort, indexOfMax, 1);    // sets the max, which is already taken, 
                                                            // to '0' to exlude that value from the search for max value
                descendingArray.Add(max); // assign each of the left max values to the List
            }
            Console.WriteLine(string.Join(", ", descendingArray));
        }

        static void AscendingSort(int[] array)
        {
            int[] arrayToSort = (int[])array.Clone();//creating a copy of the initial array to protect the original data
            List<int> descendingArray = new List<int>();

            int max = 0; // will keep the max value, which is left in the array and will be added to the List
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                max = MaxElementInPartOfArray(arrayToSort, 0); // takes the max element in the initial array
                int indexOfMax = Array.IndexOf(arrayToSort, max); // takes the index of the max element in the array
                Array.Clear(arrayToSort, indexOfMax, 1);    // sets the max, which is already taken, 
                                                            // to '0' to exlude that value from the search for max value
                descendingArray.Add(max); // assign each of the left max values to the List
            }
            descendingArray.Reverse();
            Console.WriteLine(string.Join(", ", descendingArray));
        }
    }
}

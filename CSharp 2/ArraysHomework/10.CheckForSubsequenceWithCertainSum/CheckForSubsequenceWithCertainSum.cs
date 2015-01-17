using System;
using System.Collections.Generic;
//Write a program that finds in given array of integers a sequence of given sum S (if present)
class CheckForSubsequenceWithCertainSum
{
    static void Main(string[] args)
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 8, 3 };
        int wantedSum = 11;
        int currentSum = 0;
        List<int> wantedSequence = new List<int>();

            // Made this way, the program should print every sequence with the wanted sum
        for (int i = 0; i < array.Length - 1; i++)
        {   // the program goes through the array and starts summing from every index to the end
            currentSum = array[i];
            wantedSequence.Add(array[i]);
            for (int j = i + 1; j < array.Length; j++)
            {
                currentSum += array[j]; //adds to the sum every element after the one which has started the sequence
                wantedSequence.Add(array[j]);

                if (currentSum == wantedSum)
                {
                    Console.Write(string.Join(", ", wantedSequence));
                    Console.WriteLine(" => {0}", wantedSum);
                    break;
                }
                else if (currentSum > wantedSum)
                {
                    break;
                }
            }
            currentSum = 0;
            wantedSequence.Clear();
        }
    }
}

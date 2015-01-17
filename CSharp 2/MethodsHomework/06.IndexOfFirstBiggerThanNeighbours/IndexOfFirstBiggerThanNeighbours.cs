using System;
using BiggerThanNeighbours;
//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
//if there’s no such element.
//Use the method from the previous exercise.

class IndexOfFirstBiggerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 4, 5, 6, 3, 5, 2, 4, 9, 8, 6, 1, 2, 4, 7, 9, 8, 6, 5, 2, 7, 3 };

            for (int i = 1; i < arrayOfNumbers.Length-1; i++) 
                // 'i' in the interval { 1...arrayOfNumbers.Length-1 } ensures that there are neighbour numbers in each iteration
            {
                if ( IsBiggerThanNeighbours.CompareNumbers(arrayOfNumbers, i, i - 1, i + 1) ) 
                     //the task requires usage of the method from the previous exercise
                {
                    Console.WriteLine("Number {0} is the first in the array, bigger than its neighbours and is on index \"{1}\"", arrayOfNumbers[i], i);
                    break;
                }
            }
        }
    }

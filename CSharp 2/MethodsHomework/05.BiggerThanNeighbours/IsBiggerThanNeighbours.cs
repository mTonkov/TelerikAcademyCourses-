using System;
//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

namespace BiggerThanNeighbours
{
    public class IsBiggerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 4, 5, 6, 3, 5, 2, 4, 9, 8, 6, 1, 2, 4, 7, 9, 8, 6, 5, 2, 7, 3 };
            Console.WriteLine("Please enter the position(1...\"array.length\") of the number you would like to check");
            int position = int.Parse(Console.ReadLine());
            int index = position - 1;
            // we do not expect the user to have in mind that position is not equal to index and in arrays indexes start from '0', 
            //but positions start from '1'

            bool isBigger = false; //holds the value returned by the method "CompareNumbers"

            if (index == 0)
            {// if user entered first position "0", neighbour is only the next position
                isBigger = CompareNumbers(arrayOfNumbers, 0, 1);
                PrintResult(isBigger, arrayOfNumbers, index);
            }
            else if (index == arrayOfNumbers.Length - 1)
            {// if user entered last position "index = arr.Length - 1", neighbour is only the previous position "arr.Length - 2 = index-1"
                isBigger = CompareNumbers(arrayOfNumbers, index, index - 1);
                PrintResult(isBigger, arrayOfNumbers, index);
            }
            else if (index > 0 && index < arrayOfNumbers.Length - 1)
            {
                isBigger = CompareNumbers(arrayOfNumbers, index, index - 1, index + 1);
                PrintResult(isBigger, arrayOfNumbers, index);
            }
            else
            {
                Console.WriteLine("The position you entered is out of array's range!!!");
            }

        }

        public static bool CompareNumbers(int[] array, params int[] indexes)
        /* The method checks if the number on the given position in the arrayOfNumbers is bigger than its neighbours.
         * Using variable number of parameters makes the method flexible and usable in the typical and border(first or last position) cases*/
        {   /*The variable amount of parameters will hold the positions in the array pointing to the number and 
            * its neighbours which have to be compared. 
            * The first parameter, kept in indexes[0] will always hold the position entered by user(indexes[0]=index)*/
            bool isBigger = true;
            for (int i = 1; i < indexes.Length; i++)
            {
                if (array[indexes[0]] < array[indexes[i]])
                /*checks if the number in the array on position entered by user - array[indexes[0]]
                 is smaller than the numbers on other(next, previous or both) positions */
                {
                    isBigger = false;
                }
            }
            return isBigger;
        }

        static void PrintResult(bool comparison, int[] array, int index)
        {
            if (comparison)
            {
                Console.WriteLine("The number \"{0}\" on position {1} is Bigger than its neighbours!", array[index], index + 1);
                // "index+1" prints position, not index
            }
            else
            {
                Console.WriteLine("The number \"{0}\" on position {1} is NOT Bigger than its neighbours!", array[index], index + 1);
            }

        }
    }
}
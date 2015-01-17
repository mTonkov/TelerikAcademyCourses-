using System;
using System.Collections.Generic;
//Write a program that finds the index of given element in a sorted array of 
//integers by using the binary search algorithm (find it in Wikipedia)

class BinarySearch
{
    static void Main(string[] args)
    {
        int[] initialArray = { 5, 3, 4, 9, 6, 8, 2, 1, 0, 11, 256, 33, 48, 59, 64, 32, 83 };
        int[] temp = (int[])initialArray.Clone();
        List<int> temporary = new List<int>(temp);
        // this "temporary" list will only keep the original format of the "initialArray", before sorting it

        int middleNumber, arrayMiddle, position;
        Array.Sort(initialArray);
        List<int> arrayToSearchIn = new List<int>(initialArray);
        // "arrayToSearchIn" will keep that part of the array, which has left after an iteration in the "while" loop

        Console.WriteLine("Please enter the number you want to search the array for...");
        int number = int.Parse(Console.ReadLine());


        if (number > initialArray[0] && number < initialArray[initialArray.Length - 1])
        {//if the entered number is out of the sorted array's range, there is no point of searching it
            while (true)
            {
                arrayMiddle = arrayToSearchIn.Count / 2;
                middleNumber = arrayToSearchIn[arrayMiddle];

                if (number > middleNumber)
                {
                    arrayToSearchIn = TakeArrayPart(arrayMiddle, arrayToSearchIn);
                    if (number == arrayToSearchIn[0])
                    {
                        position = temporary.IndexOf(number);
                        Console.WriteLine("The array contains the searched number on position {0}!", position + 1);
                        break;
                    }
                }
                else if (number < middleNumber)
                {
                    arrayToSearchIn = TakeArrayPart(0, arrayToSearchIn);
                    if (number == arrayToSearchIn[0])
                    {
                        position = temporary.IndexOf(number);
                        Console.WriteLine("The array contains the searched number on position {0}!", position + 1);
                        break;
                    }
                }
                else
                {
                    position = temporary.IndexOf(number);
                    Console.WriteLine("The array contains the searched number on position {0}!", position + 1);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("No such number in the array!");
        }
    }

    static List<int> TakeArrayPart(int start, List<int> list)
    {       //Method to get that half of the array, which may contain the searched number, and checks for it
        List<int> newList = new List<int>();

        for (int i = start; i < list.Count / 2 + start + 1; i++)
        {
            newList.Add(list[i]);
        }

        return list = new List<int>(newList);
    }
}

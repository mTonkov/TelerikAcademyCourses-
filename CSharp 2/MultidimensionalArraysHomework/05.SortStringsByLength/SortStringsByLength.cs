using System;
//You are given an array of strings. Write a method that sorts the array by the 
//length of its elements (the number of characters composing them).


class SortStringsByLength
    {
        static void Main(string[] args)
        {
            string[] stringArr = { "seven","five","eleven","twenty-three","one","fifteen"};
            Console.WriteLine("Unsorted string array:");
            PrintArray(stringArr);

            SortStringArray(stringArr);

            Console.WriteLine("Sorted string array:");
            PrintArray(stringArr);
        }


        static void PrintArray(string[] array)
        {
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine();
        }
        static void SortStringArray(string[] array)
        {
            string temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

        }
    }

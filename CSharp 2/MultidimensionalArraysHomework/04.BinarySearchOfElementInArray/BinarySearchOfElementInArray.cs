using System;
//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K

class BinarySearchOfElementInArray
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Please enter size of the array:");
        //int size = int.Parse(Console.ReadLine());
        //int[] array = new int[size];
        //for (int i = 0; i < size; i++)
        //{
        //    Console.WriteLine("Enter integer value for the array index {0}", i);
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        int[] array = {5,6,4,1,2,3,8,9,4,2,3,10};
        Console.WriteLine("Enter the searched target K:");
        int k = int.Parse(Console.ReadLine());

        if (array[0]>k)
        {
            Console.WriteLine("There is no number in the given array, which is equal to or less than K.");
            Environment.Exit(0);
        }
        Array.Sort(array);
        Search(array, k);
    }

    static void Search(int[] arr, int searchK)
    {
        int searchResult = Array.BinarySearch(arr, searchK);

        if (searchResult >= 0)
        {
            Console.WriteLine("The element equal or less than the searched one is {0} and is on index {1}", searchK, searchResult);
        }
        else
        {
            searchK--;
            Search(arr, searchK);
        }
    }
}

using System;
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

class ArrayOfMultipliedIndexes
{
    static void Main(string[] args)
    {
        
        int[] arrayOfMultipliedIndexes = new int[20];

        for (int i = 0; i < arrayOfMultipliedIndexes.Length; i++)
        {
            arrayOfMultipliedIndexes[i] = i * 5;
        }

        foreach (int index in arrayOfMultipliedIndexes)
        {
            Console.WriteLine(index);
        }
    }
}


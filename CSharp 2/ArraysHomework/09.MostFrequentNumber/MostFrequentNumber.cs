using System;

//Write a program that finds the most frequent number in an array
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int maxFrequency = 0;
            int currentFrequency = 1;
            int maxFrequencyNumber = 0; //keeps the most frequent number

            Array.Sort(arrayOfNumbers); 
            //first, I sort the array, so I can scan it using "for" loop and count the equal elements
            for (int i = 0; i < arrayOfNumbers.Length-1; i++)
            {
                if (arrayOfNumbers[i] == arrayOfNumbers[i+1])
                {
                    currentFrequency++;

                    if (currentFrequency > maxFrequency)
                    {
                        maxFrequency = currentFrequency;
                        maxFrequencyNumber = arrayOfNumbers[i];
                    }
                }
                else 
                {
                    currentFrequency = 1;
                }
            }

            Console.WriteLine("The number < {0} > has the max frequency: {1}", maxFrequencyNumber, maxFrequency);

        }
    }

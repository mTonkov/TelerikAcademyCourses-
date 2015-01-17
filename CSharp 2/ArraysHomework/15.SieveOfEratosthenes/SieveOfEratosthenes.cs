using System;
using System.Collections.Generic;
using System.Text;
//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm 

class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        int[] range = new int[10000000];
        for (int i = 0; i < range.Length; i++)
        {
            range[i] = i;
        }

        StringBuilder primes = new StringBuilder();
        for (int i = 2; i < range.Length; i++)
        {
            for (int j = i + i; j < range.Length; j += i)
            {
                range[j] = 0;
            }

        }

        for (int i = 0; i < range.Length; i++)
        {
            if (range[i] != 0)
            {
                primes.Append(range[i] + " ");
            }
        }

        Console.WriteLine(primes);
    }
}

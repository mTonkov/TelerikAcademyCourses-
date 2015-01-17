using System;


namespace CheckIfIntIsPrime
{
    class CheckIfIntIsPrime
    {
        static void Main()
        {
            //Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

            Console.WriteLine("Please enter a positive integer number");
            uint n = uint.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                if (n%i !=0) 
                    /*A prime number is a number which can be divided only by 1 and itself.
                     Here I check if there is a number 'i' smaller than 'n' and bigger than 1,
                     which divides 'n' and the result is an integer number.*/ 
                {
                    if (i == n - 1) //when 'i' reaches 'n', and there are no dividers without remainders, 'n' is Prime
                    { 
                        Console.WriteLine(n + " is Prime");
                    } 
                }
                else //if there is even one more number(except 1 and 'n'), which can divide 'n' without remainder and 
                    //the result is integer, that means 'n' is Not a Prime number and no more checks are needed                  
                {
                   Console.WriteLine(n + " is not Prime"); 
                    break;                  
                }
                
            }
        }
    }
}

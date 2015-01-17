using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestInteger
{
    class BiggestInteger
    {
        static void Main(string[] args)
        { //Write a program that finds the biggest of three integers using nested if statements

            Console.WriteLine("Please enter 3 integer numbers");
           
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a<b)
            {
                if (c > a) //this will also work if the condition is (c>a && c>b). It will save the next "if (c > b)"
                {
                    if (c > b)
                    {
                        Console.WriteLine("The biggest number is: " + c);
                    }
                    else
                    {
                        Console.WriteLine("The biggest number is: " + b);
                    }
                }
                else 
                {
                    Console.WriteLine("The biggest number is: " + b);
                }   
            }
            else if (a>b)
            {
                if (b>c)
                {
                    Console.WriteLine("The biggest number is: " + a);
                }
                else if (c>b)
                {
                    if (c>a)
                    {
                        Console.WriteLine("The biggest number is: " + c);
                    }
                    else
                    {
                        Console.WriteLine("The biggest number is: " + a);
                    }
                }
            }


        }
    }
}

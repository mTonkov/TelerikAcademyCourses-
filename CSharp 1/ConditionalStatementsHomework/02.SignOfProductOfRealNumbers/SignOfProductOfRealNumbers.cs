using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfProductOfRealNumbers
{
    class SignOfProductOfRealNumbers
    {
        static void Main(string[] args)
        {
            //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
            Console.WriteLine("Please enter 3 real numbers");
            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            double c = double.Parse(Console.ReadLine());


            if (a!=0 && b!=0 && c!=0) //first check is for '0' values of a, b or c, which will not return any sign
            {
                if (a < 0 && b < 0) // -*-
                {
                    if (c < 0) //   -*-*- = -
                    {
                        Console.WriteLine("The sign of the product is '-'");
                    }
                    else    // -*-*+ = +
                    {
                        Console.WriteLine("The sign of the product is '+'");
                    }
                }
                else if (a < 0 && b > 0)    // -*+
                {
                    if (c > 0)  // -*+*+ = -
                    {
                        Console.WriteLine("The sign of the product is '-'");
                    }
                    else    // -*+*- = +
                    {
                        Console.WriteLine("The sign of the product is '+'");
                    }
                }
                else if (a > 0 && b > 0)    // +*+
                {
                    if (c < 0)  //+*+*- = -
                    {
                        Console.WriteLine("The sign of the product is '-'");
                    }
                    else    //+*+*+ = +
                    {
                        Console.WriteLine("The sign of the product is '+'");
                    }
                }
                else if (a > 0 && b < 0) //+*-
	            {
		            if(c>0)     //+*-*+ = -
		            {
			            Console.WriteLine("The sign of the product is '-'");
		            }
		            else    //+*-*- = +
		            {
			            Console.WriteLine("The sign of the product is '+'");
		            }
	            }
	
            }
            else
            {
	            Console.WriteLine("One of the inputs is '0' so is the product. To see a sign of (a,b,c)'s product, you need non-zero inputs");
            }
            
        }
    }
}

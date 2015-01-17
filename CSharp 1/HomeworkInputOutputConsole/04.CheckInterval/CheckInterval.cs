using System;


namespace CheckInterval
{
    class ProgrCheckIntervalam
    {
        static void Main()
        {//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

            int startNum, endNum;

            while (true)
            {
	            Console.WriteLine("Please enter the first positive integer number of the interval");
	            startNum = int.Parse(Console.ReadLine());

	            Console.WriteLine("Please enter the second positive integer number of the interval");
	            endNum = int.Parse(Console.ReadLine());

                if (startNum < endNum)
                    {
                        break;
                    }
                else if (startNum > endNum) 
		            {   //this is a check for the numbers - if the first input is bigger than the second, the values of the variables are exchanged
		             int exchange = startNum;
		             startNum = endNum;
		             endNum = exchange;
		             break;
		            }
                else
		            {
                       Console.WriteLine("You need an interval between two numbers, in order to get a result");
		            }
	
            }

            int count = 0;
            for (int i = startNum; i <= endNum; i++)
            {
	            if (i%5==0)
	             {
		            count += 1;
	             }
            }

            Console.WriteLine("There are {0} numbers which are divided by 5 without remainder in the interval p({1},{2})-> p({1},{2})={0}",
                count, startNum, endNum);


        }
    }
}

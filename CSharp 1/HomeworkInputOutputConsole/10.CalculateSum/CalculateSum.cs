using System;


namespace CalculateSum
{
    class CalculateSum
    {
        static void Main()
        {   //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

            double sum = 1; // As it is shown in the task, the first value of the sum is 1
            double divider = 2; //Each number in the sequence is calculated as dividing 1 by every integer number, starting from 2

            do
            {
                if (divider % 2 != 0)
                {
                    sum += -1 / divider; //if the devider is an Odd number, the number should be negative
                }
                else
                {
                    sum += 1 / divider;
                }
                divider++;      //every iteration should use the next absolute value of the divider

            } while ((1 / (divider + 1)) >= 0.001);
            //The loop keeps on working, while the absolute value of the added real number (1/divider) is bigger or equal to the point of precision.
            // This means that, if ( 1/divider ) is < 0.001, the sum will be changed after the 0.000 position, so the required precision is reached.
            //As preciosion is reached, the loop stops.

            Console.WriteLine("The calculated sum is {0:0.000}", sum);
            
        }
    }
}

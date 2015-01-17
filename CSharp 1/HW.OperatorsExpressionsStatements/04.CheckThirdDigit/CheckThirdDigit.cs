using System;

namespace CheckThirdDigit
{
    class CheckThirdDigit
    {
        static void Main()
        { //Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true

            Console.WriteLine("Please insert the integer number you want to check:");
            string number = Console.ReadLine();
            int numberLength = number.Length; //gets the length of the string
            
            int thirdDigit = int.Parse(number[numberLength-3].ToString()); 
            /*gets the third digit by (string length)-3. 
             * number[numberLength-3] returns a (char), so we first need to convert it to (string), 
             * and then "Parse" it to (int) so we can compare it to '7' */
            bool isItSeven = (thirdDigit == 7); //

            Console.WriteLine("Third digit of the number is 7 ? -> " + isItSeven);

        }
    }
}

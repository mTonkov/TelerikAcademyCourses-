using System;


namespace CompareFloatingPointNumbers
{
    class CompareFloatingPointNumbers
    {
        static void Main()
        {
            //Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true


        bool repeat=true;
        bool result;
        while (repeat==true) //The "while" loop is used for the same reason as the manual input of the numbers - to make the pogram more interactive
                {
                Console.Write("Please, enter the first floating-point number: ");
                Double firstNumber = double.Parse(Console.ReadLine());
                Console.Write("Please, enter the second floating-point number: ");
                Double secondNumber = double.Parse(Console.ReadLine());
                Double difference = Math.Abs(firstNumber-secondNumber); //I take the absolute value of the difference between the two entered numbers, because we don't know which number will be entered - the bigger or the smaller
                Console.WriteLine();
                 if (difference <= 0.000001) //I think it is pretty much clear what is that comparison for. 
                    {
                    result = true;
                    Console.WriteLine("{0} and {1} are equal with precision of 0.000001:-> {2}", firstNumber, secondNumber, result);
                    }
                 else
                    {
                     result = false;
                     Console.WriteLine("{0} and {1} are equal with precision of 0.000001:-> {2}", firstNumber, secondNumber, result);
                    }
                Console.WriteLine();
                Console.WriteLine("Would you like to try again with different numbers - Y/N ?");

                string yesNo = Console.ReadLine();
       
                 if (yesNo == "Y" || yesNo == "y")
                        {
                            repeat = true;
                        }
                        else
                        {
                            repeat = false;
                        }
                 Console.WriteLine();
                }

        }
    }
}

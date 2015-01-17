using System;


namespace AppropriateFloatingPointDataType
{
    class AppropriateFloatingPointDataType
    {
        static void Main()
        { //Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

            double floatingOne = 34.567839023;
            float floatTwo = 12.345f;
            double floatThree = 8923.1234857;
            float floatFour = 3456.091f;

            Console.WriteLine(floatingOne);
            Console.WriteLine(floatTwo);
            Console.WriteLine(floatThree);
            Console.WriteLine(floatFour);

        }
    }
}

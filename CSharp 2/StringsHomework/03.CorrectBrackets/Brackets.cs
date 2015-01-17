using System;
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).


namespace CorrectBrackets
{
    class Brackets
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter an expression");
            //string expression = Console.ReadLine();
            //string expression = ")(a+b))";
            string expression = "((a+b)/5-d)";
            int openBrackets = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i]=='(')
                {
                    openBrackets++;
                }
                else if (expression[i] == ')')
                {
                    openBrackets--;
                }

                if (openBrackets<0)
                {
                    Console.WriteLine("Wrong expression!");
                    break;
                }
            }
            Console.WriteLine("Your expression is correct: {0}", expression);
        }
    }
}

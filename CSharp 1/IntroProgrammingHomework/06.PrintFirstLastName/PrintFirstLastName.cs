using System;


namespace PrintFirstLastName
{
    class PrintFirstLastName
    {
        static void Main()
        {
            //Create console application that prints your first and last name

            string FirstName = "James";
            string LastName = "Bond";
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("My name is:\n{0}...{1}!\n", LastName, fullName);
            
            //It is a piece of joke, but I think it is OK for the given task
        }
    }
}

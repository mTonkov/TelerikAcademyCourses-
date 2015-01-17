using System;


namespace MarketingFirmEmployees
{
    class MarketingFirmEmployees
    {
        static void Main()
        {
            /*A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family
             * name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the 
             * information for a single employee using appropriate data types and descriptive names.*/

            string firstName;
            string familyName;
            byte? age = null; /* these four variables are declared as nullables, because when they are about to be 
                               * checked for non-conformity of input data, as the variables go into the checks, 
                               * the compiler doesn't know a value because it is not entered yet*/
            char? gender = null;
            uint? idNumber = null;
            uint? uniqueNum = null;
            /*I believe that the declaration of the variables can be a solution which is OK with the requirements(declare variables with
             * descriptive names) in the task and there is no need of any additional codes, but I added the following lines because of
             * the warnings for unused variables and for some practice :).*/

            Console.WriteLine("Please insert employee's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Please insert employee's family name: ");
            familyName = Console.ReadLine();

                    while (true)
                    {
                        Console.WriteLine("Please insert employee's age: ");
                        try
                        {
                            age = byte.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message + "You have entered invalid data!");
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine(e.Message + "Nobody is that old...");
                        }
                            if (age > 18 && age < 75)
                            {
                                break;
                            }
                            else if (age < 18)
                            {
                                Console.WriteLine("You are not allowed to hire under-aged people");
                            }
                            else if (age > 75)
                            {
                                Console.WriteLine("Let this person retire!");
                            }
                            else
                            {
                                Console.WriteLine("Enter valid age using the NumPad");
                            }
                    }
            Console.WriteLine("Please insert employee's gender (M/F): ");
                    while (true)
                    {
                        try
                        {
                            gender = char.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message + "Please enter just \"m\" or \"f\" ");
                        }
                            if (gender == 'm' || gender == 'M' || gender == 'f' || gender == 'F')
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter just \"m\" or \"f\" ");
                            }
                    }
            Console.WriteLine("Please insert employee's ID number: ");
                    while (true)
                    {
                        try
                        {
                            idNumber = uint.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message + "You have entered invalid data!");
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine(e.Message + "The data you just entered is wrong or out of the specified range");
                        }
                        string validID = idNumber.ToString();
                            if (validID.Length == 9) //the ID number length is 9 digits, while Personal ID number contains 10 digits
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid 9 digit IDnumber");
                            }
                    }
            Console.WriteLine("Please insert a unique employee number: ");
                    while (true)
                    {
                        try
                        {
                            uniqueNum = uint.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message + "You have entered invalid data!");
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine(e.Message + "The data you just entered is wrong or out of the range");
                        }
                            if (uniqueNum >= 27560000 && uniqueNum <= 27569999) 
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a unique number in the range from 27560000 to 27569999:");
                            }
                    }
      
            Console.WriteLine();
            string firstNamText = "first name:";
            string familyText = "family name:";
            string ageText = "age:";
            string genderText = "gender: ";
            string idNumText = "ID number:";
            string uniNText = "Unique employee number:";
                    Console.WriteLine(new string('-',48));
                    Console.WriteLine("|{0,-25}|{1,20}|", firstNamText, firstName);
                    Console.WriteLine("|{0,-25}|{1,20}|", familyText, familyName);
                    Console.WriteLine("|{0,-25}|{1,20}|", ageText, age);
                    Console.WriteLine("|{0,-25}|{1,20}|", genderText, gender);
                    Console.WriteLine("|{0,-25}|{1,20}|", idNumText, idNumber);
                    Console.WriteLine("|{0,-25}|{1,20}|", uniNText, uniqueNum);
                    Console.WriteLine(new string('-', 48));

        }
    }
}

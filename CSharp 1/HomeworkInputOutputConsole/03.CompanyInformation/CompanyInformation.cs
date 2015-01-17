using System;


namespace CompanyInformation
{
    class CompanyInformation
    {
        static void Main()
        {   /*A company has name, address, phone number, fax number, web site and manager. 
            The manager has first name, last name, age and a phone number. 
            Write a program that reads the information about a company and its manager and prints them on the console.*/

            Console.Write("Enter your company's name:");
            string name = Console.ReadLine();
            Console.Write("Enter your company's address:");
            string address = Console.ReadLine(); 
                                                 
            Console.Write("Enter your company's phone number:");
            string phone = Console.ReadLine();   
                                         
            Console.Write("Enter your company's fax number:");
            string fax = Console.ReadLine();     
                                                 
            Console.Write("Enter your company's website:");
            string web = Console.ReadLine();     
                                                 
            Console.WriteLine("Enter your company manager's first and last name, age and phone number and press \"ENTER\" after each input:");
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Hello! Our company is {0} and we are situated at {1}.\n You can contact us by phone: {2} or fax: {3}.\n For more information, please visit our website: {4} or contact our manager {5}. \n If you are interested in men, you should know that he is {6} and his phone number is: {7} :)", name, address, phone, fax, web, managerFirstName + " " + managerLastName, managerAge, managerPhone);

        }
    }
}

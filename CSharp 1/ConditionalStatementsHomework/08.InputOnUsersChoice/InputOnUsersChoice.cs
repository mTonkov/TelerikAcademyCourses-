using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOnUsersChoice
{
    class InputOnUsersChoice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some data - integer, real number or text");

            int intInput; 
            int typeIdentifier = 0; 
            double dblInput = 0;
            string strInput, input;
            
            input = Console.ReadLine();
            strInput = input;

            if (int.TryParse(input, out intInput))
            {
                typeIdentifier = 1;
            }
            else if (double.TryParse(input, out dblInput))
            {
                typeIdentifier = 2;                
            }
            else
            {
                typeIdentifier = 3;
            }

            switch (typeIdentifier)
            {
                case 1:
                    Console.WriteLine(intInput+1);
                    break;
                case 2:
                    Console.WriteLine(dblInput+1);
                    break;
                case 3:
                    Console.WriteLine(strInput +'*');
                    break;

                default:
                    Console.WriteLine("Maybe you should try again");
                    break;
            }
        }
    }
}

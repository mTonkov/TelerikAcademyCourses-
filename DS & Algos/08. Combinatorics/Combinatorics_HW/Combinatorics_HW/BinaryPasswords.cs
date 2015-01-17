using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatorics_HW
{
    class BinaryPasswords
    {//my initial solution gets 60/100 from BGCoder. The 6-row end is similar to the authors solution and gets the max points
        private static int counter = 0;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = input.Length;

            int countAsterisk=0;
            for (int i = 0; i < n; i++)
            {
                if (input[i] == '*')
                {
                    countAsterisk++;
                }
            }
            //the next 6 rows also solve the task without any recursion and gets                     
            long result = 1;
            for (int i = 0; i < countAsterisk; i++)
            {
                result *= 2;
            }
            Console.WriteLine(result); 

            //int[] password = new int[countAsterisk];
            //PasswordGenerator(0, password);

            //Console.WriteLine(counter);
        }

        private static void PasswordGenerator(int index, int[] array)
        {
            if (index == array.Length)
            {
                counter++;
                return;
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    array[index] = i;
                    PasswordGenerator(index + 1, array);
                }
            }
        }
    }
}

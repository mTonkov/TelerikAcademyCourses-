using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Secrets
{
    class Secrets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart('-');
            int length = input.Length;

            BigInteger specialSum = 0;
            for (int i = 1; i <= length; i++)
            {
                int n = int.Parse(input[length-i].ToString());

                if (i%2==0)
                {
                    specialSum += n * n * i;
                }
                else
                {
                    specialSum += n * i * i;
                }
            }
            // output - special sum
            Console.WriteLine(specialSum);

            //find alpha sequence
            int lastDigit = (int) specialSum % 10;

            if (lastDigit==0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", input);
            }
            else
            {
                int r = (int) specialSum % 26;
                string[] alphabet = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};            
                string alphaSequence = null;
                int printed = 0;

                for (int i = 0; i < lastDigit-printed; i++)
                {
                    alphaSequence += alphabet[r+i];
                    if (alphabet[r+i] == "Z")
                    {
                        i = -1;
                        r = 0;
                        printed = alphaSequence.Length;
                    }
                }
                Console.WriteLine(alphaSequence);

            }
            
        }
    }
}

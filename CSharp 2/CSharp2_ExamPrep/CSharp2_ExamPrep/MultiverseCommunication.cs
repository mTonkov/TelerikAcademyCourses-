using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2_ExamPrep
{
    class MultiverseCommunication
    {
        static void Main(string[] args)
        {
            string[] value = new string[] { "0","1","2","3","4","5","6","7","8","9","A","B","C" };
            List<string> code = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

            string input = Console.ReadLine();
            string decode;
            int decodeIndex = 0;

            List<string> getResult = new List<string>();
            for (int i = 0; i < input.Length; i+=3)
            {
                decode = input.Substring(i, 3);
                decodeIndex = code.IndexOf(decode);

                getResult.Add(value[decodeIndex]);
            }
            
            long result = ArbitraryToDecimalSystem(string.Join("", getResult), 13);
            Console.WriteLine(result);
        }

        public static long ArbitraryToDecimalSystem(string number, int radix)
        {
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " +
                    Digits.Length.ToString());

            if (String.IsNullOrEmpty(number))
                return 0;

            // Make sure the arbitrary numeral system number is in upper case
            number = number.ToUpperInvariant();

            long result = 0;
            long multiplier = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char c = number[i];
                if (i == 0 && c == '-')
                {
                    // This is the negative sign symbol
                    result = -result;
                    break;
                }

                int digit = Digits.IndexOf(c);
                if (digit == -1)
                    throw new ArgumentException(
                        "Invalid character in the arbitrary numeral system number",
                        "number");

                result += digit * multiplier;
                multiplier *= radix;
            }

            return result;
        }
    }
}

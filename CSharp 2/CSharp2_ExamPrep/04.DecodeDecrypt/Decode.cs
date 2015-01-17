using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DecodeDecrypt
{
    class Decode
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int digit;
            string cypherLength = String.Empty;
            for (int i = input.Length - 1; i > 0; i--)
            {
                if (int.TryParse(input[i].ToString(), out digit))
                {
                    cypherLength += digit;
                }
                else
                {
                    break;
                }
            }
            char[] cyp = cypherLength.ToCharArray();
            Array.Reverse(cyp);
            cypherLength = string.Join("", cyp);

            int cypherL = int.Parse(cypherLength);
            input = DecodeMsg(input.Substring(0, input.Length - cypherLength.Length)) + cypherLength;

            string cypher = input.Substring(input.Length - cypherL - cypherLength.Length, cypherL).ToUpper();
            int endOfMsg = input.IndexOf(cypher);

            string message = input.Substring(0, endOfMsg).ToUpper();

            message = DecodeMsg(message);
            if (message.Length < cypher.Length)
            {
                Console.WriteLine(DecryptCypherIsBigger(message, cypher));
            }
            else
            {
                Console.WriteLine(DecryptMsgIsBigger(message, cypher));
            }
        }
        static string DecodeMsg(string msg)
        {
            var decode = new StringBuilder();
            var nums = new List<string>();
            int digit, prev;
            for (int i = 0; i < msg.Length; i++)
            {
                decode.Append(msg[i]);
                if (int.TryParse(msg[i].ToString(), out digit))
                {
                    if (int.TryParse(msg[i - 1].ToString(), out prev))
                    {
                        nums[nums.Count - 1] += digit.ToString();
                    }
                    else
                    {
                        nums.Add(digit.ToString());
                    }
                }
            }

            for (int i = 0; i < nums.Count; i++)
            {
                int indexOfCompression = msg.IndexOf(nums[i]);
                decode.Remove(indexOfCompression, nums[i].Length);

                for (int j = 0; j < int.Parse(nums[i])-1; j++)
                {
                    decode.Insert(indexOfCompression, decode[indexOfCompression]);
                }
            }

            return decode.ToString();
        }

        static string DecryptMsgIsBigger(string decodedMsg, string cyPher)
        {
            var decrypted = new StringBuilder();
            for (int i = 0; i < decodedMsg.Length; i++)
            {
                decrypted.Append((char)(((decodedMsg[i] - 'A') ^ (cyPher[i % cyPher.Length] - 'A')) + 'A'));
            }

            return decrypted.ToString();
        }

        static string DecryptCypherIsBigger(string decodedMsg, string cyPher)
        {
            var subCyphers = new List<string>();

            string subCypher = string.Empty;
            int cypherIndex = 0;
            while (cypherIndex < cyPher.Length) 
            {
                for (int j = 0; j < decodedMsg.Length; j++)
                {
                    subCypher += cyPher[cypherIndex];
                    cypherIndex++;
                    
                    if (!(cypherIndex < cyPher.Length))
                    {                        
                        break;
                    }
                }
                subCyphers.Add(subCypher);
            }

            var decrypt = new char[decodedMsg.Length];
            for (int i = 0; i < decodedMsg.Length; i++)
            {
                decrypt[i] = decodedMsg[i];
                for (int j = 0; j < subCyphers.Count; j++)
                {
                    decrypt[i] = (char)(((decrypt[i] - 'A') ^ (subCyphers[j][i] - 'A'))+ 'A');
                }
                //decrypt[i] += 'A';
            }

            return string.Join("",decrypt);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulRabbits
{
    class NumberOfRabbits
    {
        static void Main(string[] args)
        {// 58/100 - not much, but the maximum I could achieve without cheating
            int askedRabbits = int.Parse(Console.ReadLine());

            int[] rabbitsAnswers = new int[askedRabbits];
            for (int i = 0; i < askedRabbits; i++)
            {
                rabbitsAnswers[i] = int.Parse(Console.ReadLine());
            }

            int result = 1;
            int sameAnswerCount = 1;

            for (int i = 0; i < askedRabbits ; i++)
            {
                if (i < askedRabbits - 1 && rabbitsAnswers[i] == rabbitsAnswers[i+1])
                {
                    sameAnswerCount++;
                    if (sameAnswerCount > rabbitsAnswers[i]+1)
                    {
                        result += (rabbitsAnswers[i] + 1);
                        sameAnswerCount = 1;
                    }
                }
                if (i < askedRabbits - 1 && rabbitsAnswers[i] != rabbitsAnswers[i+1])
                {
                    sameAnswerCount = 1;
                    result += (rabbitsAnswers[i] + 1);
                    if (i == askedRabbits - 1)
                    {
                        result += (rabbitsAnswers[i + 1] );
                    }
                }
                else if (i == askedRabbits - 1)
                {
                    result += (rabbitsAnswers[i] );
                }
            }

            Console.WriteLine(result);
        }
    }
}

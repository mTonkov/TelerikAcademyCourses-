using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CardWars
{
    class CardWars
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());

            string[] firstPlayerHand = new string[3];
            string[] secondPlayerHand = new string[3];
            string[] cardNames = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
            int[] cardStrength = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13 };
            BigInteger firstPlayerScore = 0;
            BigInteger secondPlayerScore = 0;
            int firstPlayerGames = 0;
            int secondPlayerGames = 0;
            BigInteger firstTOTAL = 0;
            BigInteger secondTOTAL = 0;

            for (int i = 0; i < games; i++)
            {
                firstPlayerScore = 0;
                secondPlayerScore = 0;
                bool firstX = false;
                bool secondX = false;
                int[] firstPlayerStrength = new int[3];
                int[] secondPlayerStrength = new int[3];

                //read cards and take card strength
                //first player 3 cards
                for (int j = 0; j < 3; j++)
                {
                    firstPlayerHand[j] = Console.ReadLine();
                    //check for X, Y, Z
                    if (firstPlayerHand[j] == "X")
                    {
                        firstX = true;
                    }
                    if (firstPlayerHand[j] == "Z")
                    {
                        firstTOTAL *= 2;
                    }
                    if (firstPlayerHand[j] == "Y")
                    {
                        firstTOTAL -= 200;
                    }
                    for (int k = 0; k < 13; k++)
                    {
                        if (firstPlayerHand[j] == cardNames[k])
                        {
                          //  firstPlayerScore += cardStrength[k];
                           firstPlayerStrength[j] = cardStrength[k];
                        }
                    }
                }

                //second player 3 cards
                for (int j = 0; j < 3; j++)
                {
                    secondPlayerHand[j] = Console.ReadLine();
                    if (secondPlayerHand[j] == "X")
                    {
                        secondX = true;
                    }
                    if (secondPlayerHand[j] == "Z")
                    {
                        secondTOTAL *= 2;
                    }
                    if (secondPlayerHand[j] == "Y")
                    {
                        secondTOTAL -= 200;
                    }

                    for (int k = 0; k < 13; k++)
                    {
                        if (secondPlayerHand[j] == cardNames[k])
                        {
                            //secondPlayerScore += cardStrength[k];
                            secondPlayerStrength[j] = cardStrength[k];
                        }
                    }
                }

                //count score 
                for (int j = 0; j < 3; j++)
                {
                    firstPlayerScore += firstPlayerStrength[j];
                    secondPlayerScore += secondPlayerStrength[j];
                }

                // result if there is any X
                if (firstX && secondX)
                {
                    firstTOTAL += 50;
                    secondTOTAL += 50;
                    firstX = false;
                    secondX = false;
                }
                else
                {
                    if (firstX)
                    {
                        Console.WriteLine("X card drawn! Player one wins the match!");
                        Environment.Exit(0);
                    }
                    else if (secondX)
                    {
                        Console.WriteLine("X card drawn! Player two wins the match!");
                        Environment.Exit(0);
                    }
                }

                if (firstPlayerScore > secondPlayerScore)
                {
                    firstPlayerGames++;
                    firstTOTAL += firstPlayerScore;
                }
                if (firstPlayerScore < secondPlayerScore)
                {
                    secondPlayerGames++;
                    secondTOTAL += secondPlayerScore;
                }
            }//game loop


            //result after all games
            if (firstTOTAL > secondTOTAL)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", firstTOTAL);
                Console.WriteLine("Games won: {0}", firstPlayerGames);
            }
            if (firstTOTAL < secondTOTAL)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", secondTOTAL);
                Console.WriteLine("Games won: {0}", secondPlayerGames);
            }
            if (firstTOTAL == secondTOTAL)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", firstTOTAL);
            }
        }//match
    }
}

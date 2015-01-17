using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittris
{
    class Bittris
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            int pointsForCurrentNumber = 0;
            int score = 0;
            string currentNumberBin = null;
            string playingBits = null;
            char movement;
            char[,] tetris = new char[4, 8];
            bool clearRow = false;
            bool canMoveDown = true;


            for (int i = 0; i < n / 4; i++) // game - start
            {
                pointsForCurrentNumber = 0;//count the points which the number brings
                currentNumber = int.Parse(Console.ReadLine());
                currentNumberBin = Convert.ToString(currentNumber, 2).PadLeft(32, '0');

                for (int j = 0; j < currentNumberBin.Length; j++)
                {
                    if (currentNumberBin[j] == '1')
                    {
                        pointsForCurrentNumber++;
                    }
                }//\count the points which the number brings\

                playingBits = currentNumberBin.Substring(24, 8);

                for (int col = 0; col < 8; col++) //insert bits in tetris table
                {
                    tetris[0, col] = playingBits[col];
                }

                string command = Console.ReadLine() + Console.ReadLine() + Console.ReadLine();
                for (int j = 0; j < 3; j++) //movements D, L, R
                {
                    movement = command[j];
                    if (movement == 'L') // shift left
                    {
                        if (tetris[j, 0] == '0')
                        {
                            for (int k = 0; k < 7; k++)
                            {
                                tetris[j, k] = tetris[j, k + 1];
                            }
                        }
                    }
                    else if (movement == 'R') // shift right
                    {
                        if (tetris[j, 7] == '0')
                        {
                            for (int k = 0; k < 7; k++)
                            {
                                tetris[j, 7 - k] = tetris[j, 7 - k - 1];
                            }
                        }
                    }// shift left and right


                    //move down in table
                    canMoveDown = true;
                    for (int col = 0; col < 8; col++)
                    {
                        if (tetris[j, col] == '1' && tetris[j, col] == tetris[j + 1, col])
                        {
                            canMoveDown = false;
                            if (j == 0 && !(canMoveDown))
                            {
                                Console.WriteLine(score);
                                Environment.Exit(0);
                            }
                            break;
                        }
                    }
                                        
                    clearRow = false;
                    if (canMoveDown)
                    {
                        for (int col = 0; col < 8; col++)
                        {
                            tetris[j + 1, col] = tetris[j, col];
                        }
                    }
                    else
                    {
                        int countFullRow = 0;
                        for (int col = 0; col < 8; col++) // check for full row
                        {
                            if (tetris[j, col] == '1')
                            {
                                countFullRow++;
                            }
                        }// check for full row

                        if (countFullRow == 8)
                        {
                            clearRow = true;
                            pointsForCurrentNumber *= 10;
                        }

                        score += pointsForCurrentNumber;
                    }

                    if (clearRow)
                    {
                        for (int col = 0; col < 8; col++)
                        {
                            tetris[j, col] = '0';
                        }

                        for (int row = j; row > 0; row++)
                        {
                            for (int col = 0; col < 8; col++)
                            {
                                tetris[row, col] = tetris[row - 1, col];
                            }
                        }
                    }

                } // movements
                           
            } // game - end

            //output
            Console.WriteLine(score);
        }
    }
}

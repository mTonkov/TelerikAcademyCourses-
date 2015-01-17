using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoikoTower
{
    class BatGoikoTower
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int leftSide = 0;
            int rightSide = 0;
            char[,] tower = new char[h, 2*h];
            int stabilityMeasure = 1; 
            int crossbeam = 1;
            

            //draw
            for (int row = 0; row < h; row++)
            {
                leftSide = (2 * h) / 2 - 1 - row; // '/'
                rightSide = (2 * h) / 2 + row;    //   '\'
                
                
                for (int col = 0; col < 2*h; col++)
                {
                    tower[row, col] = '.';
                    if (col == leftSide)
                    {
                        tower[row, col] = '/';
                    }
                    if (col == rightSide)
                    {
                        tower[row, col] = '\\';
                    }

                    //crossbeams
                    if ((row == crossbeam) && ((col > leftSide) && (col < rightSide)))
                    {
                        tower[row,col] = '-';
                        if (col == rightSide - 1)
                        {
                            stabilityMeasure++;
                            crossbeam += stabilityMeasure;
                        }
                    }
                }
            }

            //print output
            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < 2 * h; col++)
                {
                    Console.Write(tower[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

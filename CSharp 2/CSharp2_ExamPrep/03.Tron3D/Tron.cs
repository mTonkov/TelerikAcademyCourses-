using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron3D
{
    class Tron
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(' ');
            int x = int.Parse(size[0]);
            int y = int.Parse(size[1]);
            int z = int.Parse(size[2]);
            string actionsRed = Console.ReadLine(); //1
            string actionsBlue = Console.ReadLine();//2
            int red = 1; //red trace
            int blue = 2; //blue trace
            int notAvailable = 3;

            int[, ,] cube = new int[x, y, z];

            for (int j = 0; j < y; j++)             // set unavailable fields
            {
                for (int k = 0; k < z; k++)
                {
                    cube[0, j, k] = notAvailable;
                    cube[x, j, k] = notAvailable;
                }
            }

            int i = 0;
            int rowR = x / 2 - 1;
            int colR = y / 2 - 1;
            int depR = 0;
            int rowB = x / 2 - 1;
            int colB = y / 2 - 1;
            int depB = z - 1;

            int[, ,] redP = new int[rowR, colR, depR];// Red start
            int[, ,] redB = new int[rowB, colB, depB];//Blue start

            while (actionsRed[i] < actionsRed.Length && actionsBlue[i] < actionsBlue.Length)
            {



            }

        }


        static int[, ,] MovePlayer(char move, string direction, int[, ,] player)
        {
            if (direction == "north")
            {
                if (move == 'L')
                {
                    //if (dep == 0)
                    //{
                    //    direction = "west";
                    //    col--;
                    //}
                    //else
                    //{
                    //    direction = "east";
                    //    col++;
                    //}
                }
                else if (move == 'R')
                {

                }
            }
            else if (direction == "west")
            {

            }
            else if (direction == "south")
            {
                
            }
            else if (direction == "east")
            {
                
            }
        }


    }
}

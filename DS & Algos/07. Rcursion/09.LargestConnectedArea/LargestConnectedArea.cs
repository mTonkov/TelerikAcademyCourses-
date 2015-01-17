using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LargestConnectedArea
{
    public class LargestConnectedArea
    {
        private static char[,] matrix = new char[,]{
                {' ',' ',' ','#',' ',' ',' '},
                {' ','#',' ',' ',' ','#',' '},
                {' ','#',' ','#',' ',' ',' '},
                {' ','#',' ','#',' ','#',' '},
                {' ','#',' ',' ',' ','#','$'}
            };
        static int[,] paths = new int[matrix.GetLength(0), matrix.GetLength(1)];

        static void Main()
        {
            BFS(4, 0);
        }

        static void BFS(int row, int col)
        {
            Queue<Position> queue = new Queue<Position>();
            queue.Enqueue(new Position(row, col));
            paths[row, col] = 1;

            int count = 1;
            while (queue.Count > 0)
            {
                Position pos = queue.Dequeue();
                if (pos.Col - 1 >= 0 && matrix[pos.Row, pos.Col - 1] == ' ' && paths[pos.Row, pos.Col - 1] == 0)
                {
                    queue.Enqueue(new Position(pos.Row, pos.Col - 1));
                    paths[pos.Row, pos.Col - 1] = paths[pos.Row, pos.Col] + 1;
                }
                if (pos.Col + 1 < matrix.GetLength(1) && matrix[pos.Row, pos.Col + 1] == ' ' && paths[pos.Row, pos.Col + 1] == 0)
                {
                    queue.Enqueue(new Position(pos.Row, pos.Col + 1));
                    paths[pos.Row, pos.Col + 1] = paths[pos.Row, pos.Col] + 1;
                }
                if (pos.Row + 1 < matrix.GetLength(0) && matrix[pos.Row + 1, pos.Col] == ' ' && paths[pos.Row + 1, pos.Col] == 0)
                {
                    queue.Enqueue(new Position(pos.Row + 1, pos.Col));
                    paths[pos.Row + 1, pos.Col] = paths[pos.Row, pos.Col] + 1;
                }
                if (pos.Row - 1 >= 0 && matrix[pos.Row - 1, pos.Col] == ' ' && paths[pos.Row - 1, pos.Col] == 0)
                {
                    queue.Enqueue(new Position(pos.Row - 1, pos.Col));
                    paths[pos.Row - 1, pos.Col] = paths[pos.Row, pos.Col] + 1;
                }
                count++;
            }
            Print();
            Console.WriteLine();

        }

        private static void Print()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 4} ", paths[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
    class Position
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
}

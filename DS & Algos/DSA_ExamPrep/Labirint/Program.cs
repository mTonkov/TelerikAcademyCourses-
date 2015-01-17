using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Program
    {
        static void Main(string[] args)
        {
            var startPosition = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s))
                .ToArray();

            var labirintSize = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s))
                .ToArray();

            var x = labirintSize[0];
            var y = labirintSize[1];
            var z = labirintSize[2];
            var isVisited = new bool[x, y, z];
            var lab = new char[x, y, z];

            for (int l = 0; l < x; l++)
            {
                for (int r = 0; r < y; r++)
                {
                    var row = Console.ReadLine();
                    for (int c = 0; c < z; c++)
                    {
                        lab[l, r, c] = row[c];
                    }
                }
            }

            var queue = new Queue<Position>();
            queue.Enqueue(new Position(startPosition[0], startPosition[1], startPosition[2], 0));
            isVisited[startPosition[0], startPosition[1], startPosition[2]] = true;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                current.CheckLevel(lab);
                if (current.Row - 1 >= 0 && lab[current.Level, current.Row - 1, current.Column] != '#' &&
                    !isVisited[current.Level, current.Row - 1, current.Column])
                {
                    var nextPos = new Position(current.Level, current.Row - 1, current.Column, current.Steps + 1);

                    if (nextPos.CheckIsOut(x, lab))
                    {
                        Console.WriteLine(nextPos.Steps + 1);
                        break;
                    }

                    isVisited[nextPos.Level, nextPos.Row, nextPos.Column] = true;
                    nextPos.CheckLevel(lab);
                    isVisited[nextPos.Level, nextPos.Row, nextPos.Column] = true;

                    queue.Enqueue(nextPos);
                }
                 if (current.Column + 1 < z && lab[current.Level, current.Row, current.Column + 1] != '#'&&
                    !isVisited[current.Level, current.Row, current.Column + 1])
                {
                    var nextPos = new Position(current.Level, current.Row, current.Column + 1, current.Steps + 1);

                    if (nextPos.CheckIsOut(x, lab))
                    {
                        Console.WriteLine(nextPos.Steps + 1);
                        break;
                    }

                    isVisited[nextPos.Level, nextPos.Row, nextPos.Column] = true;
                    nextPos.CheckLevel(lab);
                    isVisited[nextPos.Level, nextPos.Row, nextPos.Column] = true;

                    queue.Enqueue(nextPos);
                }
                 if (current.Row + 1 < y && lab[current.Level, current.Row + 1, current.Column] != '#'&&
                    !isVisited[current.Level, current.Row + 1, current.Column])
                {
                    var nextPos = new Position(current.Level, current.Row + 1, current.Column, current.Steps + 1);

                    if (nextPos.CheckIsOut(x, lab))
                    {
                        Console.WriteLine(nextPos.Steps + 1);
                        break;
                    }

                    isVisited[nextPos.Level, nextPos.Row, nextPos.Column] = true;
                    nextPos.CheckLevel(lab);
                    isVisited[nextPos.Level, nextPos.Row, nextPos.Column] = true;

                    queue.Enqueue(nextPos);
                }
                 if (current.Column - 1 >= 0 && lab[current.Level, current.Row, current.Column - 1] != '#'&&
                    !isVisited[current.Level, current.Row, current.Column - 1])
                {
                    var nextPos = new Position(current.Level, current.Row, current.Column - 1, current.Steps + 1);

                    if (nextPos.CheckIsOut(x, lab))
                    {
                        Console.WriteLine(nextPos.Steps + 1);
                        break;
                    }

                    isVisited[nextPos.Level, nextPos.Row, nextPos.Column] = true;
                    nextPos.CheckLevel(lab);
                    isVisited[nextPos.Level, nextPos.Row, nextPos.Column] = true;

                    queue.Enqueue(nextPos);
                }
            }
        }
    }
    class Position
    {
        public Position(int level, int row, int col, int steps)
        {
            this.Level = level;
            this.Row = row;
            this.Column = col;
            this.Steps = steps;
        }

        public int Level { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int Steps { get; set; }

        public bool CheckIsOut(int x, char[, ,] lab)
        {
            if ((this.Level == x - 1 && lab[this.Level, this.Row, this.Column] == 'U') ||
                (this.Level == 0 && lab[this.Level, this.Row, this.Column] == 'D'))
            {
                return true;
            }
            return false;
        }

        public void CheckLevel(char[, ,] lab)
        {
            if (lab[this.Level, this.Row, this.Column] == 'U')
            {
                this.Level++;
                this.Steps++;
            }
            else if (lab[this.Level, this.Row, this.Column] == 'D')
            {
                this.Level--;
                this.Steps++;
            }
        }
    }
}

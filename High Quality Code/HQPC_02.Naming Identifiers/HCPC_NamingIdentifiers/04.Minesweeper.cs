namespace HCPC_NamingIdentifiers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HCPC_NamingIdentifiers.Score;

    public class Minesweeper
    {
        public static void Main(string[] args)
        {
            const int MAX_SCORE = 35;

            string command = string.Empty;
            char[,] field = CreateField();
            char[,] bombs = PlantBombs();
            int counter = 0;
            bool isOnMine = false;
            List<Score> players = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool hasGameToStart = true;
            bool isGameWon = false;

            do
            {
                if (hasGameToStart)
                {
                    Console.WriteLine("Let's play \"Minesweeper\". Try your luck and find the fields without mines. Command \"top\" shows the score table, \"restart\" starts a new game, \"exit\" quits the game.");
                    DrawField(field);
                    hasGameToStart = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Scores(players);
                        break;
                    case "restart":
                        field = CreateField();
                        bombs = PlantBombs();
                        DrawField(field);
                        isOnMine = false;
                        hasGameToStart = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                ChangeTurns(field, bombs, row, col);

                                counter++;
                            }

                            if (MAX_SCORE == counter)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            isOnMine = true;
                        }

                        break;

                    default:
                        Console.WriteLine("\nGreshka! nevalidna command\n");

                        break;
                }

                if (isOnMine)
                {
                    DrawField(bombs);

                    Console.Write("\n Oh crap! You die with {0} scored points. Enter your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Score t = new Score(nickname, counter);

                    if (players.Count < 5)
                    {
                        players.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < t.Points)
                            {
                                players.Insert(i, t);
                                players.RemoveAt(players.Count - 1);

                                break;
                            }
                        }
                    }

                    players.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    players.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    Scores(players);

                    field = CreateField();
                    bombs = PlantBombs();
                    counter = 0;
                    isOnMine = false;
                    hasGameToStart = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("\n Great job! You survived!");
                    DrawField(bombs);
                    Console.WriteLine("Please enter your name: ");
                    string playerName = Console.ReadLine();
                    Score playerScore = new Score(playerName, counter);
                    players.Add(playerScore);
                    Scores(players);
                    field = CreateField();
                    bombs = PlantBombs();
                    counter = 0;
                    isGameWon = false;
                    hasGameToStart = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("See you next time.");
            Console.Read();
        }

        private static void Scores(List<Score> points)
        {
            Console.WriteLine("\n Points:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No score!\n");
            }
        }

        private static void ChangeTurns(char[,] field, char[,] bombs, int row, int col)
        {
            char numberOfBombs = CountBombs(bombs, row, col);
            bombs[row, col] = numberOfBombs;
            field[row, col] = numberOfBombs;
        }

        private static void DrawField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlantBombs()
        {
            int bombsRows = 5;
            int bombsCols = 10;
            char[,] boardWithBombs = new char[bombsRows, bombsCols];

            for (int i = 0; i < bombsRows; i++)
            {
                for (int j = 0; j < bombsCols; j++)
                {
                    boardWithBombs[i, j] = '-';
                }
            }

            List<int> bombsDistribution = new List<int>();
            while (bombsDistribution.Count < 15)
            {
                Random random = new Random();
                int numberOfBombs = random.Next(50);
                if (!bombsDistribution.Contains(numberOfBombs))
                {
                    bombsDistribution.Add(numberOfBombs);
                }
            }

            foreach (int bombs in bombsDistribution)
            {
                int row = bombs / bombsCols;
                int col = bombs % bombsCols;

                if (col == 0 && bombs != 0)
                {
                    row--;
                    col = bombsCols;
                }
                else
                {
                    col++;
                }

                boardWithBombs[row, col - 1] = '*';
            }

            return boardWithBombs;
        }

        private static void Calculations(char[,] field)
        {
            int row = field.GetLength(0);
            int col = field.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char numberOfBombs = CountBombs(field, i, j);
                        field[i, j] = numberOfBombs;
                    }
                }
            }
        }

        private static char CountBombs(char[,] bombs, int row, int col)
        {
            int bombsCount = 0;
            int rows = bombs.GetLength(0);
            int kols = bombs.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombs[row - 1, col] == '*')
                {
                    bombsCount++;
                }
            }

            if (row + 1 < rows)
            {
                if (bombs[row + 1, col] == '*')
                {
                    bombsCount++;
                }
            }

            if (col - 1 >= 0)
            {
                if (bombs[row, col - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if (col + 1 < kols)
            {
                if (bombs[row, col + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (bombs[row - 1, col - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < kols))
            {
                if (bombs[row - 1, col + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (bombs[row + 1, col - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < kols))
            {
                if (bombs[row + 1, col + 1] == '*')
                {
                    bombsCount++;
                }
            }

            return char.Parse(bombsCount.ToString());
        }
    }
}

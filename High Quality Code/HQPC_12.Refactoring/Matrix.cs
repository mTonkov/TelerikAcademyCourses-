namespace WalkingInMatrix
{
    using System;
    public class Matrix
    {
        private const int NUMBER_OF_DIRECTIONS = 8;
        private const int DIRECTIONS_LAST_INDEX = 7;

        public static void ChangeDirection(ref int currentDirectionX, ref int currentDirectionY)
        {
            int[] availableDirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] availableDirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentNormalVectorIndex = 0;

            for (int directionIndex = 0; directionIndex < NUMBER_OF_DIRECTIONS; directionIndex++)
            {
                if (availableDirectionsX[directionIndex] == currentDirectionX && availableDirectionsY[directionIndex] == currentDirectionY)
                {
                    currentNormalVectorIndex = directionIndex;
                    break;
                }
            }

            if (currentNormalVectorIndex == DIRECTIONS_LAST_INDEX)
            {
                currentDirectionX = availableDirectionsX[0];
                currentDirectionY = availableDirectionsY[0];
            }
            else
            {
                currentDirectionX = availableDirectionsX[currentNormalVectorIndex + 1];
                currentDirectionY = availableDirectionsY[currentNormalVectorIndex + 1];
            }
        }

        public static bool IsAnyDirectionPossible(int[,] matrix, int x, int y)
        {
            int[] availableDirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] availableDirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < NUMBER_OF_DIRECTIONS; i++)
            {
                if (x + availableDirectionsX[i] >= matrix.GetLength(0) || x + availableDirectionsX[i] < 0)
                {
                    availableDirectionsX[i] = 0;
                }

                if (y + availableDirectionsY[i] >= matrix.GetLength(0) || y + availableDirectionsY[i] < 0)
                {
                    availableDirectionsY[i] = 0;
                }
            }

            for (int i = 0; i < NUMBER_OF_DIRECTIONS; i++)
            {
                if (matrix[x + availableDirectionsX[i], y + availableDirectionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool FindAvailableCell(int[,] matrix, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

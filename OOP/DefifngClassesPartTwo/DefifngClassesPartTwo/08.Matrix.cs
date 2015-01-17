using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    public class Matrix<T>
where T : struct, IComparable<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rowsInput, int colsInput)
        {
            this.Rows = rowsInput;
            this.Cols = colsInput;
            this.matrix = new T[this.Rows, this.Cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Matrix cannot have negative number of rows");
                }
                else
                {
                    this.rows = value;
                }
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Matrix cannot have negative number of cols");
                }
                else
                {
                    this.cols = value;
                }
            }
        }

        public T this[int row, int col] //task 09
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                if (row > this.Rows || col > this.Cols || row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException("Rows and Columns in a matrix cannot have negative values");
                }
                else matrix[row, col] = value;
            }
        }
        
        //task 10
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> tempMatrix = new Matrix<T>(first.Rows, first.Cols);
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        tempMatrix[i, j] = (dynamic)first[i, j] + second[i, j];
                    }
                }
                return tempMatrix;
            }
            else throw new ArgumentException("The two matrices are not of same dimensions");
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> tempMatrix = new Matrix<T>(first.Rows, first.Cols);
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        tempMatrix[i, j] = (dynamic)first[i, j] - second[i, j];
                    }
                }
                return tempMatrix;
            }
            else throw new ArgumentException("The two matrices are not of same dimensions");
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols == second.Rows && (first.Rows > 0 && second.Cols > 0 && first.Cols > 0))
            {
                Matrix<T> newMatrix = new Matrix<T>(first.Rows, second.Cols);
                for (int i = 0; i < newMatrix.Rows; i++)
                {
                    for (int j = 0; j < newMatrix.Cols; j++)
                    {
                        newMatrix[i, j] = default(T);
                        for (int k = 0; k < first.Cols; k++)
                        {
                            newMatrix[i, j] = newMatrix[i, j] + (dynamic)first[i, k] * second[k, j];
                        }
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new ArgumentException("The two matrices' sizes are incompatible for multiplication");
            }
        }
    }
}

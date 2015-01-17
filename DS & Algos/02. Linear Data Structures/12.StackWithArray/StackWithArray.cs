using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.StackWithArray
{/*
  Implement the ADT stack as auto-resizable array. 
  Resize the capacity on demand (when no space is available to add / insert a new element)
  */
    public class StackWithArray<T>
        where T : IComparable
    {
        private const int INITIAL_ARRAY_SIZE = 4;

        private T[] data = new T[INITIAL_ARRAY_SIZE];
        private int indexCounter = 0;

        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }

        public int Count
        {
            get
            {
                return indexCounter;
            }
        }

        public void Push(T value)
        {
            if (indexCounter > data.Length)
            {
                int newSize = 2 * data.Length;
                var newData = new T[newSize];

                for (int i = 0; i < data.Length; i++)
                {
                    newData[i] = data[i];
                }
                data = newData;
            }

            data[indexCounter] = value;
            indexCounter++;
        }

        public T Peek()
        {
            return data[indexCounter - 1];
        }

        public T Pop()
        {
            indexCounter--;
            return data[indexCounter];
        }

        public void Clear()
        {
            data = new T[4];
        }

        public bool Contains(T value)
        {
            return data.Contains<T>(value);
        }

        public T[] ToArray()
        {
            return data.ToArray<T>();
        }

        public void TrimExcess()
        {
            var newArr = new T[indexCounter];

            for (int i = 0; i < indexCounter; i++)
            {
                newArr[i] = data[i];
            }

            data = newArr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    public class GenericList<T>
        where T: struct, IComparable
    {
        public T Min<T>() //task 07
    where T : IComparable<T>
        {            
            dynamic min = this.arr[0];
            if (this.arr.Length >= 2)
            {
                for (int i = 0; i < this.arr.Length - 1; i++)
                {
                    if (this.arr[i].CompareTo(this.arr[i + 1]) <= 0)
                    {
                        min = this.arr[i];
                    }
                    else
                    {
                        min = this.arr[i + 1];
                    }
                }
            }
            else if (this.arr.Length == 1)
            {
                min = this.arr[0];
            }
            else
            {
                Console.WriteLine("Empty collection!");
            }
            return min;
        }

        public T Max<T>() //task 07
    where T : IComparable<T>
        {
            dynamic max = this.arr[0];
            if (this.arr.Length >= 2)
            {
                for (int i = 0; i < this.arr.Length - 1; i++)
                {
                    if (this.arr[i].CompareTo(this.arr[i + 1]) <= 0)
                    {
                        max = this.arr[i + 1];
                    }
                    else
                    {
                        max = this.arr[i];
                    }
                }
            }
            else if (this.arr.Length == 1)
            {
                max = this.arr[0];
            }
            else
            {
                Console.WriteLine("Empty collection!");
            }
            return max;
        }

        private T[] arr;
        private int index;

        public GenericList()
        {
        }

        public GenericList(int arrSize)
            : this()
        {
            this.arr = new T[arrSize];
        }

        public void Add(T item)
        {
            if (this.index < this.arr.Length)
            {
                this.arr[this.index] = item;
            }
            else
            {
                this.arr = EnlargeArray(this.arr);
                this.arr[this.index] = item;
            }
            this.index++;
        }

        public int Count
        {
            get { return this.index; }
        }

        public int Capacity
        {
            get { return this.arr.Length; }
        }
        
        public T Access(int index)
        {
            return this.arr[index];
        }

        public void RemoveAt(int index)
        {
            T[] newArr = new T[this.arr.Length-1];

            for (int j = 0; j < newArr.Length; j++)
            {
                if (j < index)
                {
                    newArr[j] = this.arr[j];
                }
                else
                {// when the index of the item which has to be removed is reached, the item on that index is not copied to the new array
                    newArr[j] = this.arr[j + 1];
                }
            }
            this.arr = newArr;
            this.index--;
        }

        public void InsertAt(int index, T item)
        {
            T[] newArr = new T[this.arr.Length + 1];
            for (int j = 0; j < newArr.Length; j++)
            {
                if (j<index)
                {
                    newArr[j] = this.arr[j];
                }
                else if (j==index)
                {
                    newArr[j] = item;
                }
                else
                {
                    newArr[j] = this.arr[j-1];
                }
            }
            this.arr = newArr;
            this.index++;
        }

        public void Clear()
        { 
            this.arr = new T[this.arr.Length];
        }

        public int IndexOf(T item)
        {
            int result = -1;
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i].Equals(item))
                {
                    result = i;
                    break;
                }                
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.arr)
            {
                sb.Append(item);
            }
            
            return sb.ToString();
        }

        private T[] EnlargeArray(T[] arr)
        {
            T[] newArr = new T[arr.Length * 2];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        } //task06

    }
}

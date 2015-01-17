using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PriorityQueueWithHeap
{
    public class Heap<T>
        where T : IComparable
    {
        private const int INITIAL_SIZE = 4;
        private T[] heap;
        private int firstEmptyElementIndex;

        public Heap()
        {
            this.heap = new T[INITIAL_SIZE];
            this.firstEmptyElementIndex = 0;
        }

        public void Add(T element)
        {
            if (this.firstEmptyElementIndex == this.heap.Length)
            {
                this.ResizeArray();
            }
            var currentElementIndex = this.firstEmptyElementIndex;
            this.firstEmptyElementIndex++;

            this.heap[currentElementIndex] = element;

            var parentIndex = (currentElementIndex - 1) / 2;

            while (parentIndex >= 0 && this.heap[currentElementIndex].CompareTo(this.heap[parentIndex]) > 0)
            {
                Swap(parentIndex, currentElementIndex);

                currentElementIndex = parentIndex;
                parentIndex = (currentElementIndex - 1) / 2;
            }
        }

        public T[] Print()
        {
            return this.heap;
        }

        public T Remove()
        {
            var root = this.heap[0];

            this.firstEmptyElementIndex--;
            this.heap[0] = this.heap[this.firstEmptyElementIndex];
            this.heap[this.firstEmptyElementIndex] = default(T);

            var currentElementIndex = 0;
            while (true)
            {
                var firstChildIndex = currentElementIndex * 2 + 1;
                var secondChildIndex = currentElementIndex * 2 + 2;

                if (firstChildIndex < this.firstEmptyElementIndex)
                {
                        var biggerChildIndex = firstChildIndex;
                    if (secondChildIndex < this.firstEmptyElementIndex)
                    {
                        if (this.heap[firstChildIndex].CompareTo(this.heap[secondChildIndex]) < 0)
                        {
                            biggerChildIndex = secondChildIndex;
                        }
                    }

                    if (this.heap[currentElementIndex].CompareTo(this.heap[biggerChildIndex]) < 0)
                    {
                        Swap(currentElementIndex, biggerChildIndex);
                        currentElementIndex = biggerChildIndex;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            return root;
        }

        private void Swap(int first, int second)
        {
            var parent = this.heap[first];
            this.heap[first] = this.heap[second];
            this.heap[second] = parent;
        }

        private void ResizeArray()
        {
            int newSize = 2 * this.heap.Length;
            var newHeap = new T[newSize];

            for (int i = 0; i < this.heap.Length; i++)
            {
                newHeap[i] = this.heap[i];
            }

            this.heap = newHeap;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DynamicQueue
{/*Implement the ADT queue as dynamic linked list. 
  * Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
*/
    public class LinkedQueue<T>
                where T : IComparable
    {
        private LinkedList<T> data = new LinkedList<T>();

        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public void Enqueue(T value)
        {
            data.AddLast(value);
        }

        public T Dequeue()
        {
            var removed = data.First;
            data.RemoveFirst();
            return removed.Value;
        }

        public T Peek()
        {
            var removed = data.First;
            return removed.Value;
        }

        public void Clear()
        {
            data.Clear();
        }

        public bool Contains(T value)
        {
            return data.Contains(value);
        }

        public T[] ToArray()
        {
            return data.ToArray<T>();
        }
    }
}

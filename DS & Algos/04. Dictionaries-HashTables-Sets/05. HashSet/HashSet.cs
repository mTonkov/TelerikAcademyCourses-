using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.HashTable;

namespace _05.HashSet
{
    public class HashSet<T>
    {
        private HashTable<int, T> table;

        public HashSet()
        {
            this.table = new HashTable<int, T>();
        }

        public void Add(T value)
        {
            this.table.Add(value.GetHashCode(), value);
        } 
        public void Find(T value)
        {
            this.table.Find(value.GetHashCode());
        }
        public void Remove(T value)
        {
            this.table.Remove(value.GetHashCode());
        } 
        public int Count
        {
            get
            {
                return this.table.Count;
            }
        } 
        public void  Clear()
        {
            this.table.Clear();
        }
    }
}

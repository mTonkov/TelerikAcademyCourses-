using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HashTable
{/*Implement the data structure "hash table" in a class HashTable<K,T>. 
  * Keep the data in array of lists of key-value pairs (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16.
  * When the hash table load runs over 75%, perform resizing to 2 times larger capacity. 
  * Implement the following methods and properties: 
  * Add(key, value), Find(key)->value, Remove( key), Count, Clear(), this[], Keys. 
  * Try to make the hash table to support iterating over its elements with foreach.
*/
    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const int INITIAL_CAPACITY = 16;
        private const double DEFAULT_RESIZE_LEVEL = 0.75d;
        private int resizeIndicator;
        private int tableSize;
        private LinkedList<KeyValuePair<K, T>>[] hashTable;

        public HashTable()
            : this(INITIAL_CAPACITY, DEFAULT_RESIZE_LEVEL)
        {
        }

        public HashTable(int capacity, double resizeLevel)
        {
            hashTable = new LinkedList<KeyValuePair<K, T>>[capacity];
            this.resizeIndicator = (int)(capacity * resizeLevel);
        }

        public void Add(K key, T value)
        {
            int index = HashFromKey(key);

            if (hashTable[index] == null)
            {
                hashTable[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            if (!hashTable[index].Any(pair => pair.Key.Equals(key)))
            {
                hashTable[index].AddLast(new KeyValuePair<K, T>(key, value));
            }
            tableSize++;

            if (tableSize >= resizeIndicator)
            {
                ResizeTable();
            }
        }

        private int HashFromKey(K key)
        {
            return Math.Abs(key.GetHashCode() % hashTable.Length);
        }

        private void ResizeTable()//set new table, reset size counter, refill the new table by re-hashing
        {
            var currentHashTable = this.hashTable;
            this.hashTable = new LinkedList<KeyValuePair<K, T>>[hashTable.Length * 2];

            this.tableSize = 0;

            foreach (var currentCollection in currentHashTable)
            {
                if (currentCollection != null)
                {
                    foreach (var pair in currentCollection)
                    {
                        this.Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        public int Count
        {
            get
            {
                return this.tableSize;
            }
        }

        public bool Remove(K key)
        {
            int index = this.HashFromKey(key);
            if (this.hashTable[index] != null)
            {
                if (this.hashTable[index].Count == 0)
                {
                    this.hashTable[index] = null;
                    this.tableSize--;
                }

                var pair = this.hashTable[index].First(p => p.Key.Equals(key));
                this.hashTable[index].Remove(pair);

                return true;
            }

            return false;
        }

        public void Clear()
        {
            this.hashTable = new LinkedList<KeyValuePair<K, T>>[this.hashTable.Length];
        }

        public T Find(K key)
        {
            int index = this.HashFromKey(key);

            var collection = this.hashTable[index];
            var pair = collection.First(p => p.Key.Equals(key));

            return pair.Value;
        }

        public T this[K key]
        {
            get
            {
                return this.Find(key);
            }
            set
            {
                int index = this.HashFromKey(key);

                var collection = this.hashTable[index];
                var pair = collection.First(p => p.Key.Equals(key));

                this.Remove(key);
                this.Add(key, value);
            }
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var currentCollection in this.hashTable)
            {
                if (currentCollection != null)
                {
                    foreach (var pair in currentCollection)
                    {
                        yield return pair;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

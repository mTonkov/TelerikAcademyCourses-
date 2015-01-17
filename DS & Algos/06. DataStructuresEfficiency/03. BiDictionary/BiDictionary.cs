using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _03.BiDictionary
{
    public class BiDictionary<TKey1, TKey2, TValue>
    {
        private MultiDictionary<TKey1, TValue> dictionaryOne;
        private MultiDictionary<TKey2, TValue> dictionaryTwo;

        public BiDictionary()
        {
            dictionaryOne = new MultiDictionary<TKey1, TValue>(true);
            dictionaryTwo = new MultiDictionary<TKey2, TValue>(true);
        }

        public void Add(TKey1 key1, TKey2 key2, TValue value)
        {
            if (!dictionaryOne.ContainsKey(key1))
            {
                dictionaryOne.Add(key1, value);
            }
            else
            {
                dictionaryOne[key1].Add(value);
            }

            if (!dictionaryTwo.ContainsKey(key2))
            {
                dictionaryTwo.Add(key2, value);
            }
            else
            {
                dictionaryTwo[key2].Add(value);
            }
        }

        public IEnumerable<TValue> Find(TKey1 key1, TKey2 key2)
        {
            var result = new List<TValue>();

            if (dictionaryOne.ContainsKey(key1))
            {
                result.Union(dictionaryOne[key1]);
            }
            if (dictionaryTwo.ContainsKey(key2))
            {
                result.Union(dictionaryTwo[key2]);
            }

            return result;
        }

        public IEnumerable<TValue> Find(TKey1 key1)
        {
            if (!dictionaryOne.ContainsKey(key1))
            {
                return dictionaryOne[key1];
            }

            return null;
        }

        public IEnumerable<TValue> Find(TKey2 key2)
        {
            if (!dictionaryTwo.ContainsKey(key2))
            {
                return dictionaryTwo[key2];
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTable
{
    //O(n) space
    internal class HashTable
    {
        private readonly int _size;
        private readonly List<Map>[] _slots;

        internal HashTable(int size)
        {
            _size = size;
            _slots = new List<Map>[size];
        }

        //O(n/m) time
        internal void Insert(string key, int value)
        {
            int slot = Hash(key);
            List<Map> chain = GetSlotChain(slot);

            if (!chain.Any(link => link.Key.Equals(key)))
            {
                chain.Add(new Map(key, value));
            }
        }

        //O(n/m) time
        internal int? Search (string key)
        {
            int slot = Hash(key);
            List<Map> chain = GetSlotChain(slot);

            return chain.FirstOrDefault(link => link.Key.Equals(key))?.Value;
        }


        //O(n/m) time
        internal void Delete(string key)
        {
            int slot = Hash(key);
            List<Map> chain = GetSlotChain(slot);

            Map? link = chain.FirstOrDefault(link => link.Key.Equals(key));

            if (link != null)
                chain.Remove(link);
        }

        //O(1) time
        protected int Hash(string key) => Math.Abs(key.GetHashCode() % _size);

        //O(1) time
        protected List<Map> GetSlotChain(int hashValue)
        {
            List<Map> chain = _slots[hashValue];
            if (chain == null)
            {
                chain = new();
                _slots[hashValue] = chain;
            }

            return chain;
        }
    }
}
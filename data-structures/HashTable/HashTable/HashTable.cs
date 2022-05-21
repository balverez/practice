using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTable
{
    //O(n) space
    internal class HashTable
    {
        private readonly int _size;
        private readonly LinkedList<Map>[] _slots;

        internal HashTable(int size)
        {
            _size = size;
            _slots = new LinkedList<Map>[size];
        }

        //O(n/m) time
        internal void Insert(string key, int value)
        {
            int slot = Hash(key);
            LinkedList<Map> chain = GetSlotChain(slot);

            if (!chain.Any(link => link.Key.Equals(key)))
            {
                chain.AddFirst(new Map(key, value));
            }
        }

        //O(n/m) time
        internal int? Search (string key)
        {
            int slot = Hash(key);
            LinkedList<Map> chain = GetSlotChain(slot);

            return chain.FirstOrDefault(link => link.Key.Equals(key))?.Value;
        }


        //O(n/m) time
        internal void Delete(string key)
        {
            int slot = Hash(key);
            LinkedList<Map> chain = GetSlotChain(slot);

            Map? link = chain.FirstOrDefault(link => link.Key.Equals(key));

            if (link != null)
                chain.Remove(link);
        }

        //O(1) time
        protected int Hash(string key) => Math.Abs(key.GetHashCode() % _size);

        //O(1) time
        protected LinkedList<Map> GetSlotChain(int hashValue)
        {
            LinkedList<Map> chain = _slots[hashValue];
            if (chain == null)
            {
                chain = new();
                _slots[hashValue] = chain;
            }

            return chain;
        }
    }
}
using System.Collections.Generic;

namespace DataStructures.HashTable
{
    public class HashSetLinkedList
    {
        public List<int>[] arr;
        public HashSetLinkedList()
        {
            arr = new List<int>[100];
        }

        public void Add(int key)
        {
            int hashedValue = Hash(key);
            if (arr[hashedValue] == null)
            {
                arr[hashedValue] = new List<int>() { key };
            }
            else
            {
                var temp = arr[hashedValue];
                if (temp.Contains(key))
                {
                    return;
                }
                else
                {
                    temp.Add(key);
                }
            }
        }

        public void Remove(int key)
        {
            int hashedValue = Hash(key);
            var temp = arr[hashedValue];
            temp?.Remove(key);
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            int hashedValue = Hash(key);
            var temp = arr[hashedValue];
            return temp?.Contains(key) ?? false;
        }

        public static int Hash(int key)
        {
            return key % 100;
        }
    }
}

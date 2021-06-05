namespace DataStructures.HashTable
{
    public class HashSet
    {

        public Node[] arr;

        /** Initialize your data structure here. */
        public HashSet()
        {
            arr = new Node[100];
        }

        public void Add(int key)
        {
            int hashedValue = Hash(key);
            if (arr[hashedValue] == null)
            {
                arr[hashedValue] = new Node(key, null);
            }
            else
            {
                Node temp = arr[hashedValue];
                if (temp.Val == key)
                {
                    return;
                }
                while (temp.Next != null)
                {
                    temp = temp.Next;
                    if (temp.Val == key)
                    {
                        return;
                    }
                }
                temp.Next = new Node(key, null);
            }
        }

        public void Remove(int key)
        {
            int hashedValue = Hash(key);
            Node temp = arr[hashedValue];
            if (temp.Val == key)
            {
                arr[hashedValue] = temp.Next;
            }
            else
            {
                Node current = temp;
                while (temp != null && temp.Val != key)
                {
                    current = temp;
                    temp = temp.Next;
                }
                if (temp.Val == key)
                {
                    current.Next = temp.Next;
                }
            }

        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            int hashedValue = Hash(key);
            Node temp = arr[hashedValue];
            if (temp?.Val == key)
            {
                return true;
            }
            else
            {
                while (temp != null && temp.Val != key)
                {
                    temp = temp.Next;
                }
                return (temp?.Val == key);

            }
        }

        public static int Hash(int key)
        {
            return key % 100;
        }
    }

    public class Node
    {
        public int Val;
        public Node Next;

        public Node(int value, Node node)
        {
            Val = value;
            Next = node;
        }
    }
}

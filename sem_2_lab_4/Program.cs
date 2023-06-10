using System;
using System.Drawing;

namespace lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashTable<string, bool> table = new HashTable<string, bool>();
        }
    }
    public class HashTable<KItem, VItem>
    {
        private int sizeTable;
        private int capacity;
        private Node[] table;
        private class Node
        {
            public KItem Key { get; }
            public VItem Value { get; }
            public Node Next { get; set; }

            public Node(KItem key, VItem value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        public HashTable()
        {
            capacity = 30;
            table = new Node[capacity];
            sizeTable = 0;
        }

        public HashTable(int intialCapacity)
        {
            capacity = intialCapacity;
            table = new Node[capacity];
            sizeTable = 0;
        }

        private int GetHash(KItem key)
        {
            return Math.Abs(key.GetHashCode() % table.Length);
        }

        public void Add(KItem key, VItem value)
        {
            
        }

        public void Remove(KItem key)
        {
            
        }

        public VItem Get(KItem key)
        {
            return default!;
        }

        public bool Contains(KItem key)
        {
            return false;
        }

        public void clear()
        {

        }

        public int size()
        {
            return sizeTable;
        }

        public void PrintContents()
        {
 
        }
    }
}

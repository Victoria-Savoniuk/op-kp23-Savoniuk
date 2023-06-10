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
            int index = GetHash(key);
            if (table[index] == null)
            {
                table[index] = new Node(key, value);
                sizeTable++;
            }
            else
            {
                Node node = table[index];
                while (node.Next != null)
                {
                    if (node.Key.Equals(key))
                    {
                        Console.WriteLine("Таке слово вже існує в словнику");
                        return;
                    }
                    node = node.Next;
                }
                if (node.Key.Equals(key))
                {
                    Console.WriteLine("Таке слово вже існує в словнику");
                }
                else
                {
                    node.Next = new Node(key, value);
                    sizeTable++;
                }
            }
        }

        public void Remove(KItem key)
        {
            
            int index = GetHash(key);
            Node node = table[index];
            Node prev = null;
            
            while (node != null)
            {
                if (node.Key.Equals(key))
                {
                    if (prev != null)
                    {
                        prev.Next = node.Next;
                        sizeTable--;
                        Console.WriteLine($"Слово {key} видалено із словника");
                    }
                    else
                    {
                        table[index] = node.Next;
                        sizeTable--;
                        Console.WriteLine($"Слово {key} видалено із словника");
                    }
                    return;
                }
                prev = node;
                node = node.Next;
            }
            Console.WriteLine("Такого слова немає в словнику");
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

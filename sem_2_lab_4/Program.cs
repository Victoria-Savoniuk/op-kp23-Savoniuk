﻿using System;
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

            public Node(KItem key, VItem value)
            {
              
            }
        }

        public HashTable()
        {

        }

        public HashTable(int intialCapacity)
        {

        }

        private int GetHash(KItem key)
        {
            return 0;
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
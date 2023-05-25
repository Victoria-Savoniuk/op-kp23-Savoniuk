using System;
namespace Lab3
{
    public class Deque<Item> : IIterator<Item>
    {
        private Node head; 
        private Node tail; 
        private int size; 
        private Node current;

        // Internal node class
        private class Node
        {
            public Item value;
            public Node prev;
            public Node next;
        }

        // Construct an empty deque
        public Deque()
        {
           
        }

        // Is the deque empty?
        public bool IsEmpty()
        {
            return true;
        }

        // Return the number of items on the deque
        public int Size()
        {
            return size;
        }

        // Add the item to the front
        public void AddFirst(Item item)
        {
           
        }

        // Add the item to the back
        public void AddLast(Item item)
        {
           
        }

        // Remove and return the item from the front
        public Item RemoveFirst()
        {
            Item value = head.value;
            return value;
        }

        // Remove and return the item from the back
        public Item RemoveLast()
        {
            Item value = tail.value;
            return value;
        }
        public IIterator<Item> iterator()
        {
            current = head;
            return this;
        }
        public bool HasNext
        {
            get { return current != null; }
        }
        public Item MoveNext()
        {
            Item value = current.value;
            current = current.next;
            return value;
        }
    }

    public interface IIterator<T>
    {
        bool HasNext { get; }
        T MoveNext();
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Deque<int> deque = new Deque<int>();
        }
    }
}
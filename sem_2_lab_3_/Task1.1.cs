using System;
namespace Lab3
{
    public class Deque<Item> : IIterator<Item>
    {
        private Node head; 
        private Node tail; 
        private int size; 
        private Node current;

        private class Node
        {
            public Item value;
            public Node prev;
            public Node next;
        }

        public Deque()
        {
           head = null;
           tail = null;
           size = 0;
           current = head;
        }

        // Is the deque empty?
        public bool IsEmpty()
        {
            if(Size() != 0)
        {
            return false;
        }
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
           if (item == null)
            throw new ArgumentNullException("item = null");

        Node newNode = new Node();
        newNode.value = item;

        if (IsEmpty())
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
        size++;
        current = head;
        }

        // Add the item to the back
        public void AddLast(Item item)
        {
           if (item == null)
            throw new ArgumentNullException("item = null");

        Node newNode = new Node();
        newNode.value = item;

        if (IsEmpty())
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.prev = tail;
            tail.next = newNode;
            tail = newNode;
        }

        size++;
        current = head;
        }

        // Remove and return the item from the front
        public Item RemoveFirst()
        {
             if (IsEmpty())
            throw new InvalidOperationException("Deque is empty");

        Item value = head.value;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            head = head.next;
            head.prev = null;
        }

        size--;
        current = head;
        return value;
        }

        // Remove and return the item from the back
        public Item RemoveLast()
        {
            if (IsEmpty())
            throw new InvalidOperationException("Deque is empty");

        Item value = tail.value;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            tail = tail.prev;
            tail.next = null;
        }

        size--;
        current = head;
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
            if (!HasNext)
	{
            throw new InvalidOperationException("No more items in the deque");
	}
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
using System;
namespace Lab3
{
    public class RandomizedQueue<Item> : IIterator<Item>
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

        // construct an empty randomized queue
        public RandomizedQueue()
        {
 
        }

        // is the randomized queue empty?
        public bool IsEmpty()
        {
            return true;
        }

        // return the number of items on the randomized queue
        public int Size()
        {
            return size;
        }

        // add the item
        public void Enqueue(Item item)
        {
           
        }

        // remove and return a random item
        public Item Dequeue()
        {
            int randomIndex = new Random().Next(size);
            Node randomValue = head;
            return randomValue.value;
        }

        // return a random item (but do not remove it)
        public Item Sample()
        {
            int randomIndex = new Random().Next(size);
            Node randomValue = head;
            return randomValue.value;
        }

        // return an independent iterator over items in random order
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
            RandomizedQueue<int> queue = new RandomizedQueue<int>();
        }
    }
}
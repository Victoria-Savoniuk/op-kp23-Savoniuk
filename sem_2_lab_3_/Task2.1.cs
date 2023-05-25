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
            head = null;
            tail = null;
            size = 0;
            current = head;
        }

        // is the randomized queue empty?
        public bool IsEmpty()
        {
            if (Size() != 0)
            {
                return false;
            }
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

        // remove and return a random item
        public Item Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("RandomizedQueue is empty.");

            int randomIndex = new Random().Next(size);
            Node randomValue = head;
            while (randomIndex > 0)
            {
                randomValue = randomValue.next;
                randomIndex--;
            }

            if (randomValue.prev != null)
            {
                randomValue.prev.next = randomValue.next;
            }
            else
            {
                head = randomValue.next;
            }

            if (randomValue.next != null)
            {
                randomValue.next.prev = randomValue.prev;
            }
            else
            {
                tail = randomValue.prev;
            }
            size--;
            current = head;
            return randomValue.value;
        }

        // return a random item (but do not remove it)
        public Item Sample()
        {
            if (IsEmpty())
                throw new InvalidOperationException("RandomizedQueue is empty.");

            int randomIndex = new Random().Next(size);
            Node randomValue = head;
            while (randomIndex > 0)
            {
                randomValue = randomValue.next;
                randomIndex--;
            }
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
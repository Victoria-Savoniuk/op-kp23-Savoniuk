using System;
namespace Lab3
{
    public class Deque<Item> : IIterator<Item>
    {
        public Item[] array;
        private int head;
        private int tail;
        private int size;
        private int current;
        private int capacity;

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
            Item value = array[head];
            return value;
        }

        // Remove and return the item from the back
        public Item RemoveLast()
        {
            Item value = array[tail];
            return value;
        }
        private void Resize()
        {

        }
        public IIterator<Item> iterator()
        {
            current = head;
            return this;
        }
        public bool HasNext
        {
            get { return current <= tail; }
        }
        public Item MoveNext()
        {
            if (!HasNext)
            {
                throw new InvalidOperationException("No more items in the deque");
            }

            Item value = array[current];
            current++;
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
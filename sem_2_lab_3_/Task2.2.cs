using System;
namespace Lab3
{
    public class RandomizedQueue<Item> : IIterator<Item>
    {
        private Item[] array;
        private int capacity;
        private int size;
        private int head;
        private int tail;
        private int current;

        // Construct an empty randomized queue
        public RandomizedQueue()
        {
            
        }

        // Is the randomized queue empty?
        public bool IsEmpty()
        {
            return true;
        }

        // Return the number of items on the randomized queue
        public int Size()
        {
            return size;
        }

        private void Resize()
        {

        }

        // Add the item
        public void Enqueue(Item item)
        {
 
        }

        // Remove and return a random item
        public Item Dequeue()
        {
            int randomIndex = new Random().Next(size);
            Item item = array[randomIndex];
            return item;
        }

        // Return a random item (but do not remove it)
        public Item Sample()
        {
            int randomIndex = new Random().Next(size);
            return array[randomIndex];
        }

        // Return an independent iterator over items in random order
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
            RandomizedQueue<int> queue = new RandomizedQueue<int>();
            
        }
    }
}

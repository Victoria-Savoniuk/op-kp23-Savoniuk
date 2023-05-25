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
            capacity = 30;
            array = new Item[capacity];
            size = 0;
            head = tail = -1;
            current = head;
        }

        // Is the randomized queue empty?
        public bool IsEmpty()
        {
            if (Size() != 0)
            {
                return false;
            }
            return true;
        }

        // Return the number of items on the randomized queue
        public int Size()
        {
            return size;
        }

        private void Resize()
        {
            Item[] newArray = new Item[capacity * 2];
            for(int i = 0; i <= tail; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
            head = 0;
            tail = size - 1;
        }

        // Add the item
        public void Enqueue(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item cannot be null.");
            }

            if (size == capacity)
            {
                Resize();
            }

            if (head == -1)
            {
                head = tail = 0;
            }
            else
            {
                tail = tail + 1;
            }
            array[tail] = item;
            size++;
            current = head;
        }

        // Remove and return a random item
        public Item Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Randomized queue is empty.");
            }

            int randomIndex = new Random().Next(size);
            Item item = array[randomIndex];
            for(int i = randomIndex; i < tail; i++)
            {
                array[i] = array[i+1];
            }
            tail = tail-1;
            size--;
            current = head;
            return item;
        }

        // Return a random item (but do not remove it)
        public Item Sample()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Randomized queue is empty.");
            }

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

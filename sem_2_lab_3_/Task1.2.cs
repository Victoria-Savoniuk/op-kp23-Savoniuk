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
            capacity = 30;
            array = new Item[capacity];
            head = -1;
            tail = -1;
            size = 0;
            current = head;
        }

        // Is the deque empty?
        public bool IsEmpty()
        {
            if (Size() != 0)
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
            {
                throw new ArgumentNullException("Item cannot be null.");
            }

            if (size == capacity)
            {
                Resize();
            }

            if (head == -1)
            {
                head = tail = capacity / 2;
            }
            else if (head == 0)
            {
                Resize();
                AddFirst(item);
            }
            else
            {
                head = head - 1;
            }
            array[head] = item;
            size++;
            current = head;
        }

        // Add the item to the back
        public void AddLast(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item cannot be null.");
            }

            if (size == capacity)
            {
                Resize();
            }

            if (tail == -1)
            {
                head = tail = capacity / 2;
            }
            else if (tail == capacity)
            {
                Resize();
                AddLast(item);
            }
            else
            {
                tail = tail + 1;
            }
            array[tail] = item;
            size++;
            current = head;
        }

        // Remove and return the item from the front
        public Item RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Deque is empty");
            }

            Item value = array[head];

            if (head == tail)
            {
                head = tail = -1;
            }
            else
            {
                head = head + 1;
            }

            size--;
            current = head;
            return value;
        }

        // Remove and return the item from the back
        public Item RemoveLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Deque is empty");
            }

            Item value = array[tail];

            if (head == tail)
            {
                head = tail = -1;
            }
            else
            {
                tail = tail - 1;
            }
            size--;
            current = head;
            return value;
        }
        private void Resize()
        {
            Item[] newArray = new Item[capacity * 2];
            int j = 0;
            for (int i = head; i <= tail; i++)
            {
                newArray[i] = array[j];
                j++;
            }
            array = newArray;
            capacity = capacity * 2;
            head = 0;
            tail = size - 1;
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
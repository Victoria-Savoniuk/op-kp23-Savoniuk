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
            IIterator<int> it = deque;

            string[] options = { "Add an element to the head of the deque", "Add an element to the tail of the deque",
            "Remove an element from the head of the deque", "Remove an element from the tail of the deque", "Show deque", "Unit Test" };
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Use the arrow keys to select a command:");
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.Write("> ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(options[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex--;
                        if (selectedIndex < 0)
                        {
                            selectedIndex = options.Length - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex++;
                        if (selectedIndex >= options.Length)
                        {
                            selectedIndex = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        if (options[selectedIndex] == "Add an element to the head of the deque")
                        {
                            while (true)
                            {
                                Console.WriteLine("The size of the deque: " + deque.Size());
                                Console.WriteLine("Deque items: ");
                                showIterator(deque);
                                Console.WriteLine("Enter the element you want to add:");
                                int item = Convert.ToInt32(Console.ReadLine());
                                deque.AddFirst(item);
                                Console.WriteLine("Size of deque after addition: " + deque.Size());
                                Console.WriteLine("Deque items after adding: ");
                                showIterator(deque);
                                Console.WriteLine("To go back press Esc");
                                int esc = ' ';
                                esc = (int)Console.ReadKey().Key;
                                while (esc != 27)
                                {
                                    esc = (int)Console.ReadKey().Key;
                                }
                                Console.Clear();
                                break;
                            }
                        }
                        else if (options[selectedIndex] == "Add an element to the tail of the deque")
                        {
                            while (true)
                            {
                                Console.WriteLine("The size of the deque: " + deque.Size());
                                Console.WriteLine("Deque items: ");
                                showIterator(deque);
                                Console.WriteLine("Enter the element you want to add:");
                                int item = Convert.ToInt32(Console.ReadLine());
                                deque.AddLast(item);
                                Console.WriteLine("Size of deque after addition: " + deque.Size());
                                Console.WriteLine("Deque items after adding: ");
                                showIterator(deque);
                                Console.WriteLine("To go back press Esc");
                                int esc = ' ';
                                esc = (int)Console.ReadKey().Key;
                                while (esc != 27)
                                {
                                    esc = (int)Console.ReadKey().Key;
                                }
                                Console.Clear();
                                break;
                            }
                        }
                        else if (options[selectedIndex] == "Remove an element from the head of the deque")
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Deque size to delete: " + deque.Size());
                                Console.WriteLine("Deque items: ");
                                showIterator(deque);
                                deque.RemoveFirst();
                                Console.WriteLine("Size of deque after deletion: " + deque.Size());
                                Console.WriteLine("Deque items after removal: ");
                                showIterator(deque);
                                Console.WriteLine("To go back press Esc");
                                int esc = ' ';
                                esc = (int)Console.ReadKey().Key;
                                while (esc != 27)
                                {
                                    esc = (int)Console.ReadKey().Key;
                                }
                                Console.Clear();
                                break;
                            }
                        }
                        else if (options[selectedIndex] == "Remove an element from the tail of the deque")
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Deque size to delete: " + deque.Size());
                                Console.WriteLine("Deque items: ");
                                showIterator(deque);
                                deque.RemoveLast();
                                Console.WriteLine("Size of deque after deletion: " + deque.Size());
                                Console.WriteLine("Deque items after removal: ");
                                showIterator(deque);
                                Console.WriteLine("To go back press Esc");
                                int esc = ' ';
                                esc = (int)Console.ReadKey().Key;
                                while (esc != 27)
                                {
                                    esc = (int)Console.ReadKey().Key;
                                }
                                Console.Clear();
                                break;
                            }
                        }
                        else if (options[selectedIndex] == "Show deque")
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("The size of the deque: " + deque.Size());
                                Console.WriteLine("Deque items: ");
                                showIterator(deque);
                                Console.WriteLine("To go back press Esc");
                                int esc = ' ';
                                esc = (int)Console.ReadKey().Key;
                                while (esc != 27)
                                {
                                    esc = (int)Console.ReadKey().Key;
                                }
                                Console.Clear();
                                break;
                            }
                        }
                        else if (options[selectedIndex] == "Unit Test")
                        {
                            while (true)
                            {
                                Console.Clear();
                                UnitTest();
                                Console.WriteLine("To go back press Esc");
                                int esc = ' ';
                                esc = (int)Console.ReadKey().Key;
                                while (esc != 27)
                                {
                                    esc = (int)Console.ReadKey().Key;
                                }
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                }
            }
            static void showIterator(Deque<int> deque)
            {
                IIterator<int> it = deque.iterator();

                if (deque.Size() == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    while (it.HasNext)
                    {
                        int num = it.MoveNext();
                        Console.WriteLine(num);
                    }
                }
            }
            static void UnitTest()
            {
                Deque<int> dq = new Deque<int>();
                Console.WriteLine("----------------------------");
                Console.WriteLine("Deque items: ");
                showIterator(dq);

                if (dq.IsEmpty() == true)
                {
                    Console.WriteLine("The empty property showed true");

                }
                else
                {
                    Console.WriteLine("Error!");
                }
                if (dq.Size() == 0)
                {
                    Console.WriteLine("Size = " + dq.Size());
                    Console.WriteLine("The size was shown correctly!");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                Console.WriteLine("----------------------------");
                //Add items::
                dq.AddFirst(2);
                dq.AddFirst(1);
                dq.AddFirst(3);
                dq.AddLast(4);
                dq.AddLast(5);
                dq.AddLast(6);
                Console.WriteLine("Deque items: ");
                showIterator(dq);
                Console.WriteLine("----------------------------");
                // Removed First Item
                if (dq.RemoveFirst() == 3)
                {
                    Console.WriteLine("The first item has been removed");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                Console.WriteLine("Deque items: ");
                showIterator(dq);
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                Console.WriteLine("----------------------------");
                // Removed Last Item
                if (dq.RemoveLast() == 6)
                {
                    Console.WriteLine("Last item removed!");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                Console.WriteLine("Deque items: ");
                showIterator(dq);
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                Console.WriteLine("----------------------------");
                if (dq.Size() == 4)
                {
                    Console.WriteLine("Size = " + dq.Size());
                    Console.WriteLine("The size was shown correctly!");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                Console.WriteLine();

                if (dq.IsEmpty() == false)
                {
                    Console.WriteLine("The empty property showed false");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                /* The strings were shown in such order:
                 * 1
                 * 2
                 * 4
                 * 5
                 */
                Console.WriteLine("----------------------------");
                Console.WriteLine("Testing iterator:");
                showIterator(dq);
                Console.WriteLine("----------------------------");
            }
        }
    }
}
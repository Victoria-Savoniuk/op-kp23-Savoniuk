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
            IIterator<int> it = queue;

            string[] options = { "Add item to Randomized Queue", "Remove and return a random element from the Randomized Queue",
            "Return a random element from the Randomized Queue (but without removing it)", "Show Randomized Queue", "Unit Test" };
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
                        if (options[selectedIndex] == "Add item to Randomized Queue")
                        {
                            while (true)
                            {
                                Console.WriteLine("The size of the deque: " + queue.Size());
                                Console.WriteLine("Randomized Queue items: ");
                                showIterator(queue);
                                Console.WriteLine("Enter the element you want to add:");
                                int item = Convert.ToInt32(Console.ReadLine());
                                queue.Enqueue(item);
                                Console.WriteLine("Size of deque after addition: " + queue.Size());
                                Console.WriteLine("Deque items after adding: ");
                                showIterator(queue);
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
                        else if (options[selectedIndex] == "Remove and return a random element from the Randomized Queue")
                        {
                            while (true)
                            {
                                if(queue.Size() == 0)
                                {
                                    Console.WriteLine("Randomized Queue is empty");
                                }
                                else
                                {
                                    Console.WriteLine("Size of Randomized Queue before deletion: " + queue.Size());
                                    Console.WriteLine("Randomized Queue items: ");
                                    showIterator(queue);
                                    int num = queue.Dequeue();
                                    Console.WriteLine("A random element has been removed: " + num);
                                    Console.WriteLine("Size of Randomized Queue after deletion: " + queue.Size());
                                    Console.WriteLine("Randomized Queue items after deletion: ");
                                    showIterator(queue);
                                }
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
                        else if (options[selectedIndex] == "Return a random element from the Randomized Queue (but without removing it)")
                        {
                            while (true)
                            {
                                Console.Clear();
                                if (queue.Size() == 0)
                                {
                                    Console.WriteLine("Randomized Queue is empty");
                                }
                                else
                                {
                                    Console.WriteLine("The size of the Randomized Queue: " + queue.Size());
                                    Console.WriteLine("Randomized Queue items: ");
                                    showIterator(queue);
                                    int num = queue.Sample();
                                    Console.WriteLine("Random element: " + num);
                                }  
                                Console.WriteLine("To go back press Esc");
                                int esc = ' ';
                                esc = (int)Console.ReadKey().Key;
                                if (esc == 27)
                                {
                                    Console.Clear();
                                    break;
                                }
                                Console.Clear();
                            }
                        }
                        else if (options[selectedIndex] == "Show Randomized Queue")
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("The size of the Randomized Queue: " + queue.Size());
                                Console.WriteLine("Randomized Queue items: ");
                                showIterator(queue);
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
            static void showIterator(RandomizedQueue<int> deque)
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
        }
    }
}
using System;
using System.Drawing;

namespace lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Бажаєте ввести розмір геш-таблиці?");
                Console.WriteLine("1. Так");
                Console.WriteLine("2. Ні");

                Console.Write("Виберіть опцію: ");
                string option = Console.ReadLine();

                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();

                        Console.WriteLine("Введіть розмір геш-таблиці: ");
                        size = Convert.ToInt32(Console.ReadLine());
                        while (size <= 0)
                        {
                            Console.WriteLine("Розмір геш-таблиці має бути більша за 0! Повторіть спробу!");
                            Console.WriteLine("Введіть розмір геш-таблиці: ");
                            size = Convert.ToInt32(Console.ReadLine());
                        }
                        flag = false;
                        break;
                    case "2":
                        size = 0;
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Невірна опція. Спробуйте ще раз.");
                        break;
                }
            }

            HashTable<string, bool> table;

            if (size == 0)
            {
                table = new HashTable<string, bool>();
            }
            else
            {
                table = new HashTable<string, bool>(size);
            }

            while (true)
            {
                Console.WriteLine("1. Додати слово");
                Console.WriteLine("2. Видалити слово");
                Console.WriteLine("3. Вивести слово");
                Console.WriteLine("4. Перевірити чи існує дане слово в словнику");
                Console.WriteLine("5. Вивести розмір словника");
                Console.WriteLine("6. Очистити словник");
                Console.WriteLine("7. Вивести вміст словника");
                Console.WriteLine("8. Вийти");

                Console.Write("Виберіть опцію: ");
                string option = Console.ReadLine();
                int esc = ' ';

                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        bool go = true;
                        while (go)
                        {
                            Console.Clear();
                            string key;
                            Console.WriteLine("Введіть слово");
                            key = Console.ReadLine();
                            Console.WriteLine();
                            table.Add(key, true);
                            Console.WriteLine("Якщо хочете вийти натисніть Esc, якщо ні - Enter");
                            esc = (int)Console.ReadKey().Key;
                            if (esc == 27)
                            {
                                Console.Clear();
                                go = false;
                            }
                            Console.Clear();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Введіть слово");
                        Console.WriteLine();
                        table.Remove(Console.ReadLine());
                        Console.WriteLine("Якщо хочете вийти натисніть Esc");
                        esc = (int)Console.ReadKey().Key;
                        while (esc != 27)
                        {
                            esc = (int)Console.ReadKey().Key;
                        }
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Введіть слово");
                        bool word = table.Get(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine(word);
                        Console.WriteLine("Якщо хочете вийти натисніть Esc");
                        esc = (int)Console.ReadKey().Key;
                        while (esc != 27)
                        {
                            esc = (int)Console.ReadKey().Key;
                        }
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Введіть слово");
                        Console.WriteLine();
                        if (table.Contains(Console.ReadLine()))
                        {
                            Console.WriteLine("OK");
                        }
                        else
                        {
                            Console.WriteLine("WrongSpelling");
                        }
                        Console.WriteLine("Якщо хочете вийти натисніть Esc");
                        esc = (int)Console.ReadKey().Key;
                        while (esc != 27)
                        {
                            esc = (int)Console.ReadKey().Key;
                        }
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine(table.size());
                        Console.WriteLine("Якщо хочете вийти натисніть Esc");
                        esc = (int)Console.ReadKey().Key;
                        while (esc != 27)
                        {
                            esc = (int)Console.ReadKey().Key;
                        }
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        table.clear();
                        Console.WriteLine("Якщо хочете вийти натисніть Esc");
                        esc = (int)Console.ReadKey().Key;
                        while (esc != 27)
                        {
                            esc = (int)Console.ReadKey().Key;
                        }
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        table.PrintContents();
                        Console.WriteLine("Якщо хочете вийти натисніть Esc");
                        esc = (int)Console.ReadKey().Key;
                        while (esc != 27)
                        {
                            esc = (int)Console.ReadKey().Key;
                        }
                        Console.Clear();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Невірна опція. Спробуйте ще раз.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
    public class HashTable<KItem, VItem>
    {
        private int sizeTable;
        private int capacity;
        private Node[] table;
        private class Node
        {
            public KItem Key { get; }
            public VItem Value { get; }
            public Node Next { get; set; }

            public Node(KItem key, VItem value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        public HashTable()
        {
            capacity = 30;
            table = new Node[capacity];
            sizeTable = 0;
        }

        public HashTable(int intialCapacity)
        {
            capacity = intialCapacity;
            table = new Node[capacity];
            sizeTable = 0;
        }

        private int GetHash(KItem key)
        {
            return Math.Abs(key.GetHashCode() % table.Length);
        }

        public void Add(KItem key, VItem value)
        {
            int index = GetHash(key);
            if (table[index] == null)
            {
                table[index] = new Node(key, value);
                sizeTable++;
            }
            else
            {
                Node node = table[index];
                while (node.Next != null)
                {
                    if (node.Key.Equals(key))
                    {
                        Console.WriteLine("Таке слово вже існує в словнику");
                        return;
                    }
                    node = node.Next;
                }
                if (node.Key.Equals(key))
                {
                    Console.WriteLine("Таке слово вже існує в словнику");
                }
                else
                {
                    node.Next = new Node(key, value);
                    sizeTable++;
                }
            }
        }

        public void Remove(KItem key)
        {
            
            int index = GetHash(key);
            Node node = table[index];
            Node prev = null;
            
            while (node != null)
            {
                if (node.Key.Equals(key))
                {
                    if (prev != null)
                    {
                        prev.Next = node.Next;
                        sizeTable--;
                        Console.WriteLine($"Слово {key} видалено із словника");
                    }
                    else
                    {
                        table[index] = node.Next;
                        sizeTable--;
                        Console.WriteLine($"Слово {key} видалено із словника");
                    }
                    return;
                }
                prev = node;
                node = node.Next;
            }
            Console.WriteLine("Такого слова немає в словнику");
        }

        public VItem Get(KItem key)
        {
            int index = GetHash(key);
            Node node = table[index];

            while (node != null)
            {
                if (node.Key.Equals(key))
                {
                    Console.WriteLine(node.Key);
                    return node.Value;
                }
                node = node.Next;
            }
            Console.WriteLine("Такого слова немає в словнику");
            return default!;
        }

        public bool Contains(KItem key)
        {
            int index = GetHash(key);
            Node node = table[index];

            while (node != null)
            {
                if (node.Key.Equals(key))
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        public void clear()
        {
            table = new Node[capacity];
            sizeTable = 0;
            Console.WriteLine("Словник очищено");
        }

        public int size()
        {
            return sizeTable;
        }

        public void PrintContents()
        {
            Console.WriteLine("Словник:");
            for (int index = 0; index < capacity; index++)
            {
                Console.WriteLine($"Індекс {index}:");
                Node node = table[index];
                if (node == null)
                {
                    Console.WriteLine("");
                }
                else
                {
                    while (node != null)
                    {
                        Console.WriteLine($"Слово: {node.Key}");

                        node = node.Next;
                        if (node != null)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("_________________________");
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}

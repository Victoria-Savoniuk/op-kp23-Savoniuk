using System;
namespace Labs2
{
    class Percolation
    {
        static public int counter = 0;
        static public int number_Percolates = -2;

        static void Init(int n, int[] matrix)
        {
            for (int i = 0; i < n * n; i++)
            {
                matrix[i] = -1;
            }
        }

        static void Open(int row, int col, int n, int[] matrix)
        {
            if (!(IsOpen(row, col, n, matrix)))
            {
                matrix[GetIndex(row, col, n)] = GetIndex(row, col, n);
                NumberOfOpenSites();
            }
            else
            {
                Console.WriteLine("This cell is already open, try to open another");
            }
        }

        static int GetIndex(int row, int col, int n)
        {
            return (row - 1) * n + (col - 1);
        }

        static bool IsOpen(int row, int col, int n, int[] matrix)
        {
            return matrix[GetIndex(row, col, n)] != -1;
        }
        static void NumberOfOpenSites()
        {
            counter++;
        }
        public static int Union(int p, int q, int n, int[] matrix)
        {
            int pRoot = Root(p, matrix);
            int qRoot = Root(q, matrix);

            if (matrix[pRoot] <= matrix[qRoot])
            {
                matrix[qRoot] = pRoot;

                if (q - qRoot >= n)
                {
                    int j_q = q;

                    while (j_q >= n)
                    {
                        j_q = j_q - n;
                    }

                    int i_q = (q - j_q) / n;
                    int j_qRoot = qRoot;

                    if (qRoot >= n)
                    {
                        j_qRoot = qRoot - n;
                    }

                    int i_qRoot = (qRoot - j_qRoot) / n;

                    for (int i = i_qRoot; i_q - i != 0; i++)
                    {
                        for (int j = j_qRoot; j < n; j++)
                        {
                            Connect(i, j, n, matrix);
                        }
                    }

                }

                matrix[q] = pRoot;
            }
            else
            {
                matrix[pRoot] = qRoot;
                matrix[p] = qRoot;
            }

            return matrix[qRoot];
        }

        private static int Root(int p, int[] matrix)
        {
            while (p != matrix[p])
            {
                p = matrix[p];
            }
            return p;
        }

        public static void Connect(int i, int j, int n, int[] matrix)
        {
            if (matrix[i * n + j] != -1)
            {
                if (i != 0)
                {
                    if (matrix[(i - 1) * n + j] != -1)
                    {
                        Union(i * n + j, (i - 1) * n + j, n, matrix);
                    }
                }

                if (j != 0)
                {
                    if (matrix[i * n + (j - 1)] != -1)
                    {
                        Union(i * n + j, i * n + (j - 1), n, matrix);
                    }
                }

                if (j != n - 1)
                {
                    if (matrix[i * n + (j + 1)] != -1)
                    {
                        Union(i * n + j, i * n + (j + 1), n, matrix);
                    }
                }
            }
        }

        public static bool Percolates(int[] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (matrix[i] != -1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[n * (n - 1) + j] == matrix[i])
                        {
                            number_Percolates = matrix[i];
                            Console.WriteLine();
                            Print(matrix, n, number_Percolates);
                            Console.WriteLine();
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        static void Print(int[] matrix, int n, int number_of_percolation)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i * n + j] == -1)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (matrix[i * n + j] == number_of_percolation)
                        {
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.Write("  ");
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.Write("  ");
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                    }

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            /* Test cases:
            * Open: row = 1; col = 1
            *       row = 1; col = 2
            *       row = 2; col = 2
            *       row = 2; col = 3
            *       row = 3; col = 3
            *  Output:
            *        0    0  -1
            *        -1   0   0
            *        -1  -1   0
            *        
            *    Number of open sites: 5
            *    Percolation: true
            */

            Console.WindowHeight = 30;
            Console.WindowWidth = 70;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t\t\t   Percolation");
            Console.WriteLine();

            int n = 0;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Enter the size of the n x n matrix:");

            n = Convert.ToInt32(Console.ReadLine());

            int[] matrix = new int[n * n];
            Init(n, matrix);

            int row = 0;
            int col = 0;

            int esc = ' ';

            while (true)
            {
                Console.WriteLine();
                Print(matrix, n, number_Percolates);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press Esc to exit, press Enter to continue");
                esc = (int)Console.ReadKey().Key;
                if (esc == 27)
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\t\t\t   Percolation");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Enter the row and column of the cell you want to open");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Enter row: ");
                row = Convert.ToInt32(Console.ReadLine());
                while (row < 1 || row > n)
                {
                    Console.WriteLine($"The values ​​go beyond the matrix (1, {n}). Try again.");
                    Console.Write("Enter row: ");
                    row = Convert.ToInt32(Console.ReadLine());

                }

                Console.Write("Enter col: ");
                col = Convert.ToInt32(Console.ReadLine());
                while (col < 1 || col > n)
                {
                    Console.WriteLine($"The values ​​go beyond the matrix (1, {n}). Try again.");
                    Console.Write("Enter col: ");
                    col = Convert.ToInt32(Console.ReadLine());
                }

                Open(row, col, n, matrix);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t\t\t   PPercolation");
            Console.WriteLine();

            Print(matrix, n, number_Percolates);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Connect(i, j, n, matrix);
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Number of open sites: {counter}");
            Console.WriteLine("Percolation: " + Percolates(matrix, n));
            Console.ReadKey();
        }

        static bool TestOpen(int[] matrix)
        {
            int test_n = 3;
            Open(1, 1, test_n, matrix);
            Open(1, 2, test_n, matrix);
            Open(2, 2, test_n, matrix);
            Open(2, 3, test_n, matrix);
            Open(3, 3, test_n, matrix);

            bool expected1 = true;
            bool expected2 = true;
            bool expected3 = true;
            bool expected4 = true;
            bool expected5 = true;

            bool actual1 = IsOpen(1, 1, test_n, matrix);
            bool actual2 = IsOpen(1, 2, test_n, matrix);
            bool actual3 = IsOpen(2, 2, test_n, matrix);
            bool actual4 = IsOpen(2, 3, test_n, matrix);
            bool actual5 = IsOpen(3, 3, test_n, matrix);

            if (expected1 != actual1)
            {
                Console.WriteLine("TestOpen: case1 is failed");
                return false;
            }

            if (expected2 != actual2)
            {
                Console.WriteLine("TestOpen: case2 is failed");
                return false;
            }

            if (expected3 != actual3)
            {
                Console.WriteLine("TestOpen: case3 is failed");
                return false;
            }

            if (expected4 != actual4)
            {
                Console.WriteLine("TestOpen: case4 is failed");
                return false;
            }

            if (expected5 != actual5)
            {
                Console.WriteLine("TestOpen: case5 is failed");
                return false;
            }

            Console.WriteLine("TestOpen: all cases passed");
            return true;

        }
        static bool TestGetIndex()
        {
            int expected1 = 0; // row = 1; col = 1
            int expected2 = 1; // row = 1; col = 2
            int expected3 = 4; // row = 2; col = 2
            int expected4 = 5; // row = 2; col = 3
            int expected5 = 8; // row = 3; col = 3

            int actual1 = GetIndex(1, 1, 3);
            int actual2 = GetIndex(1, 2, 3);
            int actual3 = GetIndex(2, 2, 3);
            int actual4 = GetIndex(2, 3, 3);
            int actual5 = GetIndex(3, 3, 3);

            if (expected1 != actual1)
            {
                Console.WriteLine("TestGetIndex: case1 is failed");
                return false;
            }

            if (expected2 != actual2)
            {
                Console.WriteLine("TestGetIndex: case2 is failed");
                return false;
            }

            if (expected3 != actual3)
            {
                Console.WriteLine("TestGetIndex: case3 is failed");
                return false;
            }

            if (expected4 != actual4)
            {
                Console.WriteLine("TestGetIndex: case4 is failed");
                return false;
            }

            if (expected5 != actual5)
            {
                Console.WriteLine("TestGetIndex: case5 is failed");
                return false;
            }

            Console.WriteLine("TestGetIndex: all cases passed");
            return true;
        }

        static bool TestIsOpen(int test_n, int[] matrix)
        {
            bool expected1 = false;
            bool expected2 = true;


            bool actual1 = IsOpen(1, 3, test_n, matrix);
            bool actual2 = IsOpen(1, 1, test_n, matrix);


            if (expected1 != actual1)
            {
                Console.WriteLine("TestIsOpen: case1 is failed");
                return false;
            }

            if (expected2 != actual2)
            {
                Console.WriteLine("TestIsOpen: case2 is failed");
                return false;
            }

            Console.WriteLine("TestIsOpen: all cases passed");
            return true;
        }
        static bool TestNumberOfOpenSites()
        {
            int expected = 5;

            int actual = counter;

            if (expected != actual)
            {
                Console.WriteLine("TestNumberOfOpenSites: case is failed");
                return false;
            }

            Console.WriteLine("TestNumberOfOpenSites: all cases passed");
            return true;
        }

        static bool TestUnion(int[] matrix)
        {
            int expected1 = 0; // p = matrix[0], q = matrix[1]
            int expected2 = 0; // p = matrix[1], q = matrix[4]
            int expected3 = 0; // p = matrix[4], q = matrix[5]
            int expected4 = 0; // p = matrix[5], q = matrix[8]

            int actual1 = Union(0, 1, 3, matrix);
            int actual2 = Union(1, 4, 3, matrix);
            int actual3 = Union(4, 5, 3, matrix);
            int actual4 = Union(5, 8, 3, matrix);


            if (expected1 != actual1)
            {
                Console.WriteLine("Testunion: case1 is failed");
                return false;
            }

            if (expected2 != actual2)
            {
                Console.WriteLine("Testunion: case2 is failed");
                return false;
            }

            if (expected3 != actual3)
            {
                Console.WriteLine("Testunion: case3 is failed");
                return false;
            }

            if (expected4 != actual4)
            {
                Console.WriteLine("Testunion: case4 is failed");
                return false;
            }

            Console.WriteLine("Testunion: all cases passed");
            return true;
        }

        static bool TestRoot(int[] matrix)
        {
            int expected1 = 0; // p = 0
            int expected2 = 0; // p = 1
            int expected3 = 0; // p = 4
            int expected4 = 0; // p = 5
            int expected5 = 0; // p = 8

            int actual1 = Root(0, matrix);
            int actual2 = Root(1, matrix);
            int actual3 = Root(4, matrix);
            int actual4 = Root(5, matrix);
            int actual5 = Root(8, matrix);

            if (expected1 != actual1)
            {
                Console.WriteLine("Testroot: case1 is failed");
                return false;
            }

            if (expected2 != actual2)
            {
                Console.WriteLine("Testroot: case2 is failed");
                return false;
            }

            if (expected3 != actual3)
            {
                Console.WriteLine("Testroot: case3 is failed");
                return false;
            }

            if (expected4 != actual4)
            {
                Console.WriteLine("Testroot: case4 is failed");
                return false;
            }

            if (expected5 != actual5)
            {
                Console.WriteLine("Testroot: case5 is failed");
                return false;
            }

            Console.WriteLine("Testroot: all cases passed");
            return true;
        }
        static bool TestPercolates(int[] matrix)
        {
            bool expected = true;

            bool actual = Percolates(matrix, 3);

            if (expected != actual)
            {
                Console.WriteLine("TestPercolates: case is failed");
                return false;
            }

            Console.WriteLine("TestPercolates: all cases passed");
            return true;
        }
    }
}

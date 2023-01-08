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
    }
}
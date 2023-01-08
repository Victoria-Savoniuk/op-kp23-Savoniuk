using System;
namespace Labs2
{
    class Percolation
    {
        static public int number_Percolates = -2;

        static void Init(int n, int[] matrix)
        {
            for (int i = 0; i < n * n; i++)
            {
                matrix[i] = -1;
            }
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

               
            }
        }
    }
}
using System;
namespace Labs2
{
    class Percolation
    {
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

            int n = 1;
            int[] matrix = new int[n * n];
            int row = 0;
            int col = 0;
            Console.WriteLine(matrix[row * n + col]);
        }
    }
}
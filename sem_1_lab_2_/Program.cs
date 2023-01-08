using System;
namespace Labs2
{
    class Percolation
    {
        static void Main(string[] args)
        {
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
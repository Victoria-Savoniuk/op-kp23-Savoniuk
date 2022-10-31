using System;
namespace Practice3
{

    class Program
    {
        static void Main(string[] args)

        {
            int h = 0;
            int n = 0;
            Console.WriteLine("Enter the height of the Christmas tree: ");
            int h = Convert.ToInt32(Console.ReadLine());
            while (h <= 1)
            {
                Console.WriteLine("The height of the Christmas tree must be greater than 1");
                h = Convert.ToInt32(Console.ReadLine());
            }

            int n = 1;
            for (int i = 1; i <= h * 2 - 1; i++)
            {
                Console.Write(".");

            }
            Console.WriteLine("");

            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h - i; j++)
                {
                    Console.Write(".");
                }
                for (int k = 1; k <= n; k++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= h - i; j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine("");
                n += 2;
            }

        }
    }
}
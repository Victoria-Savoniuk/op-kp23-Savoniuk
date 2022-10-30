using System;
namespace Practice3
{

    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the height of the Christmas tree: ");
            int h = Convert.ToInt32(Console.ReadLine());
            while (h <= 1)
            {
                Console.WriteLine("The height of the Christmas tree must be greater than 1");
                h = Convert.ToInt32(Console.ReadLine());
            }

            var n = 1;
            for (var i = 1; i <= h * 2 - 1; i++)
            {
                Console.Write(".");

            }
            Console.WriteLine("");

            for (var i = 1; i <= h; i++)
            {
                for (var j = 1; j <= h - i; j++)
                {
                    Console.Write(".");
                }
                for (var k = 1; k <= n; k++)
                {
                    Console.Write("*");
                }
                for (var j = 1; j <= h - i; j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine("");
                n += 2;
            }

        }
    }
}
using System;
namespace Lab1_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string end;
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter the value of n:");
                double n = Convert.ToDouble(Console.ReadLine());
                while (n < 0 || n % 1 != 0)
                {
                    while ((n % 1 != 0))
                    {
                        Console.WriteLine("To find the factorial of a number, it must be an integer. Try again.");
                        n = Convert.ToDouble(Console.ReadLine());
                    }
                    while (n < 0)
                    {
                        Console.WriteLine("To find the factorial of n, it must be positive. Try again.");
                        n = Convert.ToDouble(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter the value of x:");
                double x = Convert.ToDouble(Console.ReadLine());
                double factorial = 1;
                double pow = x;
                for (int i = 1; i <= n; i++)
                {
                factorial *= i;
                }
                Console.WriteLine($"Factorial of the number {n}: {factorial}");

                for (int j = 1; j < n; j++)
                {
                   if (n == 0)
                   {
                    pow = 1;
                   }
                   else
                   {
                    pow *= x;
                   }
                }
                Console.WriteLine($"Raising the number {x} to the power of {n} : {pow}");
                Console.WriteLine("Enter '+' to exit the program, else '-' ");
                end = Console.ReadLine();

                while (end != "+" && end != "-")
                {
                    Console.WriteLine("Enter '+' to exit the program, else '-' ");
                    end = Console.ReadLine();

                }
                if (end == "+")
                {
                    running = false;
                }

            }
        }

    }
}
using System;
namespace Lab1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the initial value x0");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the final value xn");
            double xn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter dx value:");
            double dx = Convert.ToDouble(Console.ReadLine());
            double n = (xn - x0) / dx;
            double a = -1.25;
            double b = -1.5;
            double c = 0.75;
            double x = 0;
            double y = 0;
            double pow = 0;
            for (int i = 0; i <= n; i++)
            {
                x = x0 + i * dx;
                if (x == 0)
                {
                    Console.WriteLine($"Value of x: {x}");
                    Console.WriteLine("You cannot divide by zero.");
                    Console.WriteLine();
                    continue;
                }
                if (x >= 0)
                {
                    pow = a * a * a * x;
                    Console.WriteLine($"Value of x: {x}");
                    Console.WriteLine("The expression under the root must be greater than or equal to zero.");
                    Console.WriteLine($"In this case, the expression under the root is equal to: {a}^3 * {x} = {pow} - the value is negative");
                    Console.WriteLine();
                    continue;
                }
                y = ((1 / (2 * 2)) * b * c) / x + Math.Cos(Math.Sqrt(a * a * a * x));
                Console.WriteLine($"Value of x: {x}");
                Console.WriteLine($"Value of y(x): {y}");
                Console.WriteLine();
            }
        }

    }
}
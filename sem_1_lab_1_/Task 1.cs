using System;
namespace Lab1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Test cases :
             * case 1: x0 = -1,5; xn = 3,5; dx = 0,5
             * case 2: x0 = 2; xn = -1,5; dx = 0,5
             * case 3: x0 = -2; xn = 2; dx = 0,5
             * case 4: x0 = -4,5; xn = -2; dx = 0,5
             */
            Console.WriteLine("Enter the initial value x0");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the final value xn");
            double xn = Convert.ToDouble(Console.ReadLine());
            while (xn <= x0)
            {
                Console.WriteLine("The final value of xn must be greater than the initial value of x0. Try again.");
                xn = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter dx value:");
            double dx = Convert.ToDouble(Console.ReadLine());
            while (dx <= 0)
            {
                Console.WriteLine("The number of intermediate values ​​from x0 to xn must be greater than 0. Try again.");
                dx = Convert.ToDouble(Console.ReadLine());
            }
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
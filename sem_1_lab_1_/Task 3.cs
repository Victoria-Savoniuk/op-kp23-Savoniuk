using System;
namespace Lab1_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Test cases:
             * case 1: n = -1; x = -1;
             * case 2: n = 0; x = 2;
             * case 3: n = 3,5; x = 1;
             * case 4: n = 1; x = 5;
             * case 5: n = 3; x = 2;
             * case 6: n = 2; x = 0;
             * case 7: n = 2; x = 0,5;
             */
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
            /* case 1: To find the factorial of n, it must be positive. Try again.
             * case 2: factorial = 1; pow = 1;
             * case 3: To find the factorial of a number, it must be an integer. Try again.
             * case 4: factorial = 1; pow = 5;
             * case 5: factorial = 6; pow = 8;
             * case 6: factorial = 2; pow = 0;
             * case 7: factorial = 2; pow = 0,25;
             */
        }

    }
}
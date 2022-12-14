using System;
namespace Lab1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Test cases:
             * case 1: -4;
             * case 2: 0;
             * case 3: 4,5;
             * case 4: 5;
             * case 5: 8;
             */
            double a = 0;
            double n = 0;
            string end;
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter a number:");
                a = Convert.ToDouble(Console.ReadLine());
                while (a % 1 != 0 || (a <= 1))
                {
                    while (a % 1 != 0)
                    {
                        Console.WriteLine("To check if a number is prime, the number must be an integer. Try again.");
                        a = Convert.ToDouble(Console.ReadLine());
                    }
                    while (a <= 1)
                    {
                        Console.WriteLine("To check if a number is prime, it must be greater than 1. Try again.");
                        a = Convert.ToDouble(Console.ReadLine());
                    }
                }
                for (int i = 2; i <= (a / 2); i++)
                {
                    if (a % i == 0)
                    {
                        n++;
                        break;
                    }
                    else
                    {
                        n = 0;
                    }
                }
                if (n == 0)
                {
                    Console.WriteLine("The number is prime");
                }
                else
                {
                    Console.WriteLine("The number is not prime");
                }

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
            /* case 1: To check if a number is prime, it must be greater than 1. Try again.
             * case 2: To check if a number is prime, it must be greater than 1. Try again.
             * case 3: To check if a number is prime, the number must be an integer. Try again.
             * case 4: The number is prime
             * case 5: The number is not prime
             */
        }
    }
}

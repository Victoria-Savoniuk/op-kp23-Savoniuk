using System;
namespace Lab1_Task4
{
    class Program
    {
        static double sin(double x, int n)
        {
            double factorial = 1;
            double sum = 0;
            double pow = 1;
            for (int i = 1; i <= 2 * n + 1; i++)
            {
                pow *= x;
            }
            for (int j = 1; j <= 2 * n + 1; j++)
            {
                factorial *= j;
            }
            sum = pow / factorial;
            if (n % 2 != 0)
            {
                sum *= (-1);
            }
            return sum;
        }
        static void Main(string[] args)
        {

            double eps = 0;
            double sum = 0;
            double sum1 = 0;
           
            double sum2 = 0;
            
            int n = 0;
            Console.WriteLine("Enter eps (precision):");
            eps = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of x:");
            double x = Convert.ToDouble(Console.ReadLine());
            sum1 += sin(x, n);
            Console.WriteLine($"sinx = {sum1}");
            for (n = 1; ; n++)
            {
                sum2 = sin(x, n);
                Console.WriteLine($"sinx = {sum1}");
                if (Math.Abs(sum2) < eps)
                {
                    break;
                }
                else
                {

                    sum1 += sum2;
                    

                }

            }
            double sin2 = 0;
            sin2 = Math.Sin(x);
            Console.WriteLine($"The value is calculated using the Math.Sin method: {sin2}");

        }

    }
}
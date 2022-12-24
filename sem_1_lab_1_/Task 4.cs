using System;
namespace Lab1_Task4
{
    class Program
    {
        /* Test cases:
         * case 1: x = 0; eps = 0,1;
         * case 2: x = 1; eps = 0,01;
         * case 3: x = 1; eps = 0,00000001;
         * case 4: x = -8; eps = 0,1;
         * case 5: x = -8; eps = 0,00000001
         * case 6: x = 25; eps = 0,1;
         * case 7: x = 25; eps = 0,00000001;
         * case 8: x = -20; eps = 0,1;
         * case 9: x = -20; eps = 0,00000001;
         * case 10: x = 10,5; eps = 0,00000001;
         */
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
            while (eps >= 1 || eps <= 0)
            {
                Console.WriteLine("Precision must be in the interval (0;1).(Precision must be greater than 0 but less than 1)");
                eps = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter the value of x:");
            double x = Convert.ToDouble(Console.ReadLine());
            sum1 += sin(x, n);
            for (n = 1; ; n++)
            {
                sum2 = sin(x, n);
                if (Math.Abs(sum2) < eps)
                {
                    break;
                }
                else
                {

                    sum1 += sum2;


                }

            }
            Console.WriteLine($"sin{x} = {sum1}");
            double sin2 = 0;
            sin2 = Math.Sin(x);
            Console.WriteLine($"The value is calculated using the Math.Sin method: {sin2}");

        }
        /* case 1: sin0 = 0; The value is calculated using the Math.Sin method: 0
         * case 2: sin1 = 0,8333333333333334; The value is calculated using the Math.Sin method: 0,8414709848078965
         * case 3: sin1 = 0,841470984648068; The value is calculated using the Math.Sin method: 0,8414709848078965
         * case 4: sin-8 = -1,0099619859424143; The value is calculated using the Math.Sin method: -0,9893582466233818
         * case 5: sin-8 = -0,9893582503683175; The value is calculated using the Math.Sin method: -0,9893582466233818
         * case 6: sin25 = -0,14723874342043836; The value is calculated using the Math.Sin method: -0,13235175009777303
         * case 7: sin25 = -0,13235166999771905; The value is calculated using the Math.Sin method: -0,13235175009777303
         * case 8: sin-20 = -0,9381408641193247; The value is calculated using the Math.Sin method: -0,9129452507276277
         * case 9: sin-20 = -0,9129452475579508; The value is calculated using the Math.Sin method: -0,9129452507276277
         * case 10: sin10,5 = -0,8796957586937838; The value is calculated using the Math.Sin method: -0,87969575997167
         */

    }
}
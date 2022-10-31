using System;
namespace Practise1
{


    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double D = 0;
            double x1 = 0;
            double x2 = 0;
            // a*x^2+b*x+c=0
            Console.WriteLine("Entered value for a :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entered value for b :");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entered value for c :");
            c = Convert.ToDouble(Console.ReadLine());
            D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("There aren't any roots");
            }
            else
            {
                if (D == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine("x = " + x1);
                }
                else
                {
                    x1 = (-b - Math.Sqrt(D) )/ 2 * a * c;
                    x2 = ( -b + Math.Sqrt(D)) / 2 * a * c;
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }

        }
            
    }
}

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
            double p = 0;
            double S = 0;
            Console.WriteLine("Calculator for determining the area of ​​a triangle according to Heron's formula");
            Console.WriteLine("Enter the side of the triangle a:");
            a = Convert.ToDouble(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("The side of the triangle must be greater than 0");
            }
            else
            {
                Console.WriteLine("Enter the side of the triangle b:");
                b = Convert.ToDouble(Console.ReadLine());
                if (b <= 0)
                {
                    Console.WriteLine("The side of the triangle must be greater than 0");
                }
                else
                {
                    Console.WriteLine("Enter the side of the triangle c:");
                    c = Convert.ToDouble(Console.ReadLine());
                    if (c <= 0)
                    {
                        Console.WriteLine("The side of the triangle must be greater than 0");
                    }
                    else
                    {
                        p = (a + b + c) / 2;
                        S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine("The area of ​​the triangle is: " + S);
                    }
                }
            }
        }
    }
}
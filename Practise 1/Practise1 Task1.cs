using System;
namespace Practise1
{
    class Program 
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int min = 0;
            Console.WriteLine("Enter value for a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for c:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for d:");
            d = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                min = a;
                if (c < min)
                {
                    min = c;
                    if (d < min)
                    {
                        min = d;
                        Console.WriteLine("min: " + min);
                    }
                    else
                    {
                        Console.WriteLine("min: " + min);
                    }
                }
                else
                {
                    if (d < min)
                    {
                        min = d;
                        Console.WriteLine("min: " + min);
                    }
                    else
                    {
                        Console.WriteLine("min: " + min);
                    }
                }
            }
            else
            {
                min = b;
                if (c < min)
                {
                    min = c;
                    if (d < min)
                    {
                        min = d;
                        Console.WriteLine("min: " + min);
                    }
                    else
                    {
                        Console.WriteLine("min: " + min);
                    }
                }
                else
                {
                    if (d < min)
                    {
                        min = d;
                        Console.WriteLine("min: " + min);
                    }
                    else
                    {
                        Console.WriteLine("min: " + min);
                    }
                }
            }
        }
    }
}
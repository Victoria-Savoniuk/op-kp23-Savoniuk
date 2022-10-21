using System;
namespace Practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0;
            double y1 = 0;
            double z1 = 0;
            double x2 = 0;
            double y2 = 0;
            double z2 = 0;
            double mod = 0;
            Console.WriteLine("Calculating the modulus of a vector");
            Console.WriteLine("Enter the coordinates (x1, y1, z1) of point A: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates (x2, y2, z2) of point B:");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            z2 = Convert.ToDouble(Console.ReadLine());
            mod = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2)));
            Console.WriteLine("The module of vector AB is :" + mod);
        }
    }
}
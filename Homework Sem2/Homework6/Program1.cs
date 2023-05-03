using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 5;
            double width = 10;
            double radius = 10;

            // Rectangle
            double rectArea = CalculateRectangleArea(length, width);
            double rectPerimeter = CalculateRectanglePerimeter(length, width);

            Console.WriteLine("Rectangle");
            Console.WriteLine("Square is: " + rectArea);
            Console.WriteLine("Perimeter is: " + rectPerimeter);

            bool isSquare = IsRectangleSquare(length, width);
            if (isSquare)
            {
                Console.WriteLine("This rectangle is also a square.");
            }
            else
            {
                Console.WriteLine("I am Rectangle");
                Console.WriteLine(isSquare);
            }

            Console.WriteLine("================");

            // Circle
            double circleArea = CalculateCircleArea(radius);
            double circlePerimeter = CalculateCirclePerimeter(radius);

            Console.WriteLine("Circle");
            Console.WriteLine("Square is: " + circleArea);
            Console.WriteLine("Perimeter is: " + circlePerimeter);

            Console.WriteLine("=================");
        }

        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        static double CalculateRectanglePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static bool IsRectangleSquare(double length, double width)
        {
            return length == width;
        }

        static double CalculateCircleArea(double radius)
        {
            double PI = 3.14;
            return PI * radius * radius;
        }

        static double CalculateCirclePerimeter(double radius)
        {
            double PI = 3.14;
            return 2 * PI * radius;
        }
    }
}
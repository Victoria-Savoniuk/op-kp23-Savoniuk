using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 10);
            Circle c = new Circle(10);

            // Rectangle
            double rectArea = CalculateRectangleArea(r);
            double rectPerimeter = CalculateRectanglePerimeter(r);

            Console.WriteLine("Rectangle");
            Console.WriteLine("Square is: " + rectArea);
            Console.WriteLine("Perimeter is: " + rectPerimeter);

            bool isSquare = IsRectangleSquare(r);
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
            double circleArea = CalculateCircleArea(c);
            double circlePerimeter = CalculateCirclePerimeter(c);

            Console.WriteLine("Circle");
            Console.WriteLine("Square is: " + circleArea);
            Console.WriteLine("Perimeter is: " + circlePerimeter);

            Console.WriteLine("=================");
        }

        static double CalculateRectangleArea(Rectangle r)
        {
            return r.length * r.width;
        }

        static double CalculateRectanglePerimeter(Rectangle r)
        {
            return 2 * (r.length + r.width);
        }

        static bool IsRectangleSquare(Rectangle r)
        {
            return r.length == r.width;
        }

        static double CalculateCircleArea(Circle c)
        {
            double PI = 3.14;
            return PI * c.radius * c.radius;
        }

        static double CalculateCirclePerimeter(Circle c)
        {
            double PI = 3.14;
            return 2 * PI * c.radius;
        }
    }
    class Rectangle
    {
        public double length;
        public double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
    }

    class Circle
    {
        private double PI = 3.14;
        public int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
    }
}
using System;
namespace Vector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int v1_Length = 0;
            int[] vector1 = new int[v1_Length];
            for (int i = 0; i < v1_Length; i++)
            {
                vector1[i] = 0;
            }

            int v2_Length = 0;
            int[] vector2 = new int[v2_Length];
            for (int i = 0; i < v2_Length; i++)
            {
                vector2[i] = 0;
            }

            Vector v1 = new Vector(vector1);
            Vector v2 = new Vector(vector2);

            Console.WriteLine("Sum of negative elements: " + (v1 + v2));
            Console.WriteLine("Product of even elements: " + (v1 * v2));
            Console.WriteLine("Number of elements equal to zero: " + (v1 == v2));
        }
    }
    public class Vector
    {
        private int[] _elements;

        public Vector(int[] elements)
        {
            _elements = elements;
        }
        public static int operator +(Vector v1, Vector v2)
        {
            int result = 0;
            return result;
        }
        public static int operator *(Vector v1, Vector v2)
        {
            int result = 1;
            return result;
        }
        public static int operator ==(Vector v1, Vector v2)
        {
            int count = 0;
            return count;
        }
        public static int operator !=(Vector v1, Vector v2)
        {
            int count = 0;
            return count;
        }
    }
}
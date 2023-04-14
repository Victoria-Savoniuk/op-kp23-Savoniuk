using System;
namespace Vector
{
    public class Program
    {
        /*    Test cases:
         *      Case 1:
         *    Input:
         *    v1_Length = -1;
         *    Output:
         *    Vector length must be greater than 0. Try again
         *      Case 2:
         *    Input:
         *    v1_Length = 1;
         *    Enter the elements of vector 1:
         *    1
         *    v2_Length = 0;
         *    Output:
         *    Vector length must be greater than 0. Try again
         *      Case 3:
         *    Input:
         *    v1_Length = 1;
         *    Enter the elements of vector 1:
         *    1
         *    v2_Length = 3;
         *    Enter the length of vector 2: 
         *    -1
         *    0
         *    2
         *    Output:
         *    Sum of negative elements: -1
         *    Product of even elements: -2
         *    Number of elements equal to zero: 1
         */
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
            for (int i = 0; i < v1._elements.Length; i++)
            {
                if (v1._elements[i] < 0)
                {
                    result += v1._elements[i];
                }
            }
            for (int i = 0; i < v2._elements.Length; i++)
            {
                if (v2._elements[i] < 0)
                {
                    result += v2._elements[i];
                }
            }
            return result;
        }
        public static int operator *(Vector v1, Vector v2)
        {
            int result = 1;
            for (int i = 0; i < v1._elements.Length; i += 2)
            {
                result *= v1._elements[i];
            }
            for (int i = 0; i < v2._elements.Length; i += 2)
            {
                result *= v2._elements[i];
            }
            return result;
        }
        public static int operator ==(Vector v1, Vector v2)
        {
            int count = 0;
            for (int i = 0; i < v1._elements.Length; i ++)
            {
                if (v1._elements[i] == 0)
                {
                    count++;
                }
            }
            for (int i = 0; i < v2._elements.Length; i++)
            {
                if (v2._elements[i] == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static int operator !=(Vector v1, Vector v2)
        {
            int count = 0;
            for (int i = 0; i < v1._elements.Length; i ++)
            {
                if (v1._elements[i] != 0)
                {
                    count++;
                }
            }
            for (int i = 0; i < v2._elements.Length; i++)
            {
                if (v2._elements[i] != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
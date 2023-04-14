using System;
namespace Vessel
{
    public class Program
    {   
        /*Test cases:
         *    Case 1:
         *  Input:
         *  num = 0;
         *  Output:
         *  Такого номера судна немає. Повторіть спробу.
         *      Case 2:
         *  Input:
         *  num = 1;
         *  Output:
         *  Підготовка парусника до руху
         *  Парусник пливе
         *      Case 3:
         *  Input:
         *  num = 2;
         *  Output:
         *  Підготовка підводного човна до руху
         *  Підводний човен пірнає
         */
        public static void Main(string[] args)
        {
            IVessel vessel1 = new SailingVessel();
            IVessel vessel2 = new Submarine();
            
        }
    }
    public interface IVessel
    {
        void PrepareToMovement();
        void Move();
    }
    public class SailingVessel : IVessel
    {
        public void PrepareToMovement()
        {
            Console.WriteLine("Підготовка парусника до руху");
        }
        public void Move()
        {
            Console.WriteLine("Парусник пливе");
        }
    }
    public class Submarine : IVessel
    {
        public void PrepareToMovement()
        {
            Console.WriteLine("Підготовка підводного човна до руху");
        }
        public void Move()
        {
            Console.WriteLine("Підводний човен пірнає");
        }
    }
}
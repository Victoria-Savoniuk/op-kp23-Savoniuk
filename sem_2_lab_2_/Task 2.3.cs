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
    }
    public class SailingVessel : IVessel
    {
    }
    public class Submarine : IVessel
    {
    }
}
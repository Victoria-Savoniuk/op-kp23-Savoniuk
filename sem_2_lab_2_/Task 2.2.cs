using System;
namespace Vessel
{
    public class Program
    {
        public static void Main()
        {
                Vessel vessel1 = new SailingVessel();
                Vessel vessel2 = new Submarine();
        }
    }
    public class Vessel
    {
        public virtual void PrepareToMovement()
        {
            Console.WriteLine("Підготовка судна до руху");
        }
        public virtual void Move()
        {
            Console.WriteLine("Рух судна");
        }
    }
    public class SailingVessel : Vessel
    {
    }
    public class Submarine : Vessel
    {
    }
}
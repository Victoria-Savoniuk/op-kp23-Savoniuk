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
        public override void PrepareToMovement()
        {
            Console.WriteLine("Підготовка парусника до руху");
        }
        public override void Move()
        {
            Console.WriteLine("Парусник пливе");
        }
    }
    public class Submarine : Vessel
    {
    }
}
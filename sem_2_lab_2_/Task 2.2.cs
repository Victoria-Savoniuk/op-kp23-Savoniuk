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
    }
    public class SailingVessel : Vessel
    {
    }
    public class Submarine : Vessel
    {
    }
}
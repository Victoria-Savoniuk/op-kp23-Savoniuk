using System;
namespace Vessel
{
    public class Program
    {   
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
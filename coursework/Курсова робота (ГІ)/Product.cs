using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public string PathImage { get; set; }
        public int Quantity { get; set; }
        
        public virtual string DisplayInfo()
        {
            return ($"Name: {Name} \r\nPrice: {Price} UAN \r\nUnit: {Unit}");
        }
    }
}

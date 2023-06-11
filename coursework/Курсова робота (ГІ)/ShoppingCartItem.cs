using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string ClothingSize { get; set; }
        public int FootwearSize { get; set; }
    }
}

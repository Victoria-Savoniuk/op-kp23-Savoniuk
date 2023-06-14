using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Footwear : Product
    {
        public string material { get; set; }

        private Dictionary<int, int> sizes { get; set; }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public Dictionary<int, int> Sizes
        {
            get { return sizes; }
            set { sizes = value; }
        }
        public Footwear()
        {
            sizes = new Dictionary<int, int>();
        }
        public int totalQuantity()
        {
            Quantity = 0;
            foreach (var size in Sizes)
            {
                Quantity += size.Value;
            }
            return Quantity;
        }
        public override string DisplayInfo()
        {
            string message = base.DisplayInfo();
            message += ($"\r\nMaterial: {Material}");
            message += ("\r\nAvailable Sizes:");
            foreach (var size in Sizes)
            {
                message += ($"\r\nSize: {size.Key}, Quantity: {size.Value}");
            }
            message += "\r\nTotal Quantity:" + totalQuantity();
            return message;
        }
    }
}

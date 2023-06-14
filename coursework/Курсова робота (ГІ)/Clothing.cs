using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Clothing : Product
    {
        public Dictionary<string, int> Sizes { get; set; }

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
            string message = base.DisplayInfo() + "\r\nAvailable Sizes:";

            foreach (var size in Sizes)
            {
                message += ($"\r\nSize: {size.Key}, Quantity: {size.Value}");
            }
            message += "\r\nTotal Quantity:" + totalQuantity();
            return message;
        }
    }
}

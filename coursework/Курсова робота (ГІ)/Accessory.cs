using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Accessory : Product
    {
        public override string DisplayInfo()
        {
            string message = base.DisplayInfo();
            message += $"\r\nQuantity: {Quantity}";
            return message;
        }
    }
}

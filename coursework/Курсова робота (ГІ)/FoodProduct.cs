using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class FoodProduct : Product
    {
        private string lastImportDate { get; set; }
        private string expiryTerm { get; set; }
        public string LastImportDate
        {
            get { return lastImportDate; }
            set { lastImportDate = value; }
        }

        public string ExpiryTerm
        {
            get { return expiryTerm; }
            set { expiryTerm = value; }
        }

        public override string DisplayInfo()
        {
            string message = base.DisplayInfo();
            message += ($"\r\nQuantity: {Quantity} \r\nLast Import Date: {LastImportDate} \r\nExpiry Term: {ExpiryTerm}");
            return message;
        }
    }
}

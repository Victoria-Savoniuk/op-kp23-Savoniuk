using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Buyer : User
    {
        private string shippingAddress;
        private string phoneNumber;

        public string ShippingAddress
        {
            get { return shippingAddress; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    shippingAddress = value;
                }
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 10)
                {
                    phoneNumber = value;
                }
            }
        }
        public Buyer(string firstName, string lastName, string shippingAddress, string phoneNumber)
        : base(firstName, lastName)
        {
            ShippingAddress = shippingAddress;
            PhoneNumber = phoneNumber;
        }
    }
}

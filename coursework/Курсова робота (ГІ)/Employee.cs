using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Employee : User
    {
        private string Password { get; set; }
        public Employee(string firstName, string lastName, string password)
        : base(firstName, lastName)
        {
            Password = password;
        }
    }
}

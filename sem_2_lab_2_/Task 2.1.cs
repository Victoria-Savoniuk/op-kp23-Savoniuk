using System;
namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Employee[] employees = new Employee[num];
            SalaryReport report = new SalaryReport(employees);
        }
    }
    class Employee
    {
        public string _lastName;
        public double _salary;
        public double _withheld;
        public double _given;
        public Employee(string lastName, double salary, double withheld)
        {
            _lastName = lastName;
            _salary = salary;
            _withheld = withheld;
            _given = salary - withheld;
        }
    }

    class SalaryReport
    {
        private Employee[] _employees;
        public SalaryReport(Employee[] employees)
        {
            _employees = employees;
        }
    }
}
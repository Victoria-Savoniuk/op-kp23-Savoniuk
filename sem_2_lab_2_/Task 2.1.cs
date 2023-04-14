using System;
namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Test cases
         *      Case 1:
         * Input:
         *   num = 0;
         * Output:
         * №з/п      Пр?звище            Зарплата, грн       Утримано, грн       Видано, грн
         * -----------------------------------------------------------------------------------
         * -----------------------------------------------------------------------------------
         * Разом     ...                 0                   0                   0
         *      Case 2:
         * Input:
         *   num = -1;
         * Output:
         * Кількість співробітників не може бути від'ємним числом. Повторіть спробу.
         *      Case 3:
         * Input:
         *   num = 2;
         *   Співробітник №1
         *   LastName = Савонюк
         *   Salary = 50000
         *   Withheld = 2000
         *   Співробітник №2
         *   LastName = Ковальчук
         *   Salary = 25000
         *   Withheld = 1500
         * Output: 
         * №з/п      Пр?звище            Зарплата, грн       Утримано, грн       Видано, грн
         * -----------------------------------------------------------------------------------
         * 1         Савонюк             50000               2000                48000
         * 2         Ковальчук           25000               1500                23500
         * -----------------------------------------------------------------------------------
         * Разом     ...                 75000               3500                71500
         */
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
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

            Console.WriteLine("Введіть кілкість співробітників підприємства:");
            num = Convert.ToInt32(Console.ReadLine());
            while (num < 0)
            {
                Console.WriteLine("Кількість співробітників не може бути від'ємним числом. Повторіть спробу.");
                Console.WriteLine("Введіть кілкість співробітників підприємства:");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Employee[] employees = new Employee[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Співробітник №{i + 1}:");
                Console.WriteLine($"Введіть прізвище співробітника:");
                string LastName = Console.ReadLine();

                Console.WriteLine($"Введіть зарплату співробітника:");
                int Salary = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine($"Введіть утримання із зарплати співробітника:");
                int Withheld = Convert.ToInt32(Console.ReadLine());
                employees[i] = new Employee(LastName, Salary, Withheld);
            }
            Console.WriteLine();

            SalaryReport report = new SalaryReport(employees);
            report.PrintReport();
        }
    }
    class Employee
    {
        public string _lastName { get; set; }
        public double _salary { get; set; }
        public double _withheld { get; set; }
        public double _given { get; set; }
        public Employee(string lastName, double salary, double withheld)
        {
            _lastName = lastName;
            _salary = salary;
            _withheld = withheld;
            _given = salary - withheld;
        }
        public void PrintInfo()
        {
            Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,-20}{4,-15}", " ", _lastName, _salary, _withheld, _given);
        }
    }

    class SalaryReport
    {
        private Employee[] _employees;
        public SalaryReport(Employee[] employees)
        {
            _employees = employees;
        }
        public void PrintReport()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}", "№з/п", "Прізвище", "Зарплата, грн", "Утримано, грн", "Видано, грн");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            double totalSalary = 0;
            double totalWithheld = 0;
            double totalGiven = 0;

            for (int i = 0; i < _employees.Length; i++)
            {
                Console.Write("{0,-5}", i + 1);
                _employees[i].PrintInfo();

                totalSalary += _employees[i]._salary;
                totalWithheld += _employees[i]._withheld;
                totalGiven += _employees[i]._given;
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}", "Разом", "...", totalSalary, totalWithheld, totalGiven);
        }
    }
}
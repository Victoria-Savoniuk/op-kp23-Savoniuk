using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class EmployeeFile
    {
        public static EmployeeFile employeeFile = new EmployeeFile();
        private string filePath;
        private Dictionary<string, string> employees;

        public EmployeeFile()
        {
            filePath = "C:\\Users\\Віта\\Desktop\\Курсова робота\\Employee File.txt";
            employees = new Dictionary<string, string>();
        }
        public string ValidateEmployee(string name, string password)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2)
                {
                    string key = parts[0];
                    string value = parts[1];
                    employees[key] = value;
                }
            }

            if (employees.ContainsKey(name))
            {
                string storedPassword = employees[name];
                if (password == storedPassword)
                {
                    return ("True");
                }
                else
                {
                    return ("Error: Invalid password");
                }
            }
            else
            {
                return ("Error: Employee not found");
            }
        }
    }
}

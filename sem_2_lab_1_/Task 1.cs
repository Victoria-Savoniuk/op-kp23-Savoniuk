using System;
using System.IO;
using System.Text;
namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathName = Path.Combine(Directory.GetCurrentDirectory(), "sem 2 lab 1 task 1.txt");

            FileStream fs = File.Create(pathName);
            fs.Close();

            StreamWriter sw = new StreamWriter(pathName);
           
            sw.Close();

            string text = File.ReadAllText(pathName);
            Console.WriteLine(text);
        }
    }
}
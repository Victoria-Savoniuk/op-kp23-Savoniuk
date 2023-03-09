using System;
using System.Linq;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "text.txt");

            StreamWriter sw = File.AppendText(filePath);
            sw.Write(" ");
            sw.Close();

            StreamReader sr = new StreamReader(filePath);

            sr.Close();
        }
    }
}
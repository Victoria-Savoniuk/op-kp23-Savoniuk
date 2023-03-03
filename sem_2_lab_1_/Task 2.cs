using System;
using System.IO;
using System.Text;
namespace Files
{
    class Program
    {

        static string OUTPUT_FILE_PATH = Path.Combine(Directory.GetCurrentDirectory(), "max.txt");
        static void Main(string[] args)
        {
            string pathName = Path.Combine(Directory.GetCurrentDirectory(), "sem 2 lab 1 task 2.txt");

            FileStream fs = File.Create(pathName);
            fs.Close();

            StreamWriter sr = new StreamWriter(pathName);
            sr.Close();

            int max = 0;
            
            StreamReader s = new StreamReader(pathName);
            s.Close();

            Console.WriteLine(max);

            StreamWriter sw = new StreamWriter(OUTPUT_FILE_PATH);
            sw.WriteLine(max);
            sw.Close();
        }
    }
}

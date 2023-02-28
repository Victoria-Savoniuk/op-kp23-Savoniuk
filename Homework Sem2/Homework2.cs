using System;
using System.IO;
using System.Text;

namespace Homework
{
    class Program
    {
        static string OUTPUT_FILE_PATH = "C:\\Users\\Віта\\Desktop\\Homework2\\Output.txt";
        static void Main(string[] args)
        {
            string pathName = "C:\\Users\\Віта\\Desktop\\Homework2\\text.txt";
            string text = File.ReadAllText(pathName);
            Console.WriteLine(text);

            File.WriteAllText(OUTPUT_FILE_PATH, text);

        }
    }
}
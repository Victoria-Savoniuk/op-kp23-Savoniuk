using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "words.txt");
            string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "sorted words.txt");

            string[] lines = File.ReadAllLines(filePath);

            Sort();

            using (StreamWriter sw = new StreamWriter(outputPath))
            {
               
            }
        }
        static int Sort()
        {
            return 1;
        }
    }
}
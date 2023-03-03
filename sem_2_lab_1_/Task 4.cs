using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Список.csv");

            
            string[] lines = File.ReadAllLines(filePath);
            int length = lines.Length * 3;
            string[] Mark = new string[length];

            Split();
            
            int n = 0;

            for (int i = 2; i < Mark.Length; i += 3)
            {
                if (Convert.ToInt32(Mark[i]) < 60)
                {
                    n++;
                    Console.WriteLine($"{Mark[i - 2]} {Mark[i - 1]} - {Mark[i]}");
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Таких студентів немає");
            }
        }
        static void Split()
        {
            
        }
    }
}
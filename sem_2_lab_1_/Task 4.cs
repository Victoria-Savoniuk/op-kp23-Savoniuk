using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Test case1:
              Victoria;Savoniuk;96
              Denys;Tabachuk;98
              Valeria;Kovalchuk;53
              Nazar;Myhlovets;62
              Valeria;Eismont;78
              Output:
              Valeria Kovalchuk - 53

            Test case2:
              Victoria;Savoniuk;96
              Denys;Tabachuk;98
              Valeria;Kovalchuk;88
              Nazar;Myhlovets;62
              Valeria;Eismont;78
              Output:
              There are no students whose score is less than 60
             */
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
                Console.WriteLine("There are no students whose score is less than 60");
            }
        }
        static void Split()
        {
            
        }
    }
}
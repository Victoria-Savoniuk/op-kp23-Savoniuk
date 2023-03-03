using System;
using System.IO;
using System.Text;
namespace Files
{
    class Program
    {
        /*
         Test case:
          -1
          -48
          -3
           7
          -16
           15
           3
           49
           42
           46
           21
           1
          -41
          -19
          -30
         Output:
           49
         */
        static string OUTPUT_FILE_PATH = Path.Combine(Directory.GetCurrentDirectory(), "max.txt");
        static void Main(string[] args)
        {
            string pathName = Path.Combine(Directory.GetCurrentDirectory(), "sem 2 lab 1 task 2.txt");

            FileStream fs = File.Create(pathName);
            fs.Close();

            StreamWriter sr = new StreamWriter(pathName);
            var rand = new Random();
            int count = 15;
            for (int i = 0; i < count; i++)
            {

                sr.WriteLine(rand.Next(-50, 50));
            }
            sr.Close();

            int max = 0;
            
            StreamReader s = new StreamReader(pathName);
            max = Convert.ToInt32(s.ReadLine());
            int num;
            for (int i = 1; i < count; i++)
            {
                num = Convert.ToInt32(s.ReadLine());
                if (max < num)
                {
                    max = num;
                }
            }
            s.Close();

            Console.WriteLine(max);

            StreamWriter sw = new StreamWriter(OUTPUT_FILE_PATH);
            sw.WriteLine(max);
            sw.Close();
        }
    }
}

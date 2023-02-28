using System;
using System.IO;

namespace Homework
{
    class Program
    {
        static string OUTPUT_FILE_PATH = "C:\\Users\\Віта\\Desktop\\Homework3\\Output.txt";
        static void Main(string[] args)
        {
            // Зчитати/записати текстовий файл по рядках
            string pathName = "C:\\Users\\Віта\\Desktop\\Homework3\\вірш.txt";
            StreamReader sr = new StreamReader(pathName);
           
            string[] lines = File.ReadAllLines(pathName);
            
            
            for (int i = 0; i < lines.Length; i++)
            {
               string line = sr.ReadLine();
                Console.WriteLine(line);
                lines[i] = line;
                
                
            }
            sr.Close();
           
            StreamWriter sw = new StreamWriter(OUTPUT_FILE_PATH);
            for (int i = 0; i < lines.Length; i++)
            {
                sw.Write(lines[i] + "\n");
            }
            sw.Close();

        }
    }
}
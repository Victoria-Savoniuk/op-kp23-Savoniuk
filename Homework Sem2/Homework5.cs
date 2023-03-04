using System;
namespace Homework
{
    class Program
    {
        static string OUTPUT_FILE_PATH = Path.Combine(Directory.GetCurrentDirectory(), "Output.txt");
        static void Main(string[] args)
        {
            // програма, що видаляє однакові (ідентичні) рядки з файлу
            string pathName = Path.Combine(Directory.GetCurrentDirectory(), "file.txt");
            StreamReader sr = new StreamReader(pathName);

            string[] lines = File.ReadAllLines(pathName);


            for (int i = 0; i < lines.Length; i++)
            {
                string line = sr.ReadLine();
                lines[i] = line;
            }

            string[] same = new string[lines.Length];
            int counter = 0;
            
            for(int i = 0; i < lines.Length; i++)
            {
                for(int j = i+1; j < lines.Length; j++)
                {
                    if (lines[i] == lines[j])
                    {
                        lines[j] = "";
                        same[counter] = lines[i];
                        counter++;
                    }
                }
            }
            for (int i = 0; i < lines.Length; i++)
            {
                for(int j = 0; j < same.Length; j++)
                {
                    if (lines[i] == same[j])
                    {
                        lines[i] = "";
                    }
                }
            }
            
            sr.Close();

            StreamWriter sw = new StreamWriter(OUTPUT_FILE_PATH);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
                sw.Write(lines[i] + "\n");
            }
            sw.Close();

        }
        
    }
}
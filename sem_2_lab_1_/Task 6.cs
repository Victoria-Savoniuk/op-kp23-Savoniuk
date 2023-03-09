using System;
using System.IO;
using System.Reflection;

namespace Labs
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
               Victoria Savoniuk 96
               Denys Tabachuk 98
            Test case2:
              Victoria;Savoniuk;93
              Denys;Tabachuk;95
              Valeria;Kovalchuk;53
              Nazar;Myhlovets;62
              Valeria;Eismont;78
              Output:
              There are no students with a score above 95
             */

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Список.csv");
            string inputFilePath = Path.Combine(Directory.GetCurrentDirectory(), "input.bin");
            string outputFilePath = Path.Combine(Directory.GetCurrentDirectory(), "output.bin");

            string[] lines = File.ReadAllLines(filePath);

            BinaryWriter bw = new BinaryWriter(new FileStream(inputFilePath, FileMode.Create));
             for (int i = 0; i < lines.Length; i++)
            {
                bw.Write(lines[i]);
            }
            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream(inputFilePath, FileMode.Open));
            int length = lines.Length * 3;
            string[] Mark = new string[length];
            int index = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                Split(br.ReadString(), Mark, index);
                index += 3;
            }
            br.Close();

            int n = 0;

            BinaryWriter bw1 = new BinaryWriter(new FileStream(outputFilePath, FileMode.Create));
            for (int i = 2; i < length; i += 3)
            {
                if (Convert.ToInt32(Mark[i]) > 95)
                {
                    bw1.Write(Mark[i - 2] + ";" + Mark[i - 1] + ";" + Mark[i]);
                    Console.WriteLine(Mark[i - 2] + " " + Mark[i - 1] + " " + Mark[i]);
                    n++;
                }
            }
            if(n == 0)
            {
                bw1.Write("There are no students with a score above 95");
                Console.WriteLine("There are no students with a score above 95");
            }
            bw1.Close();
        }
        static void Split(string line, string[] Mark, int index)
        {
            string word = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != ';')
                {
                    word += line[i];

                }
                else
                {
                    Mark[index] = word;
                    word = "";
                    index++;
                }
                if (i == line.Length - 1)
                {
                    Mark[index] = word;
                    index++;
                }
            }
        }
    }
}
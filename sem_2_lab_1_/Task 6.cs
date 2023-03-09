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
            
            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream(inputFilePath, FileMode.Open));

            br.Close();

            BinaryWriter bw1 = new BinaryWriter(new FileStream(outputFilePath, FileMode.Create));

            bw1.Close();
        }
    }
}
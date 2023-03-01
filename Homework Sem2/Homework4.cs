using System;
using System.IO;
using System.Text;

namespace Homework
{
    class Program
    {
        static string OUTPUT_FILE_PATH = "C:\\Users\\Віта\\Desktop\\Homework4\\Output.txt";
        static void Main(string[] args)
        {
            // Зчитати/записати текстовий файл поcимвольно
            string pathName = "C:\\Users\\Віта\\Desktop\\Homework4\\text.txt";
            Stream s = new FileStream(pathName, FileMode.Open);
            int val = 0;
            char ch;

            while (true)
            {
                val = s.ReadByte();

                if (val < 0)
                {
                    break;
                }
                ch = (char)val;
                Console.Write(ch);
                StreamWriter sw = new StreamWriter(OUTPUT_FILE_PATH, true, Encoding.ASCII);

                sw.Write(ch);

                sw.Close();

            }

        }
    }
}
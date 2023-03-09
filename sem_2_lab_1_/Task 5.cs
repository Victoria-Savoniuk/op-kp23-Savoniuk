using System;
using System.Linq;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Test case:
             Victoria Savoniuk
             Hello World!!!
             Hello/Hi
             &Victoria.
             Everyone sees the world in one's own way
            Output:
            Victoria: 2
            Savoniuk: 1
            Hello: 2
            World: 1
            Hi: 1
            Everyone: 1
            sees: 1
            the: 1
            world: 1
            in: 1
            one's: 1
            own: 1
            way: 1
             */

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "text.txt");

            StreamWriter sw = File.AppendText(filePath);
            sw.Write(" ");
            sw.Close();

            StreamReader sr = new StreamReader(filePath);
            int character;
            int lenght = 0;

            while ((character = sr.Read()) != -1)
            {
                if ((char)character == ' ' || (char)character == '\n')
                {
                    lenght++;
                }
            }

           sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // Масив для зберігання унікальних слів
            string[] words = new string[lenght];
            int index_words = 0;

            // Масив для зберігання лічильників кількості зустрічей слів
            int[] counts = new int[lenght];
            int index_counts = 0;

            string word = "";
            sr.Close();
        }
    }
}
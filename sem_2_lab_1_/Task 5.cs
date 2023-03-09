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

            // Читаємо файл по одному символу за раз
            while ((character = sr.Read()) != -1)
            {
                bool Litle = (character >= 65 && character <= 90) || (character >= 97 && character <= 122) || character == 39;
                if (Litle)
                {
                    word += (char)character;
                }
                else
                {
                    // Порівнюємо поточне слово зі словами, які ми вже знайшли
                    bool found = false;
                    for (int i = 0; i < index_words; i++)
                    {
                        if (words[i] == word)
                        {
                            counts[i]++;
                            found = true;
                            break;
                        }
                    }
                    // Якщо поточне слово ще не зустрічалося, додаємо його до масиву
                    if (!found && word != "")
                    {
                        words[index_words] = word;
                        counts[index_counts] = 1;
                        index_words++;
                        index_counts++;
                    }
                    word = "";
                }
            }
            sr.Close();
        }
    }
}
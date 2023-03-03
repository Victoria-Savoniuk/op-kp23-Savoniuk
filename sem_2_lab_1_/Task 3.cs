using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Test case 1:                                                 Test case 2:
                                          Output:                                       Output:
            Book                        Art                             Book            Art
            Mail                        Bed                             Book            Art
            Window                      Birds                           Book            Art
            Coffee                      Book                            Art             Book
            Milk                        Bread                           Art             Book
            Bread                       Bus                             Art             Book
            Mirror                      Candles 
            Park                        Coffee 
            Home                        Cookies 
            Bus                         Day 
            Train                       Dinner 
            Sun                         Flowers 
            Water                       Glasses 
            Music                       Hands 
            Phone                       Health 
            Flowers                     Home 
            Snow                        Love 
            Hands                       Mail 
            Bed                         Milk 
            Table                       Mirror 
            Radio                       Money 
            Sport                       Music 
            Sound                       Park 
            Art                         Phone 
            Money                       Pillow
            Street                      Potato 
            Towel                       Radio 
            Health                      Sea 
            Potato                      Snow 
            Cookies                     Sound 
            Birds                       Sport 
            Tea                         Street 
            Candles                     Sun 
            Dinner                      Table 
            Glasses                     Tea 
            Day                         Towel 
            Sea                         Train 
            Love                        Water 
            Wind                        Wind 
            Pillow                      Window 
             */

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "words.txt");
            string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "sorted words.txt");

            string[] lines = File.ReadAllLines(filePath);

             for (int i = 1; i < lines.Length; i++)
            {
                string key = lines[i];
                int j = i - 1;
                while (j >= 0 && Sort(key, lines[j]) == 1)
                {
                    lines[j + 1] = lines[j];
                    j = j - 1;
                }
                lines[j + 1] = key;
            }

            using (StreamWriter sw = new StreamWriter(outputPath))
            {
               for (int i = 0; i < lines.Length; i++)
                {
                    sw.Write(lines[i] + "\n");
                    Console.WriteLine(lines[i]);
                }
            }
        }
        static int Sort(string a, string b)
        {
            int lenght;
            if (a.Length <= b.Length)
            {
                lenght = a.Length;

            }
            else
            {
                lenght = b.Length;
            }
            for (int i = 0; i < lenght; i++)
            {
                if (a[i] > b[i])
                {
                    return -1;
                }
                else if (a[i] < b[i])
                {
                    return 1;
                }
                else
                {
                    continue;
                }
            }
            if (a.Length <= b.Length)
            {
                return 1;

            }
            else
            {
                return -1;
            }
        }
    }
}
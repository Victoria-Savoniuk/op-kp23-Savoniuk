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

            Sort();

            using (StreamWriter sw = new StreamWriter(outputPath))
            {
               
            }
        }
        static int Sort()
        {
            return 1;
        }
    }
}
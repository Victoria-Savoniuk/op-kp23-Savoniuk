using System;
using System.IO;
using System.Text;
namespace Homework
{
    class Program
    {
        static string OUTPUT_FILE_PATH = "C:\\Users\\Віта\\Desktop\\Homework\\Sort.txt"; 
        static void Main(string[] args)
        {
                string pathName = "C:\\Users\\Віта\\Desktop\\Homework\\Num.txt";
                StreamWriter sr = new StreamWriter(pathName);
                var rand = new Random(); 
                int[] num = new int[10];
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = rand.Next(0, 100);
                    sr.Write(num[i] + " ");
                }
                sr.Close();
                for (int gap = num.Length / 2; gap > 0; gap /= 2)
                {
                    for (int i = gap; i < num.Length; i++)
                    {
                        int current = num[i];
                        for (int j = i; j >= gap; j -= gap)
                        {
                            if (num[j - gap] > current)
                            {
                                num[j] = num[j - gap];
                                num[j - gap] = current;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                StreamWriter sw = new StreamWriter(OUTPUT_FILE_PATH);
                for (int i = 0; i < num.Length; i++)
                {
                    
                    sw.Write(num[i] + " ");
                } 
                sw.Close();
        }
    }
}
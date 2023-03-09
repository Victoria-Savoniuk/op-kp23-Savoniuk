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

            sr.Close();
        }
    }
}
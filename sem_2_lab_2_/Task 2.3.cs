using System;
namespace Vessel
{
    public class Program
    {   
        /*Test cases:
         *    Case 1:
         *  Input:
         *  num = 0;
         *  Output:
         *  Такого номера судна немає. Повторіть спробу.
         *      Case 2:
         *  Input:
         *  num = 1;
         *  Output:
         *  Підготовка парусника до руху
         *  Парусник пливе
         *      Case 3:
         *  Input:
         *  num = 2;
         *  Output:
         *  Підготовка підводного човна до руху
         *  Підводний човен пірнає
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("{0,-15}{1,-20}","№ судна","Вид судна");
            Console.WriteLine("{0,-15}{1,-20}","1","Парусник");
            Console.WriteLine("{0,-15}{1,-20}","2","Підводний човен");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("Виберіть номер судна");
            int num = 0;
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 1 && num != 2)
            {
                Console.WriteLine("Такого номера судна немає. Повторіть спробу.");
                Console.WriteLine("Виберіть номер судна");
                num = Convert.ToInt32(Console.ReadLine());
            }
            string commands = "";
            if(num == 1)
            {
                IVessel vessel1 = new SailingVessel();
                vessel1.PrepareToMovement();
                Console.WriteLine("Бажаєте розпочати рух парусника? Якщо так, то натисніть +");
                commands = Console.ReadLine();
                while (commands != "+")
                {
                    Console.WriteLine("Такої команди не існує, щоб розпочати рух парусника натисніть +");
                    commands = Console.ReadLine();
                }
                vessel1.Move();
            }
            if (num == 2)
            {
                IVessel vessel2 = new Submarine();
                vessel2.PrepareToMovement();
                Console.WriteLine("Бажаєте розпочати рух підводного човна? Якщо так, то натисніть +");
                commands = Console.ReadLine();
                while (commands != "+")
                {
                    Console.WriteLine("Такої команди не існує, щоб розпочати рух підводного човна натисніть +");
                    commands = Console.ReadLine();
                }
                vessel2.Move();
            }
        }
    }
    public interface IVessel
    {
        void PrepareToMovement();
        void Move();
    }
    public class SailingVessel : IVessel
    {
        public void PrepareToMovement()
        {
            Console.WriteLine("Підготовка парусника до руху");
        }
        public void Move()
        {
            Console.WriteLine("Парусник пливе");
        }
    }
    public class Submarine : IVessel
    {
        public void PrepareToMovement()
        {
            Console.WriteLine("Підготовка підводного човна до руху");
        }
        public void Move()
        {
            Console.WriteLine("Підводний човен пірнає");
        }
    }
}
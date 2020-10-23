using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите день:");
            int n = int.Parse(Console.ReadLine());
            if (((n + 6) % 7) == 0)
            {
             Console.WriteLine("Понедельник");
            }
            if (((n + 5) % 7) == 0)
            {
                Console.WriteLine("Вторник");
            }
            if (((n + 4) % 7) == 0)
            {
                Console.WriteLine("Среда");
            }
            if (((n + 3) % 7) == 0)
            {
                Console.WriteLine("Четверг");
            }
            if (((n + 2) % 7) == 0)
            {
                Console.WriteLine("Пятница");
            }
            if (((n + 1) % 7) == 0)
            {
                Console.WriteLine("Суббота");
            }
            if ((n % 7) == 0)
            {
                Console.WriteLine("Воскресенье");
            }
            Console.ReadKey();
            //resave
        }
    }
}

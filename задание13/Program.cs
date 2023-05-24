using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
                Console.WriteLine("Третьей цифры нет.");
            }
            else
            {
                Console.WriteLine($"Третье число {num % 10}");



        }   }
    }
}

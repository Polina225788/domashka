using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace задание15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели (от 1 до 7): ");
            int dayNum = int.Parse(Console.ReadLine());

            if (dayNum == 6 || dayNum == 7)
            
                Console.WriteLine("Это выходной день!") ;

                else
                {
                    Console.WriteLine("Это рабочий день.");
                }
            
        }
    }
}

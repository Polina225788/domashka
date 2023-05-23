using System;


namespace domashka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int secondDigit = (num / 10) % 10;

            Console.WriteLine("Вторая цифра числа {0} равна {1}", num, secondDigit);

            Console.ReadLine();
        }
    }
}

        
    


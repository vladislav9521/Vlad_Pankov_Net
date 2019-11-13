using System;

namespace Module3_2
{
    //2)	Напишите программу, которая вводит натуральное число N и выводит первые N чётных натуральных чисел

    class Program
    {
        static void Main(string[] args)
        {
            uint number;

            Console.Write("Введите натуральное число: ");

            while (!uint.TryParse(Console.ReadLine(), out number) || number == 0)
            {
                Console.Write("Некорректный ввод!!! Введите натуральное число: ");
            }

            Console.WriteLine($"{number} четных натуральных числа(ел) начиная с числа {number}: ");

            for (uint i = number, count = 0; count < number; i++)
            {
                if (!(i % 2 == 0)) continue;
                else
                {
                    Console.Write("{0}\t", i);
                    count++;
                }
            }

            Console.ReadKey();
        }
    }
}

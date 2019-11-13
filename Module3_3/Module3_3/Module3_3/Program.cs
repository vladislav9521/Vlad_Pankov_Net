using System;

namespace Module3_3
{

    //3)	Вывести на экран ряд чисел Фибоначчи, состоящий из n элементов.
    //   Числа Фибоначчи – это элементы числовой последовательности 
    //   0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, …, в которой каждое
    //   последующее число равно сумме двух предыдущих.

    class Program
    {
        static void Main(string[] args)
        {
            uint count;
           
            Console.Write("Введте количество чисел ряда Фибоначчи: ");

            while (!uint.TryParse(Console.ReadLine(), out count))
            {
                Console.Write("Некорректный ввод!!! Введите количество чисел ряда Фибоначчи: ");
            }

            uint[] number = new uint[count];
            number[0] = 0;
            number[1] = 1;

            for (uint i = 0; i < count; i++)
            {
                if (i != 0 && i != 1)
                {
                    number[i] = number[i - 1] + number[i - 2];
                }
                Console.Write($"{number[i]}\t");
            }

            Console.ReadKey();
        }
    }
}

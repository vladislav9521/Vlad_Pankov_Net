using System;

//1)	Напишите программу, которая вводит два целых числа и находит их произведение, 
//    не используя операцию умножения.Учтите, что числа могут быть отрицательными.

namespace Module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA, numberB, mult = default(int);

            Console.Write("Введите первое целое число: ");

            while (!int.TryParse(Console.ReadLine(), out numberA))
            {
                Console.Write("Некорректный ввод!!! Введите первое целое число: ");
            }

            Console.Write("Введте второе целое число: ");

            while (!int.TryParse(Console.ReadLine(), out numberB))
            {
                Console.Write("Некорректный ввод!!! Введите второе целое число: ");
            }

            if (numberA == 0 || numberB == 0)
            {
                mult = 0;
            }
            else
            {
                for (int i = 1; i <= Math.Abs(numberB); i++)
                {
                    mult += Math.Abs(numberA);
                }
                mult = ((numberA < 0) && (numberB > 0)) || ((numberA > 0) && (numberB < 0)) ? (~mult + 1) : mult;
            }

            Console.WriteLine($"Произведение чисел {numberA} и {numberB} = {mult}");
            Console.ReadKey();
        }
    }
}

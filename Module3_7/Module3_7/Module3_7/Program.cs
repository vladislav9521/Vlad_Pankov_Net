using System;

namespace Module3_7
{
    // 7)	Вывести элементы числового массива, которые больше, чем элементы, стоящие перед ними.
    // Например, дан массив [3, 9, 8, 4, 5, 1]. Следует вывести числа 9 и 5, так как перед ними стоят 
    // соответственно числа 3 и 4, которые меньше их.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            uint count;
            while (!uint.TryParse(Console.ReadLine(), out count) || count == 0)
            {
                Console.Write("Некорректный ввод!!! Введите количество элементов в массиве: ");
            }

            Console.Write("Масив до преобразования: ");

            double[] numbers = new double[count];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-100, 100) / 10.0;
                Console.Write(numbers[i] + "\t");
            }

            Console.Write("\nМасив после преобразования: ");

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    Console.Write(numbers[i] + "\t");
                }
                else continue;
            }

            Console.ReadKey();
        }
    }
}

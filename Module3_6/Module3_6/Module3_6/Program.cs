using System;

namespace Module3_6
{

    // 6) Дан массив, содержащий положительные и отрицательные числа.
    // Заменить все элементы массива на противоположные по знаку

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");

            uint count;

            while (!uint.TryParse(Console.ReadLine(), out count) || count == 0)
            {
                Console.Write("Некорректный ввод!!! Введите количество элементов масива: ");
            }

            Console.Write("Массив до преобразования: ");

            double[] numbers = new double[count];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-100, 100) / 10.0;
                Console.Write(numbers[i] + "\t");
            }

            Console.Write("\nМассив после преобразования: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= -1;
                Console.Write(numbers[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}

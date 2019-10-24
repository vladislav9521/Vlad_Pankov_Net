using System;

namespace Module3_5
{
    // 5)	Из натурального числа удалить заданную цифру.Число и цифру вводить с клавиатуры.
    // Например, задано число 5683. Требуется удалить из него цифру 8. Получится число 563

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");

            uint number;

            while (!uint.TryParse(Console.ReadLine(), out number) && number != 0)
            {
                Console.Write("Некорректный ввод!!! Введите натуральное число: ");
            }

            Console.Write($"Введите цифру (от 0 до 9), которую необходимо удалить из числа {number}: ");

            uint extra;

            while (!uint.TryParse(Console.ReadLine(), out extra) && extra > 9)
            {
                Console.Write("Некорректный ввод!!! Введите цифру, которую необходимо удалить из числа: ");
            }

            uint result = default(uint), tmp, rank  = 1;

            do
            {
                tmp = number % 10;
                if (tmp == extra)
                {
                    continue;
                }
                else
                {
                    result += tmp * rank;
                    rank *= 10;
                }
            }
            while ((number /= 10) != 0);

            Console.Write($"Искомое число после удаления цифры {extra} имеет вид: {result}");
            Console.ReadKey();
        }
    }
}

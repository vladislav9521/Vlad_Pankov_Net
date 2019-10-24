using System;

namespace Module3_4
{
    // 4) Вводится число.Преобразовать его в другое число, цифры которого
    // будут следовать в обратном порядке по сравнению с введенным числом.

    class Program
    {
        static void Main(string[] args)
        {
            double number;

            Console.Write("Введите число: ");

            while (!Double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Некорректный ввод!!! Введите число: ");
            }

            char[] masNumber = Math.Abs(number).ToString().ToCharArray();
            string result = default(string);

            for (int i = masNumber.Length - 1; i >= 0; i--)
            {
                result += masNumber[i];
            }

            number = (number < 0) ? (double.Parse(result) * -1) : double.Parse(result);
            Console.WriteLine("Число в обратном порядке: {0}", number);

            Console.ReadKey();
        }
    }
}

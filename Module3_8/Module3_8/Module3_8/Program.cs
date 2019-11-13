using System;

namespace Module8_1
{
    class Program
    {
        private const double accuracy = 0.001;

        static void Main(string[] args)
        {
            Console.Write("Решение уравнения методом отрезка пополам.\n\nВведите начало отрезка: ");

            double start;

            while(!double.TryParse(Console.ReadLine(), out start))
            {
                Console.Write("Некорректный ввод!!! Введите начало отрезка: ");
            }

            double end;

            Console.Write("Введите конец отрезка: ");

            while (!double.TryParse(Console.ReadLine(), out end) || end < start)
            {
                Console.Write("Некорректный ввод!!! Введите конец отрезка: ");
            }
           
            if (CheckExtremum(Function(start)) || CheckExtremum(Function(end)))
            {
                Console.ReadKey();
                return;
            }

            double dx = end - start;
            double average = (start + end) / 2;
            while (Math.Abs(Function(average)) > accuracy)
            {
                dx /= 2;
                average = start + dx;
                if (Math.Sign(Function(start)) == Math.Sign(Function(average)))
                start = average;
            }

            Console.WriteLine($"Решение уравнения sin(3x) = {average}\n");

            Console.ReadKey();
            Console.WriteLine("Заполнение массива:\n ");

            int[,] array = new int[4, 4];
            int x0 = 0, xn = 3, y0 = 0, yn = 3, n = 0;

            while (n < 16)
            {
                for (int x = x0; x <= xn; x++)
                {
                    array[y0, x] = ++n;
                }

                y0++;

                for (int y = y0; y <= yn; y++)
                {
                    array[y, xn] = ++n;
                }

                xn--;

                for (int x = xn; x >= x0; x--)
                {
                    array[yn, x] = ++n;
                }

                yn--;

                for (int y = yn; y >= y0; y--)
                {
                    array[y, x0] = ++n;
                }

                x0++;
            }

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Console.Write("{0}\t", array[y, x]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static bool CheckExtremum(double extremum)
        {
            if (Math.Abs(Function(extremum)) < accuracy)
            {
                Console.WriteLine($"Решение уравнения sin(3x) {extremum}");
                return true;
            }
            return false;
        }

        static double Function(double x)
        {
            return Math.Sin(3 * x);
        }
    }
}

using System;

namespace Module4_1
{
    // 1.	Создать набор методов для вычисления
    // А.Максимального элемента в массиве.
    // Б.Минимального элемента в массиве. 
    // В.Сумму всех элементов в массиве.
    // Г.Разность между максимальным и минимальным элементом. 
    // Д.Увеличить четные элементы массива на максимальный элемент, нечётные уменьшить на минимальный элемент.

    class Program
    {
        static void FillArray(double[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100) / 10.0;
            }
        }

        static void OutputArray(double[] array)
        {
            foreach (double element in array)
            {
                Console.Write(element + "\t");
            }
        }

        static double GetMaxValue(double[] array)
        {
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static double GetMinValue(double[] array)
        {
            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static double GetSumOfElement(double[] array)
        {
            double sum = 0.0;
            foreach (double element in array)
            {
                sum += element;
            }
            return sum;
        }

        static double GetSubstractionOfExtremums(double[] array) => GetMaxValue(array) - GetMinValue(array);

        static void ChangeArray(double[] array)
        {
            double max = GetMaxValue(array);
            double min = GetMinValue(array);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(array[i], MidpointRounding.AwayFromZero);
                array[i] = (array[i] % 2 == 0) ? array[i] + max : array[i] - min;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements of an array: ");
            uint count;
            while (!uint.TryParse(Console.ReadLine(), out count) || count == 0)
            {
                Console.Write("Incorrect entry!!! Enter the number of elements in the array: ");
            }

            double[] array = new double[count];

            FillArray(array);
            OutputArray(array);

            Console.WriteLine($"\nA) Maximum value of the array is {GetMaxValue(array)};");
            Console.WriteLine($"B) Minimum value of the array is {GetMinValue(array)};");
            Console.WriteLine($"C) Sum of the elements of the array is {GetSumOfElement(array)};");
            Console.WriteLine($"D) Difference between extremums of the elements is {GetSubstractionOfExtremums(array)};");
            Console.WriteLine("E) Mutated array (pre-rounded the elements of the array): ");
            ChangeArray(array);
            OutputArray(array);

            Console.ReadKey();
        }

       

    }
}

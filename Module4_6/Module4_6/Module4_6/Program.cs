using System;

namespace Module4_6
{
    // 6. Создать метод, увеличивающий каждый элемент массива на 5.

    class Program
    {
        static void CheckForValid(out uint value, string message)
        {
            Console.Write(message);
            while (!uint.TryParse(Console.ReadLine(), out value) || value == 0)
            {
                Console.Write("Incorrect entry!!! " + message);
            }
        }

        static void FillArray(double[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-1000, 1000) / 10.0;
            }
        }

        static void OutputArray(double[] array)
        {
            foreach (double element in array)
            {
                Console.Write(element + "\t");
            }
        }

        static void ConvertArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
        }

        static void Main(string[] args)
        {
            CheckForValid(out uint number, "Enter the number of the elements of array: ");

            double[] array = new double[number];
            FillArray(array);

            Console.WriteLine($"Array before converting: ");
            OutputArray(array);

            ConvertArray(array);

            Console.WriteLine($"\nArray after transformation: ");
            OutputArray(array);

            Console.ReadKey();
        }
    }
}

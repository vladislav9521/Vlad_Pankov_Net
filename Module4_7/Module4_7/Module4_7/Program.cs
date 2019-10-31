using System;

namespace Module4_7
{
    // 7. Отсортировать массив.  Передать в виде параметра направление сортировки.

    enum TypeOfSort
    {
        Ascending,
        Descending
    }


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

        static void SortArray(double[] array, TypeOfSort type)
        {
            double tmp;

            switch (type)
            {
                case TypeOfSort.Ascending:
                    {
                        for (int j = 0; j < array.Length - 1; j++)
                        {
                            for (int i = 1; i < array.Length; i++)
                            {
                                if (array[i] < array[i - 1])
                                {
                                    tmp = array[i - 1];
                                    array[i - 1] = array[i];
                                    array[i] = tmp;
                                }
                            }
                        }

                        break;
                    }
                case TypeOfSort.Descending:
                    {
                        for (int j = 0; j < array.Length - 1; j++)
                        {
                            for (int i = 1; i < array.Length; i++)
                            {
                                if (array[i] > array[i - 1])
                                {
                                    tmp = array[i - 1];
                                    array[i - 1] = array[i];
                                    array[i] = tmp;
                                }
                            }
                        }
                        break;
                    }
                default: break;
            }
        }

        static void Main(string[] args)
        {
            CheckForValid(out uint number, "Enter the number of the array: ");
            double[] array = new double[number];

            FillArray(array);
            Console.WriteLine("Array before transformation: ");
            OutputArray(array);

            SortArray(array, TypeOfSort.Ascending);
            Console.WriteLine($"\nArray after converting {TypeOfSort.Ascending}: ");
            OutputArray(array);

            SortArray(array, TypeOfSort.Descending);
            Console.WriteLine($"\nArray after converting {TypeOfSort.Descending}: ");
            OutputArray(array);

            Console.ReadKey();
        }
    }
}

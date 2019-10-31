using System;

namespace Module4_2
{

    // 2.	Создать набор методов позволяющих складывать между собой
    // А.Три целых числа
    // Б.Два целых числа
    // В. Три дробных числа
    // Г.  Две строки (результатом должна быть конкатенация строк)
    // Д.Два массива одинаковой(как одинаковой, так и разной длины) Результатом будет сумма a[i] + b[i].


    class Program
    {
        static void CheckForValid(out int value, string message)
        {
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Incorrect entry!!! " + message);
            }
        }

        static void CheckForValid(out double value, string message)
        {
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Incorrect entry!!! " + message);
            }
        }

        static void CheckForValid(out uint value, string message)
        {
            Console.Write(message);
            while (!uint.TryParse(Console.ReadLine(), out value) || value == 0)
            {
                Console.Write("Incorrect entry!!! " + message);
            }
        }

        static int GetSumOfThree(int a, int b, int c) => a + b + c;

        static int GetSumOfTwo(int a, int b) => a + b;

        static double GetSumOfThree(double a, double b, double c) => a + b + c;

        static string GetSumOfTwoString(string str1, string str2) => str1 + str2;

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

        static double[] GetConvertedArray(double[] array1, double[] array2)
        {
            int count = (array1.Length > array2.Length) ? array1.Length : array2.Length;
            double[] resultArray = new double[count];

            for (int i = 0; i < resultArray.Length; i++)
            {
                try
                {
                    resultArray[i] = array1[i] + array2[i];
                }
                catch
                {
                    resultArray[i] = array1.Length > array2.Length ? array1[i] : array2[i];
                }

            }

            return resultArray;
        }

        static void Main(string[] args)
        {
            CheckForValid(out int number1, "Enter the first integer number: ");

            CheckForValid(out int number2, "Enter the second integer number: ");

            CheckForValid(out int number3, "Enter the third integer number: ");

            Console.WriteLine($"\nSum of 3 integer numbers {number1}, {number2} and {number3} =" +
                              $" {GetSumOfThree(number1, number2, number3)};");

            Console.WriteLine($"\nSum of 2 integer numbers {number1} and {number2} = {GetSumOfTwo(number1, number2)};");

            Console.WriteLine(new string('-', 50));
            ;
            CheckForValid(out double number4, "Enter the first fractional number: ");

            CheckForValid(out double number5, "Enter the second fractional number: ");

            CheckForValid(out double number6, "Enter the third fractional number: ");

            Console.WriteLine($"\nSum of the 3 fractional numbers {number4}, {number5} and {number6}" +
                              $" = {GetSumOfThree(number4, number5, number6)};");

            Console.WriteLine(new string('-', 50));

            Console.Write("\nEnter the first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            Console.WriteLine($"\nConcatenation of two string {str1} and {str2} is {GetSumOfTwoString(str1, str2)};");

            Console.WriteLine(new string('-', 50));

            CheckForValid(out uint count, "\nEnter the number of elements of an array #1: ");

            double[] array1 = new double[count];
            FillArray(array1);
            Console.Write("\nArray #1: ");
            OutputArray(array1);

            CheckForValid(out count, "\nEnter the number of elements of an array #2: ");

            double[] array2 = new double[count];
            Console.Write("\nArray #2: ");
            FillArray(array2);
            OutputArray(array2);

            Console.Write("\nConvrted array: ");
            OutputArray(GetConvertedArray(array1, array2));

            Console.ReadKey();
        }

        
    }
}

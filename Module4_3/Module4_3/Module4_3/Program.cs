using System;

namespace Module4_3
{

    // 3.     Создать набор методов с использованием ключевых слов ref и out 
    // A.Позволяющий увеличивать значение трех входных переменных на 10
    // Б.Позволяющий находить длину окружности и площадь круга.
    // В.Позволяющий находить минимальный и максимальный элемент массива и сумму всех элементов массива.


    class Program
    {
        static void CheckForValid(out double value, string message)
        {
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Incorrect entry!!! " + message);
            }
        }

        static void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }
        }

        static void OutputArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + "\t");
            }
        }

        static void ChangeValue(ref double value) => value += 10;

        static void CalculateParamOfCircle(double radius, out double square, out double length)
        {
            length = Math.Round(2 * Math.PI * radius, 3);
            square = Math.Round(Math.PI * Math.Pow(radius, 2), 3);
        }

        static void CalculateArray(int[] array, ref int max, ref int min, ref int sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }
        }

        static void Main(string[] args)
        {
            CheckForValid(out double number1, "Enter the first fractional number: ");

            CheckForValid(out double number2, "Enter the second fractional number: ");

            CheckForValid(out double number3, "Enter the third fractional number: ");

            Console.WriteLine($"\nThe numbers before changing: {number1}, {number2}, {number3};");

            ChangeValue(ref number1);
            ChangeValue(ref number2);
            ChangeValue(ref number3);

            Console.WriteLine($"The numbers after changing: {number1}, {number2}, {number3};");
            Console.WriteLine(new string('-', 50));

            Console.Write("\nEnter radius of circle: ");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.Write("Incorrect entry!!! Enter the the radius of the circle: ");
            }
            CalculateParamOfCircle(radius, out double square, out double length);
            Console.WriteLine($"\nLength of the circle = {length}, Square of the circle = {square};");

            Console.WriteLine(new string('-', 50));

            Console.Write($"\nEnter the number of elements of an array: ");
            uint count;
            while (!uint.TryParse(Console.ReadLine(), out count) || count == 0)
            {
                Console.Write("Incorrect entry!!! Enter the number of elements of an array: ");
            }
            int[] array = new int[count];
            FillArray(array);
            OutputArray(array);
            int max = array[0], min = array[0], sum = 0;
            CalculateArray(array, ref max, ref min, ref sum);
            Console.WriteLine($"\nMax value of the elements is {max}, min value - {min}, sum of all elements of the array is {sum}");

            Console.ReadKey();
        }

      
    }



}

using System;

namespace Module4_3
{

    // 4. Используя кортежи.   Создать набор методов с использованием ключевых слов ref и out 
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

        static void ChangeValues(ref (double number1, double number2, double number3) numbers)
        {
            numbers.number1 += 10;
            numbers.number2 += 10;
            numbers.number3 += 10;
        }

        static (double, double) CalculateParamOfCircle(double radius)
        {
            (double, double) parameters;
            parameters.Item1 = Math.Round(2 * Math.PI * radius, 3);
            parameters.Item2 = Math.Round(Math.PI * Math.Pow(radius, 2), 3);
            return parameters;
        }

        static (int max, int min, int sum) GetParametersOfArray(int[] array)
        {
            var parameters = (max: array[0], min: array[0], sum: 0);

            for (int i = 0; i < array.Length; i++)
            {
                parameters.sum += array[i];

                if (array[i] > parameters.max)
                {
                    parameters.max = array[i];
                }

                if (array[i] < parameters.min)
                {
                    parameters.min = array[i];
                }
            }
            return parameters;
        }

        static void Main(string[] args)
        {
            CheckForValid(out double number1, "Enter the first fractional number: ");

            CheckForValid(out double number2, "Enter the second fractional number: ");

            CheckForValid(out double number3, "Enter the third fractional number: ");

            (double number1, double number2, double number3) numbers = (number1, number2, number3);

            Console.WriteLine($"\nThe numbers before changing: {numbers.number1}, {numbers.number2}, {numbers.number3};");

            ChangeValues(ref numbers);

            Console.WriteLine($"The numbers after changing: {numbers.number1}, {numbers.number2}, {numbers.number3};");
            Console.WriteLine(new string('-', 50));

            Console.Write("\nEnter radius of circle: ");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.Write("Incorrect entry!!! Enter the the radius of the circle: ");
            }
            (double, double) parametersOfCircle = CalculateParamOfCircle(radius);
            Console.WriteLine($"\nLength of the circle = {parametersOfCircle.Item1}, Square of the circle = {parametersOfCircle.Item2};");

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
            var parametersOfArray = GetParametersOfArray(array);
            Console.WriteLine($"\nMax value of the elements is {parametersOfArray.max}, min value - {parametersOfArray.min}," +
                              $" sum of all elements of the array is {parametersOfArray.sum}");

            Console.ReadKey();
        }

       
    }



}

using System;


namespace Module4_8
{

    // 8 . Решить уравнение методом деления отрезка пополам, используя рекурсию.

    class Program
    {
        private const double accuracy = 0.001;

        static double GetFunction(double x)
        {
            return Math.Sin(3 * x);
        }

        static bool CheckExtremum(double extremum)
        {
            if (Math.Abs(GetFunction(extremum)) < accuracy)
            {
                Console.WriteLine($"Root of the equation «sin(3x) is about 0», x = {extremum}");
                return true;
            }
            return false;
        }

        static double GetSolution(double start, double dx, double average)
        { 
                if (Math.Abs(GetFunction(average)) < accuracy)
                {
                    return average;
                }
                else
                {
                    dx /= 2;
                    average = start + dx;
                    if (Math.Sign(GetFunction(start)) == Math.Sign(GetFunction(average)))
                    {
                        start = average;
                    }
                    return GetSolution(start, dx, average);
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Solving the equation by «методом отрезка пополам».\n\nEnter begin of interval: ");
            double start = double.Parse(Console.ReadLine());

            Console.Write("Enter end of the interval: ");
            double end = double.Parse(Console.ReadLine());

            if (CheckExtremum(GetFunction(start)) || CheckExtremum(GetFunction(end)))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Root of the equation «sin(3x) is {GetFunction(GetSolution(start, end - start, (start + end) / 2))}, " +
                              $" x = {GetSolution(start, end - start, (start + end) / 2)} \n");

            Console.ReadKey();
        }

    }
}

using System;


namespace Module4_5
{

    // 5. Создать набор методов для:
    // A.Выполнения математической операции над двумя числами.Математическую операцию представить в виде перечисления.
    // Б.Вычисления количество дней в месяце.

    enum MathOperation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


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

        static double GetResult(double number1, double number2, MathOperation operation)
        {
            double result = 0.0;
            switch (operation)
            {
                case MathOperation.Addition:
                    result = number1 + number2;
                    break;
                case MathOperation.Division:
                    result = (number2 == 0) ? 0 : Math.Round(number1 / number2, 3);
                    break;
                case MathOperation.Multiplication:
                    result = number1 * number2;
                    break;
                case MathOperation.Subtraction:
                    result = number1 - number2;
                    break;
                default:
                    break;
            }
            return result;
        }

        static int GetResult(Month month)
        {
            int days;
            switch (month)
            {

                case Month.January:
                case Month.March:
                case Month.May:
                case Month.July:
                case Month.August:
                case Month.October:
                case Month.December:
                    days = 31;
                    break;
                case Month.February:
                    days = 29;
                    break;
                case Month.April:
                case Month.June:
                case Month.September:
                case Month.November:
                    days = 30;
                    break;

                default:
                    days = 30;
                    break;
            }
            return days;
        }

        static void Main(string[] args)
        {
            CheckForValid(out double number1, "Enter the first number: ");
            CheckForValid(out double number2, "Enter the second numer: ");

            Console.WriteLine($"Addition operation: {number1} + {number2} = {GetResult(number1, number2, MathOperation.Addition)};");
            Console.WriteLine($"Substraction operation: {number1} - {number2} = {GetResult(number1, number2, MathOperation.Subtraction)};");
            Console.WriteLine($"Multiplication operation: {number1} * {number2} = {GetResult(number1, number2, MathOperation.Multiplication)};");
            Console.WriteLine($"Division operation: {number1} / {number2} = {GetResult(number1, number2, MathOperation.Division)};");

            Console.WriteLine(new string('-', 50));


            foreach (Month m in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"In {m} {GetResult(m)} days;");

            }

            Console.ReadKey();
        }


    }


}

using System;


namespace Module2_3
{

    //3)	Очень часто нам необходимо поменять местами два числовых значения.Программа просит 
    //    пользователя ввести 2 числовые переменные.А после она меняет их местами и выводит 
    //    результат на экран. Но, так как пользователь может ошибиться, необходимо предусмотреть тот факт,
    //    что пользователь может ввести, например, букву или строку, а так же учесть, что число может быть
    //    дробным, и для выделения её дробной части одни используют точку, другие – запятую.

    class Program
    {
        static void Main(string[] args)
        {
            string strA, strB;
            double numbA, numbB, tmp = 0.0;

            A:

            Console.Write("Введите число A: ");
            strA = Console.ReadLine();

            if (double.TryParse(strA, out numbA))
            {
                B:

                Console.Write("Введите число B: ");
                strB = Console.ReadLine();

                if (double.TryParse(strB, out numbB))
                {
                    Console.WriteLine($"Числа до изменения: A = {numbA}, B = {numbB};");
                    tmp = numbA;
                    numbA = numbB;
                    numbB = tmp;
                    Console.WriteLine($"Числа после изменения: A = {numbA}, B = {numbB};");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод числа B.");
                    goto B;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод числа A.");
                goto A;
            }

            Console.ReadKey();
        }
    }
}

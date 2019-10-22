using System;

namespace Module2_1
{

    //1)	Система подсчета налогов.Пользователь вводит N – число комапаний, работающих в стране,
    //    а так же M% – налог, который взымает государство.Если представить, что доход, который
    //    получат всё эти компании одинаковый и он равен 500, то какой суммарный налог 
    //    государство получит?

    class Program
    {
        static void Main(string[] args)
        {
            int countComp;
            double taxSum, incOfOne = 500.0, taxPC;

            Console.Write("Введите число компаний: ");
            countComp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите налог(в %): ");
            taxPC = Convert.ToDouble(Console.ReadLine());
            
            taxSum = (incOfOne * taxPC / 100) * countComp;

            Console.WriteLine($"Суммарный налог государству {countComp} компаний\n" +
                              $"при доходе каждой в  {incOfOne} у.е. составляет {taxSum} у.е.");
            Console.ReadKey();
        }
    }
}

using System;

namespace Module2_2
{
    //2)	Пользователь вводит N – целочисленное число.Если N четное и больше 18 – программа поздравляет 
    //его с 18-и летием. Если N нечетное и меньше 18 но больше 13 – программа поздравляет с 
    //переходом в старшую школу.

    class Program
    {
        static void Main(string[] args)
        {
            int numb;
           
            Console.Write("Введите возраст: ");
            numb = Convert.ToInt32(Console.ReadLine());

            if (numb % 2 == 0 && numb > 18)
            {
                Console.WriteLine("Поздравляю с 18-и летием!!!");
            }
            else if(numb%2 !=0 && numb > 13 && numb < 18)
            {
                Console.WriteLine("Поздравляю с переходом в старшую школу!!!");
            }
            Console.ReadKey();
        }
    }
}

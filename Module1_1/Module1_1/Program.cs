using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1, b = 2;
            Console.WriteLine("Значения чисел «a» и «b» до изменения:\n a = {0}; b = {1}", a, b);
            a ^= b;
            b ^= a;
            a ^= b;
            Console.WriteLine("Значения чисел «a» и «b» после изменения:\n a = {0}; b = {1}", a, b);
            Console.ReadKey();
        }
    }
}

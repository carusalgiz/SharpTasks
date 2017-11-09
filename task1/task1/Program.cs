/*
Даны два целых числа, отличных от нуля. Найдите их сумму, произведение, разность, частное.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            var num1 = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            var num2 = Console.ReadLine();
            double a = double.Parse(num1);
            double b = double.Parse(num2);

            double summary = a + b;
            double substraction = a - b;
            double multiplication = a * b;
            double division = a / b;

            Console.WriteLine("Сумма чисел: " + summary);
            Console.WriteLine("Разность чисел: " + substraction);
            Console.WriteLine("Произведение чисел: " + multiplication);
            Console.WriteLine("Частное чисел: " + division);

            Console.ReadKey();
        }
    }
}

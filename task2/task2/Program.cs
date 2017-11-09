/* Стоимость минуты разговора по телефону — P руб. 
 * Если продолжительность разговора превышает 5 минут, то на оставшуюся часть времени действует скидка, равная 20%. 
 * Написать программу, определяющую стоимость разговора заданной продолжительности T.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public double Sale(double price, int time)
        {
            int sec = time - 300;
            if ((sec % 60) != 0)
            {
                return ((5 * price) + (((sec / 60) + 1) * price) * 0.2);             
            }
            else
            {
                return ((5 * price) + ((sec / 60) * price) * 0.2);
            }
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            double P, result;
            int T;
            Console.WriteLine("Введите стоимость минуты разговора: ");
            var p = Console.ReadLine();
            Console.WriteLine("Введите продолжительность разговора (в секундах): ");
            var t = Console.ReadLine();
            P = double.Parse(p);
            T = int.Parse(t);

            if(T > 300)
            {
                result = prog.Sale(P, T);
            }
            else
            {
                result = (T / 60) * P;
            }
            Console.WriteLine("Стоимость разговора: " + result);
            Console.ReadKey();
        }
    }
}

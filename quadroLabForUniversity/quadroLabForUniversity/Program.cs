using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadroLabForUniversity
{
    class Program
    {

        //интеграл e^(x^3) с границами [1;2]
        static double getIntegral(double x)
        {
            return Math.Pow(Math.E, Math.Pow(x, 3));
        }
        static void Rectangle()
        {
            double maxDiff2x = 156 * Math.Pow(Math.E, 8);
            double a = 1, b = 2, e = 0.001, I = 1;
            double n = (((Math.Pow(b - a, 3)) * maxDiff2x) / (24 * e));
            n = Math.Sqrt(n);
            n *= 1.1;
            double h, sum = 0;
            h = (b - a) / n;
                for (int i = 0; i < n; i++)
                {
                    sum += getIntegral(a + h/2 + i * h);
                }
                I = h * sum;
            Console.WriteLine("Интеграл=" + Math.Ceiling(I*1000)/1000);
        }

        static void Trapeze()
        {
            double maxDiff2x = 156 * Math.Pow(Math.E, 8);
            double a = 1, b = 2, e = 0.001, I = 1;
            double n = (((Math.Pow(b - a, 3)) * maxDiff2x) / (12 * e));
            n = Math.Sqrt(n);
            n *= 1.1;
            double h, sum = (getIntegral(a) + getIntegral(b))/2;
            h = (b - a) / n;
            for (int i = 0; i <= n; i++)
                {
                    sum += getIntegral(a + i * h);
                }
            I = h * sum;
            Console.WriteLine("Интеграл=" + Math.Ceiling(I * 1000) / 1000);
        }

        static void Simpson()
        {
            double maxDiff4x = 31824 * Math.Pow(Math.E, 8);
            double a = 1, b = 2, e = 0.001, I = 1;
            double n = (((Math.Pow(b - a, 5)) * maxDiff4x) / (2880 * e));
            n = Math.Pow(n, 0.25);
            n *= 1.1;
            double h, sum = getIntegral(a)+getIntegral(b);
            h = (b - a) / n;
            for (int i = 1; i <= n; i++)
                {
                    sum += 4 * getIntegral(a + i * h - h / 2) + 2 * getIntegral(a + h * i);
            }
            I = h / 6 * sum;         
            Console.WriteLine("Интеграл=" + Math.Ceiling(I * 1000) / 1000);
        }
            static void Main(string[] args)
        {          
            Console.WriteLine("1. Квадратурная формула прямоугольников.");
            Rectangle();
            Console.WriteLine("2. Квадратурная формула трапеции.");
            Trapeze();
            Console.WriteLine("3. Квадратурная формула Симпсона.");
            Simpson();
            Console.ReadKey();
        }
    }
}

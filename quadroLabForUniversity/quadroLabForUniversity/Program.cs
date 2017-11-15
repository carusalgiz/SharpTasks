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
        static void Rectangle()
        {
            double a = 1, b = 2, e = 0.001, I = 1, I1 = 0, k = 2;     
            for (int n = 2; e < (Math.Abs(I1 - I)) / (Math.Pow(2, k) - 1); n *= 2)
            {
                double h, sum = 0;
                h = (b - a) / n;
                for (int i = 0; i < n; i++)
                {
                    sum += Math.Pow(Math.E, Math.Pow(a + h * i + 0.5 * h, 3));
                }
                I = I1;
                I1 = h * sum;
            //    Console.WriteLine("h="+h+"\nn="+n+"\nI(h)="+I+"\nI(h/2)="+I1+"\n\n");
            }
            Console.WriteLine("Интеграл=" + Math.Ceiling(I1*1000)/1000);
        }

        static void Trapeze()
        {
            double a = 1, b = 2, e = 0.001, I = 1, I1 = 0, k = 2;
            for (int n = 2; e < (Math.Abs(I1 - I)) / (Math.Pow(2, k) - 1); n *= 2)
            {
                double h, sum = 0;
                h = (b - a) / n;
                for (int i = 0; i <= n; i++)
                {
                    if (i != 0 && i != n)
                    {
                        sum += Math.Pow(Math.E, Math.Pow(a + h * i + 0.5 * h, 3)) + Math.Pow(Math.E, Math.Pow(a + h * (i - 1) + 0.5 * h, 3));
                    }
                    else
                    {
                        sum += 2 * Math.Pow(Math.E, Math.Pow(a + h * i + 0.5 * h, 3)) + 2 * Math.Pow(Math.E, Math.Pow(a + h * (i - 1) + 0.5 * h, 3));
                    }
                }
                I = I1;
                I1 = ((h / 2) * sum);
             //   Console.WriteLine("h=" + h + "\nn=" + n + "\nI(h)=" + I + "\nI(h/2)=" + I1 + "\n\n");
            }
            Console.WriteLine("Интеграл=" + Math.Ceiling(I1 * 1000) / 1000);
        }

        static void Simpson()
        {
            double a = 1, b = 2, e = 0.001, I = 1, I1 = 0, k = 4;
            for (int n = 2; e < (Math.Abs(I1 - I)) / (Math.Pow(2, k) - 1); n *= 2)
            {
                double h, sum1 = 0, sum2 = 0, sum3 = 0;
                h = (b - a) / (2 * n);
                for (int i = 1; i <= 2 * n - 1; i += 2)
                {
                    sum3 += Math.Pow(Math.E, Math.Pow(a + h * i, 3));
                    sum2 += Math.Pow(Math.E, Math.Pow(a + h * (i + 1), 3));
                }
                sum1 = Math.Pow(Math.E, Math.Pow(a, 3)) - Math.Pow(Math.E, Math.Pow(b, 3)) + 4 * sum3 + 2 * sum2;
                I = I1;
                I1 = ((h / 3) * sum1);
             //   Console.WriteLine("h=" + h + "\nn=" + n + "\nI(h)=" + I + "\nI(h/2)=" + I1 + "\n\n");
            }
            Console.WriteLine("Интеграл=" + Math.Ceiling(I1 * 1000) / 1000);
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

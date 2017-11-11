using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace otherTasks
{   
    class Program
    {
        static void TaskOne()
        {
            /* Определить, расположены ли цифры заданного числа в нём по возрастанию слева направо.*/
            Console.WriteLine("Введите число для проверки: ");
            var num = Console.ReadLine();
            char[] array = num.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < array[i + 1])
                {
                    Console.WriteLine(array[i] + "<" + array[i + 1] + " все ок");
                    continue;
                } else
                {
                    Console.WriteLine(array[i] + ">" + array[i + 1] + " ошибочка");
                    break;
                }
            }
            Console.ReadKey();
        }
        static void TaskTwo()
        {
            /*Две окружности заданы координатами центров и радиусами. 
             * Написать программу, определяющую, пересекаются ли они в точности в одной точке.*/
            Console.WriteLine("Введите x1: ");
            var x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1: ");
            var y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите R1: ");
            var R1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2: ");
            var x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2: ");
            var y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите R2: ");
            var R2 = int.Parse(Console.ReadLine());
            double lineAmongPoints = Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2 - y1), 2));
            int twoRads = R1 + R2;
            if (lineAmongPoints < twoRads)
            {
                Console.WriteLine("Окружности пересекаются больше, чем в одной точке");
            } else if (lineAmongPoints == twoRads)
            {
                Console.WriteLine("Окружности пересекаются ровно в одной точке");
            } else
            {
                Console.WriteLine("Окружности не пересекаются");
            }
            Console.ReadKey();
        }
        static void TaskThree(int x1, int x2, int x3, int y1, int y2, int y3)
        {
            /* Найти периметр треугольника по координатам его вершин. 
             * (Определить функцию для расчёта длины отрезка по координатам его концов.)*/           
            double side1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double side2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double side3 = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            Console.WriteLine("Периметр равен: " + (side1 + side2 + side3));
        }
        static void TaskFour()
        {
            /* Дано число. Найдите разность двух чисел. 
             * Первое число равно сумме цифр исходного числа, стоящих на четных местах.
             * Второе число равно сумме цифр, стоящих на нечетных местах.*/
            Console.WriteLine("Введите число: ");
            var num = Console.ReadLine();
            int evenNumber = 0, oddNumber = 0;
            for(int i = 0; i < num.ToCharArray().Length; i++)
            {
                if((i % 2) == 0)
                {
                    evenNumber += int.Parse(num.ToCharArray()[i].ToString());
                } else
                {
                    
                    oddNumber += int.Parse(num.ToCharArray()[i].ToString()); ;
                }
            }  
            Console.WriteLine(oddNumber + "-" + evenNumber + "=" + (oddNumber - evenNumber));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания для выполнения (0 - выход): ");
            var answer = int.Parse(Console.ReadLine());
            do
            {
                switch (answer)
                {
                    case 1:
                        TaskOne();
                        break;
                    case 2:
                        TaskTwo();
                        break;
                    case 3:
                        Console.WriteLine("Введите x1: ");
                        var x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите x2: ");
                        var x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите x3: ");
                        var x3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите y1: ");
                        var y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите y2: ");
                        var y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите y3: ");
                        var y3 = int.Parse(Console.ReadLine());
                        TaskThree(x1, x2, x3, y1, y2, y3);
                        break;
                    case 4:
                        TaskFour();
                        break;
                }
            } while (answer != 0);
        }
    }
}

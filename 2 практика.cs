using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 практика
            // 1 задание 
            /*Console.WriteLine("Задание 1");
            Console.WriteLine("напишите все числа требуемые для вычисления уравнения");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double l = Math.Sqrt((c - a) * 2 - (d - b) * 2);
            Console.WriteLine("ваш ответ: ",+l);
            Console.ReadKey();*/
            // 2 задание
            /*Console.WriteLine("Задание 2");
            Console.WriteLine("Введите координаты точек сторон треугольника");
            double Ax = Convert.ToDouble(Console.ReadLine());
            double Bx = Convert.ToDouble(Console.ReadLine());
            double Ay = Convert.ToDouble(Console.ReadLine());
            double By = Convert.ToDouble(Console.ReadLine());
            double Az = Convert.ToDouble(Console.ReadLine());
            double Bz = Convert.ToDouble(Console.ReadLine());
            double a = Math.Sqrt((Ax - Ay) * (Ax - Ay) + (Bx - By) * (Bx - By));
            double b = Math.Sqrt((Az - Ay) * (Az - Ay) + (Bz - By) * (Bz - By));
            double c = Math.Sqrt((Az - Ax) * (Az - Ax) + (Bz - Bx) * (Bz - Bx));
            double p = (a + b + c) / 2;
            double P = p * 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Периметр равен{0}", P);
            Console.WriteLine("Площадь равна {0}", s);
            Console.ReadKey();*/
            // 3 задание
            Console.WriteLine("Задание 3");
            Console.WriteLine("введите число !!!!");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a * a;
            double c = b * b;
            double oTVET = c * c;
            Console.WriteLine(oTVET);
            Console.ReadKey();
        }
                
    }
}

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
            // 1 задание 
           /* double y;
            Console.WriteLine("введите число Х");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x < 3.5)
            {
                y = -(2 * x) / (-4 * x - 1);
            }
            else
            {
                y = 4 * x * x + 2 * x - 19;
            }
            Console.WriteLine("y=" + y);*/

            // 2 задание
            /*Console.WriteLine("Введите потраченые минуты");
            double x = Convert.ToDouble(Console.ReadLine());//Потраченые минуты
            Console.WriteLine("Введите минуты по тарифу");
            double a = Convert.ToDouble(Console.ReadLine());//Лимит минут
            Console.WriteLine("Введите цену тарифа");
            double b = Convert.ToDouble(Console.ReadLine());//цена тарифа
            Console.WriteLine("Введите цену р/мин за превышение тарифа");
            double c = Convert.ToDouble(Console.ReadLine());//цена р/мин за превышение тарифа
            double d;
            if(x<=a)
            {
                d = b;
            }
            else
            {
                d = b + c * (x - a);
            }
            Console.WriteLine("оплата за месяц="+d);*/

            //3 задание
            /* Console.WriteLine("Введите длину отверстия ");
             double A = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите ширину отверстия");
             double B = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите длину кирпича ");
             double x = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите ширину кирпича ");
             double y = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите высоту кирпича ");
             double z = Convert.ToDouble(Console.ReadLine());
             if ((y < B) || (z < B) && (x < A))
             {
                 Console.WriteLine("пройдет");
             }
             else 
             {
                 if ((y < A) && (z < B))
                 {
                     Console.WriteLine("пройдет");
                 }
                 else
                 {
                     Console.WriteLine("не пройдет");
                 }
             }*/

            //4 задание
           /* double y = 0;
            Console.WriteLine("введите значение X ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (-9 <= x && x <= 9)
            {
                if ((-9 <= x) && (x < -6))
                {
                    Console.WriteLine("введите значение R");
                    double R = Convert.ToDouble(Console.ReadLine());
                    y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow((x + 6), 2));
                }
                else if ((0 <= x) && (x <= 3))
                {
                    y = -x + 3;
                }
                else
                {
                    y = 0.5 * x - 1.5;
                }
                Console.WriteLine("Значение ординаты= {0}", +y);
            }
            else
            {
                Console.WriteLine("Не определено");
            }
            Console.ReadKey();*/
        }

    }
}

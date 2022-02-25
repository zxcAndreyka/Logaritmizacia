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
            /*Console.WriteLine("Введите радиус круга");
            double r = Convert.ToDouble(Console.ReadLine());
            int g = 10;
            do
            {
                Console.WriteLine("напишите координаты выстрела по Х");
                double x = Convert.ToDouble(Console.ReadLine());
 
                Console.WriteLine("напишите координаты выстрела по Y");
                double y = Convert.ToDouble(Console.ReadLine());
                double xr = -r;
                double r1 = r;
                double yr = r1;
                if ((((x <= (xr + r)) || (x <= (xr - r))) && ((y <= (yr + r)) || (y <= (yr - r)))))
                {
                    Console.WriteLine("попал");
                }
                else
                {
                    Console.WriteLine("не попал");
                }
                g--;
            }
            while (g!=0);*/

            // 2

            /*Console.Write("Введите значение ");
            double a = Convert.ToDouble(Console.ReadLine());
            double S = 0;
            switch (a)
            {
                case < 0:
                    S = 0;
                    int i = 3;
                    while (i <= 9)
                    {
                        S += i - 2;
                        i += 2;
                    }
                    break;
                case >= 0:
                    S = 1;
                    int j = 2;
                    while (j <= 8)
                    {
                        S *= j * j - a;
                        j += 2;
                    }
                    break;
            }
            Console.WriteLine(S);*/

            // 3
            /*int n = 100;
            int max = 0;
            do
            {
                int s = 0;
                int a1 = n / 100;
                int a2 = (n / 10) % 10;
                int a3 = n % 10;
                s = a1 + a2 + a3;
                int t = n / s;
                if (t > max)
                {
                    max = t;
                    n = n + 1;
                }
                else
                {
                    n = n + 1;
                }
            }
            while (n < 1000);
            Console.WriteLine(max);
            Console.ReadKey();*/

            // 4
            /*            Console.WriteLine("Напишите число");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int delenie = n % 2;
                        int g = 1;
                        int count = 0;
                        if (delenie == 0)
                        {
                            do
                            {
                                count += 2;
                                g *= count;
                            }
                            while (count <= n);
                            Console.WriteLine(g);
                        }
                        else
                        {
                            count = 1;
                            do
                            {
                                g *= count;
                                count += 2;
                            }
                            while (count <= n);
                            Console.WriteLine(g);
                        }*/
        }
    }
}

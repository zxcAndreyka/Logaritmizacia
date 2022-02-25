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
            // 1 задание 
            /*int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int k = 0;
            do
            {
               count ++;
                k += count;
            }
            while(count < a );
            Console.WriteLine(k / 5);
            Console.ReadKey();*/

            //2 Задание
            /*Console.Write("Введите Х ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите N ");
            int N = Convert.ToInt32(Console.ReadLine());
            double Y = 1;
            int count = 1;
            while (count <= N)
            {
                int num = 2 * count;
                int a = 1;
                while (num > 1)
                {
                    a *= num--;
                }
                Y += Math.Pow(-1, count) * (Math.Pow(X, 2 * count) / a);
                count += 1;
            }
            Console.WriteLine(Y);*/

            //3 Заданиe
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

            // 4 задание
            /*Console.Write("Введите A ");
            int A = Convert.ToInt32(Console.ReadLine());
            int K = 1;
            int F = 0;
            int d = 0;
            while (!((F <= A) && (d >= A)))
            {
                int N = K;
                F = 1;
                while (N > 1) F *= N--;
                int count = K + 1;
                d = 1;
                while (count > 1) d *= count--;
                K += 1;
            }
            Console.WriteLine(K - 1);*/
        }
    }
}

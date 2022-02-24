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
            /*  Console.WriteLine("Задание 1");
              Console.WriteLine("Введите трехзначное число");
              int G = Convert.ToInt32(Console.ReadLine());
              int P = G % 10;
              P = Convert.ToInt32(P);
              int H = ((G % 100) - P) / 10;
              int M = ((G % 1000) - (G % 100)) / 100;
              Console.Write(P);
              Console.Write(H);
              Console.Write(M);*/
            // 2 задание
            /* Console.WriteLine("Напишите двухзначное число по цифрам сначала деcятки, а поcле единицы");
             int A1 = Convert.ToInt32(Console.ReadLine());
             int B1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Напишите двухзначное число по цифрам сначала деcятки, а поcле единицы");
             int A2 = Convert.ToInt32(Console.ReadLine());
             int B2 = Convert.ToInt32(Console.ReadLine());
             int D = (A1 + A2);
             int E = (B1 + B2);
             Console.WriteLine("Десятков в числах = {0}", D);
             Console.WriteLine(" Единиц = {0}", E);*/
            // 3 задание
            /*Console.WriteLine(" Напишите два двухзначных числа");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = A + B;
            int E = C % 10;
            int D = (C - E) / 10;
            Console.WriteLine("Десятки = {0}", D);
            Console.WriteLine("Единицы = {0}", E);*/
            // 4 задание
            /*Console.WriteLine("Напишите три целочисленных числа ");
            int Q = Convert.ToInt32(Console.ReadLine());
            int W = Convert.ToInt32(Console.ReadLine());
            int E = Convert.ToInt32(Console.ReadLine());
            Boolean F = ((Q < 0) & (W > 0) & (E > 0))
                | ((Q > 0) & (W < 0) & (E > 0))
                | (Q > 0) & (W > 0) & (E < 0);
            Console.WriteLine(F);*/
        }
                
    }
}

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
            Console.WriteLine("введите n");
            Double n = Convert.ToDouble(Console.ReadLine());
            int g = 0;
            int h = 1;
            for (int count = 1; n >= count; count ++)
            {
                h += 2;
              g = g + h;
            }
            Console.WriteLine(g);


        }
    }
}
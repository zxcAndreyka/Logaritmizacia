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
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int k = 0;
            do
            {
               count ++;
                k += count;
                Console.WriteLine(k);
            }
            while(count < a );
            Console.WriteLine(k / 5);
            Console.ReadKey();

        }
    }
}

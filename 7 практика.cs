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
            /*Console.WriteLine("введите n");
            Double n = Convert.ToDouble(Console.ReadLine());
            int g = 0;
            int h = 1;
            for (int r = 1; n >= r; r++)
            {
                h += 2;
                g = g + h;
            }
            Console.WriteLine(g);*/

            // 3 задание
            /*Random x = new Random();
            int n = x.Next(1,11);
            Console.WriteLine("Попробуйте угадать число от 1-10, у вас есть 5 попыток");
            {
                for(int t = 0; t < 5; t++)
                {
                    int r=Convert.ToInt32(Console.ReadLine());
                    if (n == r)
                    {
                        Console.WriteLine("Поздравляю, вы угадали, загаданным числом было "+ n);
                    }
                    else if(r>10)
                    {
                        Console.WriteLine("Число должно быть от 1 до 10");
                    }
                    else
                        Console.WriteLine("Попробуйте снова");
                }
            }*/
            
            // 4 задание
            int n = Convert.ToInt32(Console.ReadLine());
            n = 2 * n + 1;
            double y = 0;
            y = Math.Sqrt(n); 
            for (int r = n - 2; r >= 1; r -= 2)
            {
                y = Math.Sqrt(r + y);
            }
            Console.WriteLine(y);   

            Console.ReadKey();

        }
    }
}

            
        

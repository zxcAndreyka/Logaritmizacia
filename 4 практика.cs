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
            /*  Console.WriteLine("напишите число от 1 до 999");
             double d = Convert.ToDouble(Console.ReadLine());
             double k = d % 10;
             double a = d % 100;

             if ((1 > d) || (999 < d))
             {
                 Console.WriteLine("число не входит в данный диапазон");

             }
             else
             {

                 if ((a > 10) && (a < 20))
                 {
                     Console.WriteLine(d + " рублей");
                 }
                 else
                 {
                     k = d % 10;

                     switch (k)
                     {
                         case 1:
                             Console.WriteLine(d + " рубль");
                             break;
                         case 2:
                         case 3:
                         case 4:
                             Console.WriteLine(d + " рубля");
                             break;
                         case 5:
                         case 6:
                         case 7:
                         case 8:
                         case 9:
                         case 0:
                             Console.WriteLine(d + " рублей");
                             break;
                         default:
                             Console.WriteLine(d + k);
                             break;

                     }

                 }

             }
             Console.ReadKey();*/

            //2 задание
            /*Console.WriteLine("Введите город или код города ");
            string x = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите время разговора ");
            double z = Convert.ToDouble(Console.ReadLine());
            switch (x)
            {
                case "Москва":
                case "095":
                    double y = z * 10;
                    Console.WriteLine("Сумма звонка составила:"+ " "+y +" " + "рубля");
                    break;
                case "Санкт-Петербург":
                case "812":
                    y = z * 10;
                    Console.WriteLine("Сумма звонка составила:" + " " + y + " " + "рубля");
                    break;
                case "Нальчик":
                case "0163":
                    y = z * 25.4;
                    Console.WriteLine("Сумма звонка составила:" + " " + y + " " + "рубля");
                    break;
                case "Южно-Сахалинск":
                case "4242":
                    y = z * 41.5;
                    Console.WriteLine("Сумма звонка составила:" + " " + y + " " + "рубля");
                    break;
                default:
                    Console.WriteLine("Данного города нет в нашей базе данных или название введено некоректно ");
                    break;*/

            //3 задание
            /*double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double b = Math.Pow(Math.E, x);
            double count = x - y;
            switch (count)
            {
                case 0:
                    double c = b * b + y * y + Math.Sin(y);
                    Console.WriteLine("Ответ: " + c);
                    break;
                case (> 0):
                    c = (b - y) * (b - y) + Math.Cos(y);
                    Console.WriteLine(c);
                    break;
                case (< 0):
                    c = y - b * b + Math.Tan(y);
                    Console.WriteLine(c);
                    break;
                default:
                    break;*/

            // 4 задание 
            /*Console.WriteLine("напишите число ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("напишите месяц с большой буквы, в именительном падеже ");
            string m = Convert.ToString(Console.ReadLine());
            if (n > 31)
            {
                Console.WriteLine("число не может превышать 31");
            }
            else if ((n > 30) && (m.Equals("Февраль")) || (m.Equals("Апрель"))
            || (m.Equals("Июнь")) || (m.Equals("Сентябрь")) || (m.Equals("Октябрь")))
            {
                Console.WriteLine("Число в данном месяце не может превышать 30 ");
            }
            else if (n == 1)
            {
                switch (m)
                {
                    case "Января":
                        Console.WriteLine("31 Декабря");
                        break;
                    case "Декабря":
                        Console.WriteLine("30 Ноября");
                        break;
                    case "Ноября":
                        Console.WriteLine("31 Октября");
                        break;
                    case "Октября":
                        Console.WriteLine("30 Сентября");
                        break;
                    case "Сентября":
                        Console.WriteLine("31 Августа");
                        break;
                    case "Августа":
                        Console.WriteLine("31 Июля");
                        break;
                    case "Июля":
                        Console.WriteLine("30 Июня");
                        break;
                    case "Июня":
                        Console.WriteLine("31 Мая");
                        break;
                    case "Мая":
                        Console.WriteLine("30 Апреля");
                        break;
                    case "Апреля":
                        Console.WriteLine("31 Марта");
                        break;
                    case "Марта":
                        Console.WriteLine("28 Февраля");
                        break;
                    case "Февраля":
                        Console.WriteLine("31 Января");
                        break;
                }
            }
            else if (n > 1)
            {
                int count = n - 1;
                Console.WriteLine(count + m);
            }
            else
            {
                Console.WriteLine("похоже вы ввели что то неправильно попробуйте еще раз");
            }
            Console.ReadKey();*/
        }

    }
}

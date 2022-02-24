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
            /*        Console.WriteLine("напишите число от 1 до 999");
                    double d = Convert.ToDouble(Console.ReadLine());
                        double k = d % 10;
                        double a = d % 100;

                        if ((1 > d) || (999 < d))
                        {
                            Console.WriteLine("число не входит в данный диапазон");

                        }
                        else { 

                            if ((a > 10) && (a < 20))
                            {
                                Console.WriteLine(d + " рублей");
                            }else
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


                        }*/


            Console.WriteLine("напишите число ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("напишите месяц с большой буквы р именительном падеже ");
            string m = Convert.ToString(Console.ReadLine());
            if (n > 31)
            {
                Console.WriteLine("число не может превышать 31");    
            }   
            else if ((n > 30) && (m.Equals("Февраль")) || (m.Equals("Апрель")) 
                || (m.Equals("Июнь")) || (m.Equals("Сентябрь")) || (m.Equals("Октябрь")))
                Console.WriteLine("Число в данном месяце не может превышать 30 ");
            Console.ReadKey();
        }
                
    }
}

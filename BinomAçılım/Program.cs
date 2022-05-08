using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinomAçılım
{
    class Binom
    {
        public static void Poztif(int n)
        {
            Console.WriteLine("---Sonuç---");
            int a = 1;
            for (int x = 0; x <= n; x++)
            {
                Console.Write(" "+a+"(X^"+(n-x)+"Y^"+(x)+(")"));
                a = a * (n - x) / (x + 1);
            }
        }
        public static void Negatif(int n)
        {
            Console.WriteLine("---Sonuç---");
            int a = 1;
            for (int x = 0; x <= n; x++)
            {
                if ((x%2)==0)
                {
                    Console.Write(" " + a + "(X^" + (n - x) + "Y^" + (x) + (")"));
                    a = a * (n - x) / (x + 1);
                }
                else
                {
                    Console.Write(" -" + a + "(X^" + (n - x) + "Y^" + (x) + (")"));
                    a = a * (n - x) / (x + 1);
                }
                
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Seçim yapınız (x+y)-1 (x-y)-2:");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kuvetini giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Binom.Poztif(n);
                    break;
                case 2:
                    Binom.Negatif(n);
                    break;
                default:
                    Console.WriteLine("Böyle bir seçim bunamamaktadır.");
                    break;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mukemelsayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sorgulamsı istenen sayıyı giriniz:");
            int ssayı = Convert.ToInt32(Console.ReadLine());
            int sayı = 0;

            for (int i = 0; i < ssayı; i++)
            {
                if (sayı == ssayı)
                {
                    Console.WriteLine("Müq sayı ");
                    break;
                }
                sayı = sayı + i;
                if (sayı > ssayı)
                {
                    Console.WriteLine("Müq sayı değil ");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}

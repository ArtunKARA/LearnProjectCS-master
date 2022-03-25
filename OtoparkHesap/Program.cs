using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkHesap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Otoparka park edilen araç türünü belirtiniz");
            Console.WriteLine("Araba 1");
            Console.WriteLine("Ticari araç 2");
            Console.WriteLine("Tır 3");
            int tür = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Konaklanan süreyi belirtiniz");
            int süre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------");
            double tutar;
            switch (tür)
            {
                case 1:
                    tutar = 5;
                    while (süre > 1)
                    {
                        tutar = tutar * 1.20;
                        süre -= 1;
                    }
                    Console.WriteLine("Tutar = " + tutar);
                    break;

                case 2:
                    tutar = 6;
                    while (süre > 1)
                    {
                        tutar = tutar * 1.215;
                        süre -= 1;
                    }
                    Console.WriteLine("Tutar = " + tutar);
                    break;

                case 3:
                    tutar = 6.5;
                    while (süre > 1)
                    {
                        tutar = tutar * 1.25;
                        süre -= 1;
                    }
                    Console.WriteLine("Tutar = " + tutar);
                    break;

                default:
                    Console.WriteLine("Girdiğiniz araç türü tanımlanmamıştır");
                    break;

            }
            Console.ReadKey();

        }
    }
}

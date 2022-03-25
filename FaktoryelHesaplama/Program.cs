using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoryelHesaplama
{
    internal class Program
    {
        static double Fact(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * Fact(x - 1);
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("faktoryeli hesaplanması isten sayıyı belirtiniz.");
            int sayı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fact(sayı));
            Console.ReadKey();
        }
    }
}

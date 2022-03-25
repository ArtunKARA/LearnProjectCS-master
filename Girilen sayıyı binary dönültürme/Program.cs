using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_sayıyı_binary_dönültürme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Binary Sayı Dönüştürücü-------");
            Console.Write("Bir sayı giriniz:");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int sayı2 = sayı;
            string iksayı = "";
            while (true)
            {
                iksayı = Convert.ToString(sayı2 % 2) + iksayı;
                sayı2 = sayı2 / 2;

                if (sayı2 < 1)
                {
                    break;
                }
            }


            Console.WriteLine(iksayı);
            Console.ReadLine();

        }
        static string don(string değer)
        {
            string ters = "";
            for (int i = değer.Length; i > 0; i--)
            {
                ters = ters + değer[i - 1];
            }
            return ters;
        }





        //static string bindön(int a)
        //{
        //    if (a > 0)
        //    {
        //        return Convert.ToString(a % 2)+bindön(a/2);
        //    }
        //    else
        //    {
        //        return Convert.ToString(a);
        //    }
        //}
    }
}

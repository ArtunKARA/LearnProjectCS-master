using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Metini_Tersten_Yazdıran
{
    internal class Program
    {
        static void Main(string[] args)
        //Girilen metni tersten yazdıran programı yazdırın
        {
            Console.Write("Girmek istediğiniz metni yazınız:");
            string metin;
            metin = Console.ReadLine();
            Console.WriteLine("--------Tersten Yazdırma-------");
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                Console.Write(metin[i]);
            }
            Console.ReadLine();

        }
    }
}

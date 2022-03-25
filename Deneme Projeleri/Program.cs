using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deneme_Projeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("E-posata adresini giriniz ?");
            string posta = Console.ReadLine();
            Console.WriteLine("-----------------------------");
            int konum = posta.IndexOf("@");
          
            string ad = posta.Substring(0, konum);
            string uzantı = posta.Substring(konum,( posta.Length-konum));
            Console.WriteLine("AD:"+ad);
            Console.WriteLine("Uzantı"+uzantı);
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
    }
}

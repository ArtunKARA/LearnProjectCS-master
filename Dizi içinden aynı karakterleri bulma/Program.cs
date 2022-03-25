using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dizi_içinden_aynı_karakterleri_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi için bir boyut belirleyiniz");
            int boyut = int.Parse(Console.ReadLine());
            int[] dizi = new int[boyut];
            //Array dizi = Array.CreateInstance(typeof(int), boyut);
            Random t = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = t.Next(100);
            }
            Console.WriteLine("-----------------------");
            foreach (var item in dizi)
            {
                Console.WriteLine("Eleman:" + item);
            }


            int seçilecek = t.Next(boyut - 1);
            int koyulanadet = t.Next(boyut - 1);
            int seçilen = dizi[seçilecek];
            for (int i = 0; i < koyulanadet; i++)
            {
                int yer = t.Next(boyut - 1);
                dizi[yer] = seçilen;
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Düzenlenmiş dizi");
            foreach (var item in dizi)
            {
                Console.WriteLine("Eleman:" + item);
            }

            int lokasyon = -1;
            int x = 0;
            int tekraradeti;
            tekraradeti = dizi.Length;
            int[] yerler = new int[tekraradeti];

            do
            {
                lokasyon += 1;
                lokasyon = Array.IndexOf(dizi, seçilen, lokasyon);
                yerler[x] = lokasyon;
                x += 1;
            } while (lokasyon != -1);
            for (int i = x; i < tekraradeti; i++)
            {
                yerler[x] = 0;
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("Tekraralanan değer:" + seçilen);
            int y = x;
            x = 0;
            do
            {
                Console.Write(yerler[x]+1+" ");
                x += 1;
            } while (x < y-1);

            


            Console.ReadLine();
        }
    }
}

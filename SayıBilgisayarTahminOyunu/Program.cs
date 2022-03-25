using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıBilgisayarTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi boyutunu gir.");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[boyut];
            Random r = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi.SetValue(r.Next(101), i);
            }
            yazdir(dizi, "Dizi");
            int x = -1;
            int y = 0;

            int sayaç = 0;
            int[] tahminler = new int[boyut];
            int tahmini;

            do
            {
                x = -1;
                sayaç = 0;
                do
                {
                    x += 1;
                    tahmini = r.Next(101);
                    sayaç += 1;

                } while (tahmini != dizi[y]);
                tahminler[y] = sayaç;
                y += 1;

            } while (y != boyut);
            x = 0;
            Console.WriteLine("-----------------------------");
            foreach (var item in tahminler)
            {
                x += 1;
                Console.WriteLine("Dizideki "+x+". elamanı "+item+" adet tahminde buldu");
            }



            Console.ReadLine();
        }
        static void yazdir(Array d, string islem)
        {
            Console.WriteLine("-----------" + islem + "--------");
            foreach (var item in d)
            {
                Console.WriteLine("Elaman:" + item);
            }
        }
    }
}


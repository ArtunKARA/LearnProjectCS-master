using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizimİleAlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşlem yapılacak şekili seçiniz");
            Console.WriteLine("1-Üçgen,2-Kare");
            int seçim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yüksekliğini giriniz:");
            double yukseklik = Convert.ToDouble(Console.ReadLine());
            Console.Write("Genişliğini giriniz:");
            double genislik = Convert.ToDouble(Console.ReadLine());
            Ucgen ucgen = new Ucgen(genislik, yukseklik);
            Dortgen dortgen = new Dortgen(genislik, yukseklik);
            switch (seçim)
            {
                case 1:
                    Console.WriteLine(ucgen.Alan());
                    break;
                case 2:
                    Console.WriteLine(dortgen.Alan());
                    break;
                default:
                    Console.WriteLine("Böyle bir seçim bulanmamaktadır");
                    break;
            }
            Console.ReadKey();
        }
        class Sekil
        {
            public double genislik;
            public double yukseklik;
            public virtual double Alan()
            {
                return yukseklik * genislik;
            }
        }
        class Ucgen : Sekil
        {
            public Ucgen(double g, double y) { this.genislik = g; this.yukseklik = y; }
            public override double Alan()
            {
                return (base.Alan()) / 2;
            }
        }
        class Dortgen : Sekil
        {
            public Dortgen(double g, double y) { this.genislik = g; this.yukseklik = y; }
        }
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractİleAlan
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sekil[] sekiler =new Sekil[] {new Daire(6),new Dörtgen(3,7)};
            foreach(var sekil in sekiler)
            {
                Console.WriteLine(sekil.Alan());
            }
            Console.Read();
        }
        abstract class Sekil
        {
            abstract public double Alan();
        }
        class Daire : Sekil
        {
            public double Yarıçap { get; set; }
            public Daire(double r) {this.Yarıçap=r; }
            public override double Alan()
            {
                return Math.PI * Math.Pow(Yarıçap, 2);
            }
        }
         class Dörtgen : Sekil
        {
            public double Yukseklik { get; set; }
            public double Genişlik { get; set; }
            public Dörtgen(double x, double y) { this.Yukseklik = y; this.Genişlik = x; }
            public override double Alan()
            {
                return Yukseklik * Genişlik;
            }

        }

    }
}

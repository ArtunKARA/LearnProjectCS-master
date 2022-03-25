using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace İnterfacesİleAlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ISekil[] sekils = new ISekil[] { new Daire(4), new Kare(4, 3) };
            foreach(var sekil in sekils)
            {
                Console.WriteLine(sekil.Alan());
                Console.WriteLine(sekil.Çevre());
                Console.WriteLine("");
            }

            Console.WriteLine(((Convert.ToString(sekils[0].Alan())).Length)- (Convert.ToString(sekils[0].Alan()).IndexOf(",")+1));
            Console.ReadKey();
        }
        interface ISekil
        {
            double Alan();
            double Çevre();

        }
        class Kare : ISekil
        {
            public double Yukseklik { get; set; }
            public double Genislik { get; set; }
            public Kare(double g, double y)
            {
                this.Yukseklik=y; this.Genislik=g;
            }
            public double Alan()
            {

                return Yukseklik * Genislik;
            }
            public double Çevre()
            {
                return Yukseklik * 2 + Genislik * 2;
            }


        }
        class Daire : ISekil
        {
            public double Yarıçap { get; set; }
            public Daire(double r) {  this.Yarıçap=r; }
            public double Alan()
            {
                return Math.PI * Math.Pow(Yarıçap, 2);
            }
            public double Çevre()
            {
                return 2 * Math.PI * Yarıçap;
            }

        }



    }
}


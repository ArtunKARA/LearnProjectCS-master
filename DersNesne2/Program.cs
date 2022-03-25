using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersNesne2
{
    abstract class Personel
    {
        public static int id = 0;
        protected string adsoyad;
        protected double maaş;
        public Personel(string adsoyad)
        {
            id++;
            this.adsoyad = adsoyad;
        }
        virtual public void yazdır()
        {
            Console.WriteLine("Adsoyad:" + adsoyad);
            Console.WriteLine("Personel Sırası:" + id);
        }
    }
    class Öğretmen : Personel
    {
        protected int derssaati;
        string bölüm;
        private static int öid;
        public Öğretmen(int derssati, string bölüm, string adsoyad) : base(adsoyad)
        {
            this.derssaati = derssati;
            this.bölüm = bölüm;
            öid++;
        }
        override public void yazdır()
        {
            Console.WriteLine("----Öğretmen----");
            base.yazdır();
            Console.WriteLine("Öğretmen Sırası:" + öid);
        }
    }
    sealed class Müdür : Öğretmen
    {
        
        string ünvan;
        private static int mid;

        public Müdür(int derssati, string ünvan, string bölüm, string adsoyad) : base(derssati, adsoyad, bölüm)
        {
            this.derssaati = derssati;
            this.ünvan = ünvan;
            mid++;
        }
        override public void yazdır()
        {
            Console.WriteLine("----Müdür----");
            base.yazdır();
            Console.WriteLine("Öğretmen Sırası:"+mid);
            Console.WriteLine("Ünvan:"+ünvan);
        }
    }

    class YPersonel : Personel
    {
        int derssaati;
        string bölüm;
        public YPersonel(int derssati, string bölüm, string adsoyad) : base(adsoyad)
        {
            this.derssaati = derssati;
            this.bölüm = bölüm;
        }
        override public void yazdır()
        {
            Console.WriteLine("----YPersonel----");
            base.yazdır();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Müdür m1 = new Müdür(10, "zenginlik", "finans", "tuncay");
            m1.yazdır();
            Öğretmen ö2 = new Öğretmen(12, "blişim", "artun");
            ö2.yazdır();

            Console.ReadKey();
        }
    }
}

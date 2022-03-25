using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeNesne1
{
    abstract class Taşıt 
    {
        protected int  depo;
        protected string renk;
        protected static int tsayaç = 0;
       public Taşıt(int depo,string renk)
        {
            this.depo = depo;
            this.renk = renk;
            tsayaç++;
        }
        virtual public void Yazdır()
        {
            Console.WriteLine("Renk:"+renk);
            Console.WriteLine("Depo:"+depo);
        }

    }
    sealed class Kamyon : Taşıt
    {
        private int yük;
        private static int ksayaç = 0;
        private int ağırlık 
        {
            get
            {
                return yük + 500;
            }
            set
            {
                if(1000<value)
                {
                    yük = 1000;
                }
                else
                {
                    yük = value;
                }
            }
        }
        public Kamyon(int depo,string renk,int yük) : base(depo, renk)
        {
            this.ağırlık = yük;
            ksayaç++;
        }
        override public void Yazdır()
        {
            Console.WriteLine("---Kamyon---");
            base.Yazdır();
            Console.WriteLine("Yük:"+yük);
            Console.WriteLine("Ağırlık:"+ağırlık);

        }
       
    }
    abstract class Araba : Taşıt
    {
        private static int asayaç = 0;
        private int koltuk;
        protected int ksayı
        {
            get
            {
                return koltuk;
            }
            set
            {
                if (value >= 2 && value <= 5)
                {
                    koltuk = value;
                }
                else
                {
                    koltuk = 6;
                }
            }

        }
        public Araba(int ksayı, int depo, string renk) : base(depo, renk)
        {
            this.ksayı = ksayı;
            asayaç++;
        }

        override public void Yazdır()
        {
            Console.WriteLine("---Araba---");
            base.Yazdır();
            Console.WriteLine("Koltuk Sayısı:"+ksayı);
        }
    }
    class Sedan : Araba
    {
        public int fiyat;
        public static int ssayac=0;


        public Sedan(int fiyat, int ksayı,string renk,int depo):base(ksayı,depo,renk)
        {
            this.fiyat = fiyat;
            ssayac++;
        }
        override public void Yazdır()
        {
            Console.WriteLine("---Sedan---");
            base.Yazdır();
            Console.WriteLine("Fiyat:"+fiyat);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

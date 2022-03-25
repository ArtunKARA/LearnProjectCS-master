using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oporotörler
{
    class Dolap
    {
        public int en;
        public int boy;
        private int gen;
        public int genişlik
        {
            get { return gen; }
            set
            {
                if (value < 11)
                {
                    gen = value;
                }
                else { gen = 0; }
            }
        }


        public int hacim
        {
            get { return en * boy * genişlik; }
        }
        public Dolap(int en, int boy, int genişlik)
        {
            this.en = en;
            this.boy = boy;
            this.genişlik = genişlik;
        }
        
        public static Dolap operator +(Dolap a, Dolap b) 
        {
            return new Dolap(a.boy+b.boy,a.boy+b.boy,a.genişlik+b.genişlik);
        }
       internal void Yazdır() 
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("En:"+en);
            Console.WriteLine("Boy:"+boy);
            Console.WriteLine("Genişlik"+genişlik);
            Console.WriteLine("Hacim:"+hacim);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolap d1 = new Dolap(2, 2, 2);
            Dolap d2 = new Dolap(3, 3, 3);
            Dolap d3 = d1 + d2;
            d1.Yazdır();
            d2.Yazdır();
            d3.Yazdır();
            Console.ReadKey();
        }
    }
}

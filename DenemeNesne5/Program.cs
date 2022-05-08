using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DenemeNesne5
{
    abstract class Insan
    {
        protected int kilo;
        protected int boy;
        public Insan(int kilo, int boy)
        {
            this.kilo = kilo;
            this.boy = boy;
        }
        public Insan(Insan i)
        {
            this.boy = i.boy;
            this.kilo = i.kilo;
        }
    }
    sealed class Tuncay : Insan
    {

        int tkilo;
        public double toran 
        {
            get
            {
                return Convert.ToDouble(tkilo)/Convert.ToDouble(kilo)*100;
            }
        }
        public Tuncay(int tkilo, int kilo, int boy) : base(kilo, boy)
        {
            this.tkilo = tkilo;
        }
        public Tuncay(Tuncay t) : base(t)
        {
            this.tkilo = t.tkilo;
        }
        public static bool operator==(Tuncay a,Tuncay b)
        {
            if (a.boy==b.boy&&a.kilo==b.kilo&&a.tkilo==b.tkilo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator != (Tuncay a, Tuncay b)
        {
            if (a.Equals(b))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Yazdır()
        {
            Console.WriteLine("Kilon:"+kilo);
            Console.WriteLine("Boyun:" + boy);
            Console.WriteLine("Tkilon:"+tkilo);
            Console.WriteLine("Toranın:"+toran);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tuncay t1 = new Tuncay(100, 101, 190);
            t1.Yazdır();
            Tuncay t2 = new Tuncay(t1);
            Console.WriteLine(t1==t2);
            Console.Read();


        }
    }
}

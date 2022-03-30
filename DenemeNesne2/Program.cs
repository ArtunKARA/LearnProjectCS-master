using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeNesne2
{
    abstract class Hesap
    {
        public int r;
        public Hesap(int r)
        {
            this.r = r;
        }
        virtual public void Alan()
        {

        }
        virtual public void Çevre()
        {

        }
    }
    sealed class Daire:Hesap
    {
        public Daire(int r):base(r)
        {
        }
        public override void Alan()
        {
            Console.WriteLine("Alan"+Math.PI*Math.Pow(Convert.ToDouble(r),2));
        }
        public override void Çevre()
        {
            Console.WriteLine("Çevre:"+2*Math.PI*r);
        }
    }
    sealed class Kare:Hesap
    {
        public Kare(int r) : base(r)
        {

        }
        public override void Alan()
        {
            Console.WriteLine("Alan" +r*r );
        }
        public override void Çevre()
        {
            Console.WriteLine("Çevre:"+r*4);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Daire d1 = new Daire(4);
            d1.Çevre();
            d1.Alan();
            Kare k1 = new Kare(6);
            k1.Alan();
            k1.Çevre();
            Console.ReadKey();
        }
    }
}

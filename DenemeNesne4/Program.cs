using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeNesne4
{
    static class Hesap
    {
        static public void Alan(int r)
        {
            Console.WriteLine("Daire:"+Math.PI*r*r);
        }
        static public void Alan(int a,int b)
        {
            Console.WriteLine("Dörtgen:"+a*b);
        }
        static public void Çevre(int r)
        {
            Console.WriteLine("Daire:"+Math.PI*r*2);
        }
        static public void Çevre(int a,int b)
        {
            Console.WriteLine("Dörtgen:"+(a+b)*2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hesap.Alan(4);
            Hesap.Alan(2, 3);
            Hesap.Çevre(3);
            Hesap.Çevre(6, 3);
            Console.ReadKey();
        }
    }
}

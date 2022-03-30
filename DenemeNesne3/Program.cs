using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeNesne3
{
    class Hesap
    {
        public int r;
        private int seç;
        public Hesap(int r, int seç)
        {
            this.r = r;
            this.seç = seç;
        }
        public void Çevre()
        {
            switch (seç)
            {
                case 1:
                    Console.WriteLine("Çevre:" + r * 4);
                    break;
                case 2:
                    Console.WriteLine("Çevre:" + Math.PI * r * 2);
                    break;
                default:
                    Console.WriteLine("hatalı seçim");
                    break;
            }
        }
        
        public void Alan()
        {
            switch (seç)
            {
                case 1:
                    Console.WriteLine("Alan:" + r * 4);
                    break;
                case 2:
                    Console.WriteLine("Alan:" + Math.PI * r * r);
                    break;
                default:
                    Console.WriteLine("hatalı seçim");
                    break;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

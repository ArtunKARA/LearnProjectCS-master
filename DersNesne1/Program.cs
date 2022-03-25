using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersNesne1
{
    abstract class a 
    { 
     public int x = 1;
     protected int y = 2;
    }
     sealed class b : a
    { 
        public void yaz()
        {
            x = 1;
            y = 2;
        }
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "wewewewewew";
            string ad1 = ad.Split(' ')[0];
            foreach (var item in ad1)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}

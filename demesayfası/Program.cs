using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demesayfası
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.Clear();
                Console.Write("1.Sayıyı Giriniz:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("1.Sayıyı Giriniz:");
                int b = Convert.ToInt32(Console.ReadLine());
                if(a == b)
                { 
                    Console.WriteLine("Girilen sayılar eşit");
                    Console.Write("Herhangi bir tuşa basınız");
                    Console.ReadKey();
                    continue;
                }
                if(b < a) 
                {
                    int t =a;
                    a= b;
                    b= t;
                }
                for (int i = a;  i <= b; i++)
                {
                    if (i%2==0||i%5==0)
                    {
                        Console.Write(i+" ");
                    }
                }
                Console.ReadKey();
                break;

            }

        }
    }
}

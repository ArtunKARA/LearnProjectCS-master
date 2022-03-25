using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] maray = new int[40];
            Random r = new Random();

            for (int i = 0; i < maray.Length; i++)
            {
                Thread.Sleep(0);
                maray[i] = (r.Next() % 200 + 9) + 10;
            }
            int[] aray1 = new int[10];
            int[] aray2 = new int[10];
            int[] aray3 = new int[10];
            int[] aray4 = new int[10];
            for (int i = 0; i < maray.Length; i++)
            {
                
                if (i < 10)
                {
                    aray1[i] = maray[i];
                    continue;
                }
                if (i < 20)
                {
                    aray2[i - 10] = maray[i];
                    continue;
                }
                if (i < 30)
                {
                    aray3[i - 20] = maray[i];
                    continue;
                }
                if (i < 40)
                {
                    aray4[i - 30] = maray[i];
                    continue;
                }

            }
            foreach (var item in aray1)
            {
                Console.Write(item+" ");
            }
            Console.Write("   ");
            foreach (var item in aray2)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("");
            foreach (var item in aray3)
            {
                Console.Write(item + " ");
            }
            Console.Write("   ");
            foreach (var item in aray4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------");
            Array.Reverse(aray1);
            Array.Reverse(aray2);
            Array.Reverse(aray3);
            Array.Reverse(aray4);
            foreach (var item in aray1)
            {
                Console.Write(item + " ");
            }
            Console.Write("   ");
            foreach (var item in aray2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            foreach (var item in aray3)
            {
                Console.Write(item + " ");
            }
            Console.Write("   ");
            foreach (var item in aray4)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
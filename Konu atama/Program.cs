using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu_atama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kişi sayısı belirle:");
            int person =Convert.ToInt32(Console.ReadLine());
            Random r1 = new Random(person);
            int[] queue = new int[person];
            foreach (var item in queue)
            {
                r1 = new Random(item);
                while (true)
                {

                }
            }
            Console.WriteLine("---Kişi Konu Eşleşmesi---");
            for (int i = 0; i < person; i++)
            {
                Console.WriteLine((i+1)+":");
            }
        }
    }
}

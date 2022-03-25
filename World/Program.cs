using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;
            bool d=false;
            while (count<10)
            {
                if (true==words[count].Contains(letter))
                {
                    Console.WriteLine(words[count]);
                    d= true;
                }

                count++;
            }
            if (false==d)
            {
                Console.WriteLine("Not match");
            }
            Console.ReadKey();


        }
    }
}

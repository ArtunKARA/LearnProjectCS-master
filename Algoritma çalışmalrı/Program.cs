using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_çalışmalrı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.SpinWords("Adam severler"));
            Console.ReadKey();
        }
    }
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            string nsentence = "";
            
            string[] worlds = sentence.Split(' ');
            foreach (var world in worlds)
            {
                if (world.Length < 5)
                {
                    nsentence += world + " ";
                }
                else
                {
                    string reverse = "";
                    for (int i = world.Length - 1; i >= 0; i--)
                        reverse += world[i];
                    nsentence += reverse+" ";
                }

            }
            return nsentence.Substring(0,nsentence.Length-1);
        }



    }

}

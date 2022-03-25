using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖTV_Hesaplma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Satın alınan aracın tutarını giriniz.");
            int araç = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Aracın yaşını giriniz.");
            Console.WriteLine("Aracın yaşı 1-3 ise 1'e basınız.");
            Console.WriteLine("Aracın yaşı 4-7 ise 2'e basınız.");
            Console.WriteLine("Aracın yaşı 7 yaş üstü ise 3'e basınız.");
            int yaş = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Aracın motor hacmini giriniz.");
            Console.WriteLine("0-1300 arasında ise 1");
            Console.WriteLine("1300-1600 arasında ise 2");
            Console.WriteLine("1600- 2000 arasında ise 3");
            Console.WriteLine("2000 den büyük ise ise 4");
            int hacim = Convert.ToInt32(Console.ReadLine());
            double tutar =0;
            switch (yaş)
            {
                case 1:
                    tutar = araç * 1.75;
                    break;
                case 2:
                    tutar = araç * 1.5;
                    break;
                case 3:
                    tutar = araç * 1.25;
                    break;

                default:
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Tanımlanan yaş türü opsiyonu bulumamaktadır litfen tekrar programı başlatınız.");
                    Console.WriteLine("---------------------------------------");
                    break;
            }
            switch (hacim)
            {
                case 1:
                    tutar = tutar * 2;
                    break;

                case 2:
                    tutar = tutar * 3;
                    break;

               case 3:
                    tutar = tutar * 4;
                    break;

                case 4:
                    tutar = tutar * 5;
                    break;

                default:
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Tanımlanan motor hacimi türü opsiyonu bulumamaktadır litfen tekrar programı başlatınız.");
                    Console.WriteLine("---------------------------------------");
                    break;
            }
            string stutar = Convert.ToString(tutar);
            string svergi = Convert.ToString(tutar-araç);
            string stutarn= stutar.Substring(0,((stutar.Length)%3));
            string svergin = stutar.Substring(0, ((svergi.Length) % 3));

                for (int i = 0; i < (stutar.Length); i++)
                {
                stutarn += (".");
                stutarn = stutar.Substring(0,(i*3));
                }
            for (int i = 0; i < (svergi.Length); i++)
            {
                svergin += (".");
                svergin = svergi.Substring(0, (i * 3));
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Aracın ötv miktarı "+svergin);
            Console.WriteLine("Ötvli araç " + stutarn);
            Console.ReadKey();




        }
    }
}

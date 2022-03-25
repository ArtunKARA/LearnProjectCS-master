using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfÖğrenciDurum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.Name = "Ali";
            ogrenci1.Surname = "Kesmeşeker";
            ogrenci1.Age = 21;
            ogrenci1.Tcno = "12456793740";
            ogrenci1.Area = "Tatalandırıcı Mühendisliği";

            Ogrenci ogrenci2 = new Ogrenci();

            ogrenci2.Name = "Mehmetov";
            ogrenci2.Surname = "Tarkovoski";
            ogrenci2.Age = 10;
            ogrenci2.Tcno = "122343567623454312";
            ogrenci2.Area = "Ruski Vodka İmalatı";

            Ogrenci ogrenci3 = new Ogrenci();

            ogrenci3.Name = "Hüsnüsu";
            ogrenci3.Surname = "Dönenler";
            ogrenci3.Age = 18;
            ogrenci3.Tcno = "12908764021";
            ogrenci3.Area = "Adamlık VE Rajon Teknojileri";

            Ogrenci[] ogrenciler =new Ogrenci[] {ogrenci1,ogrenci2, ogrenci3 };

            foreach (var item in ogrenciler)
            {
                Console.WriteLine("Ad:"+item.Name);
                Console.WriteLine("Soyad:"+item.Surname);
                Console.WriteLine("Yaş:"+item.Age);
                Console.WriteLine("Tc Numarası:"+item.Tcno);
                Console.WriteLine("Bölüm:"+item.Area);
                Console.WriteLine("");
            }

        
            Console.ReadKey();
        }
        class Ogrenci
        {
            private string tcno;
            private string area;
            private int age;

            public string Name { get; set; }
            public string Surname { get; set; }
            public string Area
            {
                get { return area; }
                set { area = value; }
            }

            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 18)
                    {
                        age = 18;
                    }
                    else
                    {
                        age = value;
                    }
                }

            }

            public string Tcno
            {
                get { return tcno; }
                set
                {
                    if (11 == value.Length && (Convert.ToInt16(value.Substring(10, 1)) % 2) == 0)
                    {
                        tcno = value;
                    }
                    else if (11 == value.Length)
                    {
                        tcno = "Sistemde bulunan Tc no hatalı rakam ile bitmektedir";
                    }
                    else
                    {
                        tcno = "Sistemde bulunan TC no hatalıdır " + Convert.ToString(value.Length - 11) + " adet rakam farkı vardır";
                    };
                }
            }
        }


    }
}

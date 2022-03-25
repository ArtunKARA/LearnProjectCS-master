using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulanıcıŞifrelemeHesapMakinası
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorgu sorgu = new Sorgu();
            int denemehakı1 = 0;
            
            do
            {
                Console.Write("Kulanıcı adı:");
                string ad = Console.ReadLine();
                Console.Write("Şifre:");
                string parola = Console.ReadLine();
                if (true == sorgu.Kontrol(ad, parola))
                {
                    Console.Clear();
                    Console.WriteLine("----Hesap makinası----");
                    Hesap hesap = new Hesap();
                    double sonuç = 0;
                    double işlenen = Console.Read();
                    string işlem;
                    do
                    {
                       işlem=Convert.ToString(Console.ReadKey());

                    } while (işlem != "=");
                    Console.WriteLine(sonuç);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Kulanıcı adı şifre hatalıdır.");
                }
                denemehakı1++;
            } while (denemehakı1 < 3);
            Console.Clear();
            Console.WriteLine("Kulanıcı adı şifre hatalıdır.");
            Console.WriteLine("Program sonlandırılmıştır.");
            Console.ReadKey();
        }
        class Hesap
        {
            private string işlem;
            public string İşlem
            {
                get { return işlem; }

                set
                {
                    string[] kontrol = new string[] {"+","-","*","/","=" };
                    int sayo=0;
                    do
                    {
                        if (value==kontrol[sayo])
                        {
                            işlem = kontrol[sayo];
                            break;
                        }
                        sayo++;
                    } while (sayo<4);
                    if (sayo==4)
                    {
                        işlem = "=";
                    }
                }




            }
        }
        class Sorgu
        {
            private string ad1 = "Ahmedow";
            private string ad2 = "Süleyman";
            private string sifre1 = "1234";
            private string sifre2 = "adamss";
            public bool Kontrol(string ad, string parola)
            {
                if (ad == ad1)
                {
                    if (parola == sifre1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (ad == ad2)
                {
                    if (parola == sifre2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

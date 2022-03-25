using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakıt_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] satılanlar = { 10, 1, 0.75, 0.50 };
            double[] satılanlitreler = { 1000, 1000, 1000 };
            //dizel = 1
            //benzin = 0.75
            //lpg = 0.50
            //dolar = 10
            //dizell = 1000
            //lpgl = 1000
            //benzinl = 1000
            double satılanlitre, satılanücret;


            int satılantür;
            int seçim = 0;
            int dön = 1;

            int fdön;
            do
            {
                Console.WriteLine("      Akaryakıt Satış Takip");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("1. Birim Fiyat Göster");
                Console.WriteLine("2. Birim Fiyat Güncelle");
                Console.WriteLine("3. Akaryakıt satışı yap");
                Console.WriteLine("4. Depo Durumu Göster");
                Console.WriteLine("5. Toplam Satışları Göster");
                Console.WriteLine("6. Depo Dolumu");
                Console.WriteLine("7. Çıkış");
                Console.Write("Lütfen seçiminizi yapınız:");
                seçim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (seçim)
                {
                    case 1:
                        Console.WriteLine("Güncel Akaryakıt Fiyatları");
                        Console.WriteLine("Güncel DOLAR kuru:" + satılanlar[0]);
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Dizel Dolar:" + satılanlar[1]);
                        Console.WriteLine("Dizel TL:" + satılanlar[1] * satılanlar[0]);
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Benzin Dolar:" + satılanlar[2]);
                        Console.WriteLine("Benzin TL:" + satılanlar[2] * satılanlar[0]);
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("LPG Dolar:" + satılanlar[3]);
                        Console.WriteLine("LPG TL:" + satılanlar[3] * satılanlar[0]);
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Bir üst menüye dönmek için 1'e basınız");
                        dön = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("----------Fiyat Günceleme Ekranı-------------");
                            Console.WriteLine("1 Dolar");
                            Console.WriteLine("2 Dizel");
                            Console.WriteLine("3 Benzin");
                            Console.WriteLine("4 LPG");
                            Console.Write("Güncelenmek istenen fiyatı seçiniz:");
                            int fseçim = Convert.ToInt32(Console.ReadLine());

                            switch (fseçim)
                            {
                                case 1:
                                    Console.WriteLine("---------------------------------------");
                                    Console.Write("Güncel Dolar kuru:");
                                    satılanlar[0] = Convert.ToDouble(Console.ReadLine());
                                    break;
                                case 2:
                                    Console.WriteLine("---------------------------------------");
                                    Console.Write("Dolar-Dizel:");
                                    satılanlar[1] = Convert.ToDouble(Console.ReadLine());
                                    break;
                                case 3:
                                    Console.WriteLine("---------------------------------------");
                                    Console.Write("Dolar-Benzin:");
                                    satılanlar[2] = Convert.ToDouble(Console.ReadLine());
                                    break;
                                case 4:
                                    Console.WriteLine("---------------------------------------");
                                    Console.Write("Dolar-LPG:");
                                    satılanlar[3] = Convert.ToDouble(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("---------------------------------------");
                                    Console.WriteLine("Aranılan fiyat bulunmamaktadır");
                                    break;
                            }
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("Fiyat değişikliğine devam etmek için 1'e basınız");
                            fdön = Convert.ToInt32(Console.ReadLine());
                        } while (fdön == 1);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("-----------Akaryakıt Satış Ekranı------------");
                        Console.WriteLine("1 Dizel");
                        Console.WriteLine("2 Benzin");
                        Console.WriteLine("3 LPG");
                        Console.Write("Satılmak isten akaryakıt türünü seçiniz:");
                        satılantür = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Satılacak Birim (1:Litre) (2:TL)");
                        Console.Write("Seçiminizi  yapınız:");
                        int satıştür = Convert.ToInt32(Console.ReadLine());
                        if (satıştür == 1)
                        {
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("Mevcut depo seviyesi" + satılanlitreler[satılantür - 1]);
                            Console.Write("Satılan litreyi giriniz: ");
                            satılanlitre = Convert.ToDouble(Console.ReadLine());
                            if (satılanlitre > satılanlitreler[satılantür])
                            {
                                Console.WriteLine("--------------------------------------------");
                                Console.WriteLine("Yeterli yakıt bulunmamaktadır!");
                                Console.WriteLine("Devam etmek için herhangibi bir tuşa basınız");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("Tutar TL:" + (satılanlitre * satılanlar[0] * satılanlar[satılantür]));
                            satılanlitreler[satılantür] = satılanlitreler[satılantür - 1] - satılanlitre;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {

                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("Mevcut depo seviyesi" + satılanlitreler[satılantür - 1]);
                            Console.WriteLine("Mevcut depo değeri TL:" + satılanlitreler[satılantür - 1] * satılanlar[0] * satılanlar[satılantür] + " TL");
                            Console.Write("Satılacak akarayakıt tutarunu giriniz: ");
                            satılanücret = Convert.ToDouble(Console.ReadLine());
                            if (satılanücret > satılanlitreler[satılantür - 1] * satılanlar[0] * satılanlar[satılantür])
                            {
                                Console.WriteLine("--------------------------------------------");
                                Console.WriteLine("Yeterli yakıt bulunmamaktadır!");
                                Console.WriteLine("Devam etmek için herhangibi bir tuşa basınız");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("Tutar TL:" + satılanücret);
                            satılanlitreler[satılantür] = satılanlitreler[satılantür - 1] - (satılanücret / satılanlar[satılantür]);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        Console.WriteLine("----------------------Depodaki Litreler-----------------------------------");
                        Console.WriteLine("Dizel:" + satılanlitreler[0]);
                        Console.WriteLine("Benzin:" + satılanlitreler[1]);
                        Console.WriteLine("LPG:" + satılanlitreler[2]);
                        Console.WriteLine("Devam etmek için herangibi bir tuşa basınız");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:

                        break;

                    case 6:
                        Console.WriteLine("-----------Depo Dolum Ekranı----------");
                        Console.WriteLine("Depo Mevcudiyeti" +
                            " Dizel:" + satılanlitreler[0] + " Benzin:" + satılanlitreler[1] + " LPG:" + satılanlitreler[2]);
                        Console.Write("1 Dizel");
                        Console.Write(" 2 Benzin");
                        Console.WriteLine(" 3 LPG");
                        Console.Write("Eklenecek Akaryakıt Türünü Giriniz:");
                        satılantür = Convert.ToInt32(Console.ReadLine());
                        switch (satılantür)
                        {
                            case 1:
                                Console.WriteLine("Eklenecek Dizel Miktarını Giriniz");
                                satılanlitreler[0] = satılanlitreler[0] + Convert.ToDouble(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Eklenecek Benzin Miktarını Giriniz");
                                satılanlitreler[1] = satılanlitreler[1] + Convert.ToDouble(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 3:
                                Console.WriteLine("Eklenecek LPG Miktarını Giriniz");
                                satılanlitreler[2] = satılanlitreler[2] + Convert.ToDouble(Console.ReadLine());
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("girdiğiniz Türde Akaryakıt Tanımlanmamıştır" +
                                    "Üst menüye dönmek için her hangi bir tuşa basınız.");
                                Console.ReadKey(true);
                                Console.Clear();
                                break;
                        }


                        break;
                    case 7:
                        break;
                    default:
                        do
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("!!Yanlış seçim yaptınız!!");
                            Console.WriteLine("Seçiminiz 1-7 arasında olmalı");
                            Console.WriteLine("Programa devam etmek için 1'e basınız");
                            dön = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        } while (dön > 7);
                        break;
                }
            } while (seçim < 7 && dön == 1);

        }
    }
}

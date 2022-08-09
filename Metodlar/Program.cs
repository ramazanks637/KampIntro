﻿using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] { urun1,urun2};

            // type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " => "+ urun.Fiyati  + "TL => "+ urun.Aciklama );
            }

            Console.WriteLine("----------------------------Metodlar------------------------------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut",12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma",12,9);
            sepetManager.Ekle2("Karpuz", "diyarbakır Karpuzu",12,8);

        }
    }
}


// Dont repeat yourself - DRY

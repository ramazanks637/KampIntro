using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Odev3
{
    class MusteriManager
    {
        List<Musteri> musterilistesi = new List<Musteri>();

        public void Ekle()
        {

            Console.WriteLine("Musteri Adı: ");
            string Adistenen = Console.ReadLine();
            Console.WriteLine("Musteri Soyadı: ");
            string Soyadistenen = Console.ReadLine();
            Console.WriteLine("Musteri Tc: ");
            string Tcistenen = Console.ReadLine();

            musterilistesi.Add(new Musteri() { Ad=Adistenen, Soyad=Soyadistenen, Tc=Tcistenen});
           
            Console.WriteLine("Musteri eklendi:" + Adistenen + " " + Soyadistenen);
        }
        public void Sil()
        {
            Console.WriteLine("Silinecek Musteri Tc: ");
            string istenenTc = Console.ReadLine();
            for (int i = 0; i < musterilistesi.Count(); i++)
            {
                Console.WriteLine("musteri silindi");
                musterilistesi.RemoveAt(i);
            }

        }

        public void Listele()
        {
            Console.WriteLine("MÜşteri Listesi :");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < musterilistesi.Count(); i++)
            {
                Console.WriteLine(musterilistesi[i].Ad + musterilistesi[i].Soyad);
            }
        }


    }
}

using System;

namespace Hafta3_Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            
            while (true)
            {
                Console.WriteLine("[1] Müşteri Ekle");
                Console.WriteLine("[2] Müşteri Sil");
                Console.WriteLine("[3] Müşteri Listele");
                Console.WriteLine("[4] Programı Bitir");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:

                        musteriManager.Ekle();
                        break;
                    case 2:
                        musteriManager.Sil();
                        break;
                    case 3:
                        musteriManager.Listele();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Hatalı bir giriş yapıldı !!");
                        break;
                }

            }
            
        }
    }
}

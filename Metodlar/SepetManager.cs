using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {
        // Naming Convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi: "+urun.Adi);
        }

        //public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        //{
        //    Console.WriteLine("Sepete eklendi: " + urunAdi);
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention -- isimlendirme kuralı 
        // Methodun ilk harfi büyük yazılır.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi." + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdeti)
        {
            Console.WriteLine("Tebrikler sepete eklendi." + urunAdi);
        }
    }
}

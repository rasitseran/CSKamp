using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //type safe  -  tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("-------metotlar--------");
            //instance -- örnek
            //encapsulatıon
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("-------metotlar--------");

            sepetManager.Ekle2("armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("karpuz", "Yeşil karpuz", 12, 8);
        }
    }
}

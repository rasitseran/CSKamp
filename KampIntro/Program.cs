using System;

namespace ders_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety : tip güvenliği
            // noktalı virgül koymak zorunlu 
            // C# katı bir dil herşeyi tanımlamak gerekiyor.
            // dont repeat yourself - kendini tekrar etme tekrar eden herşey için değişken oluştur.

            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000; //integer tamsayı demek
            double faizOranı = 1.45; //ondalıklı sayılar için kullanılır.
            bool sistemeGirisYapmisMi = false; //sadece doğru veya yanlış depğer içeren veri tipi True false kullanılır.
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) //
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu"); //Sart blokları Eğer şart doğru ise şuna yap. değilse şunu yap.
            }
            Console.WriteLine(kategoriEtiketi); //kategoriEtiketi = değer tutucu alias olarak isimlendirilir.

        }
    }
}

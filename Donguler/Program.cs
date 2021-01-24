using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler birşeyleri tekrar etmek için kullanılan yapılardır.
            //string kurs1 = "Yazılımcı geliştirme kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "java kodlama";

            //Array - dizi yani çoğul değerler

            string[] kurslar = new string[] { "Yazılımcı geliştirme kampı",
                "Programlamaya başlangıç için temel kurs",
                "java kodlama" };



            for (int i = 0; i < kurslar.Length; i++) // Burada i< kısmına belli bir değer  3 5 gibi bir şey girerseniz
                                                     //dinamik değil statik işlem olur yani yazdığın değer den fazlasının döndürmez 
                                                     //bunun yerine DiziAdı.length ifadesini kullanarakdizinin tüm elemanları kadar döngü oluşturabilirsin
            {
                Console.WriteLine(kurslar[i]); // Döngülerde verdiğin miktar kadar dizinin içindeki veriyi döndürmeye 
                //yarar. E ticaret sitesinde sayfaya ürün çağırmak veya udemy de kurs listelemek gibi

            }//dizi şuan 3 ten küçük değerleri saymaya odaklandığı için 3 e kadarki
            //değerleri ekrana yazığ sonrasında alttaki kodları işleyecek.
            // adı üstünde döngü kendini tammalayıncaya kadar dönüp işlem yapacak 
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar) // in kurslar kursları tek tek dolaş demek 
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer"); // for daha genel foreach daha iyi.  
        }
    }
}

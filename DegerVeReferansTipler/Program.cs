using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ??
            //Bu örnekte sayi1=sayi2 dediğinde sayi1 e sayi2 nin değerini atar ve işlemi bitirir.
            //Sonrasında sayi2 ye verdiğin değeri değiştirmenin hiçbir anlamı yoktur.
            //Cevap bu sebeple 30 olarak consola yazar.

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1 =??
            //Burada sayilar1 ve sayilar2 array olarak tanımlandığı için referans yöntemi ile çalışır. 
            // Bu sebeple sayilar1 değeri için bellekde adres atama yapar. sonrasında sayilar1 = sayilar2 
            //dediğimizde sayilar1 in referans numarasını sayilar ikinin referans numarasına eşitlediği için en son 
            // sayilar 2 nin sıfırıncı değerine 999 tanımlandığından dolayı cevap 999 olur.
            Console.WriteLine(sayilar1[0]);
            //int , decimal, float , double, boolean , = değer tip
            // array, class, interface = referans tip 
        }
    }
}

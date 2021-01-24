using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5]; //Bu şekilde tanımlama yapıncada yeni bir adres atar yukardaki arrayi unutur.
            //isimler[4] = "İlker";   // bu sebeple genelde array kullanmak yerine aşağıda tanımladığım list kullanıulır.
            //Console.WriteLine(isimler[4]); //Burada 4.elemanı tanımlayıp okumayaçalıştığımızda array patlar. 
            //Console.WriteLine(isimler[0]);


            //List genelde sürekli güncellenen listeler oluştuırmaYA YARAR.

            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}

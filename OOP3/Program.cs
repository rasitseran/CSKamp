using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtıyacKrediManager ihtıyacKrediManager = new IhtıyacKrediManager();
            //ihtıyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Burada Her birine ayrı ayrı isim vermek yerine 
            //interface sayesinde hepsini Ikredi manager adıyla çalıştırabiliyorum.
            //Çünkü interface ler o interface i  implemente eden class ın referans numarasını tutabiliyor.
            //bu sayede o interfacein adını yazdığımızda o classa erişebiliyor.
            //bu sebeple aşağıda yazdığım kod ile yukarda yazdığım kod çalıtırıldığında aynı sonucu verecektir.

            //IKrediManager ihtıyacKrediManager = new IhtıyacKrediManager();
            //ihtıyacKrediManager.Hesapla();

            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Başvuru yap  ekranını çalıştırabilmek için 
            //yani bankada başvuracağımız krediyi seçebileceğimiz ekranı oluştuabilmek için aşağıdaki kodu yazıyoruz.
            //yukardaki koduda bu sebeple aşağıdaki hale getirdim.

            IKrediManager ihtıyacKrediManager = new IhtıyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtıyacKrediManager, fileLoggerService);
            //BUrada BasvuruYap parantezin içine hangi kodu yazarsan o classı çağıracaktır. react native deki import gibi 

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtıyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //Burada birden çok krediyi seçip aynı anda hesaplatabilmek için list kullandık. 
            //Koleksiyonlar konusuna geri dön anlamadıysan.


        }
    }
}

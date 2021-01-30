using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection -- BUrada kulaandığımız methodu içeri enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //Kodu bu şekilde yazarsan bütün başvuruyu konut kredisine bağımlı hale getirir bu yanlış.
            //Bu sebeple yukarda public void de Ikredimanagerı kredi manager olarak tanımlayıp 
            //içerde sadece kredi manager çalıştırırsak hepsi çalışır. hangisini istersen o bağımsız bi şekilde çalışır.

            krediManager.Hesapla();
            loggerService.log();


        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlarda kullanırız.
    interface IKrediManager
    {
        void Hesapla();
        void BişeyYap();
    }
}

//loglamayı dosyada ,veritabanında tutabilir. SMS atabilirsiniz. 
//burada loglama ortak işlemdir. yapılan jer işlemin kodu farklıdır. Bu sebeple bunada loglama interface yazılır.
//bunu Iloggerservicede  yazmaya devam ettik.
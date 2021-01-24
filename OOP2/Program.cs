﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "2222222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";
            //Burada eğer müşteri gerçek müşteri ise  yazdığımız sistem patlar. 
            //bu sepbeple gerçek ve  tüzel olarak ayırmalıyoz.
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "2222222222222";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123445677890";
            // Gerçek müşteri - Tüzel müşteri
            //SOLID  -- 

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{       //snippet
    class Product
    {
        public int Id { get; set; } //ana referans kodu
        public int CategoryId { get; set; } //kategori referansı
        public string ProductName { get; set; } //ürün adı
        public double UnitPrice { get; set; } //ürün fiyatı
        public int UnıtsInStock { get; set; } //stok adeti

        //CRUD CREATE - READ - UPTADE - DELETE
    }
}

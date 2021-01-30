using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtıyacKrediManager : IKrediManager
    {
        public void BişeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac kredisi ödeme planı heaplandı");
        }
    }
}

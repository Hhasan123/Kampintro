using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //c# da bir ifade parantez ile acılıp kapatılmıssa o ifade bir metottur.
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "+urun.Adi);
        }

        public void Ekle2(string urunAdi,string urunAciklamasi,int urunFiyati,int urunStokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}

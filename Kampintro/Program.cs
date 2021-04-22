using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenligi
            //Don't repeat yourself - Kendini tekrarlama
            // kategorietiketi bir deger tutucudur, alias

            string kategorietiiketi = "Kategori";
            int ogrencisayisi = 32000;
            double faizoranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Dolar artıs butonu");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Dolar azalıs butonu");
            }
            else
            {
                Console.WriteLine("Dolar sabit butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Hoşgeldiniz.");
            }
            else
            {
                Console.WriteLine("Giris yap veya kaydol");
            }
            
            Console.WriteLine(kategorietiiketi);

            Console.ReadLine();
        }
    }
}

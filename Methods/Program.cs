using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 2.4;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 5;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("---------------Metotlar---------------");


            //instance - örnek
            //encapsulation - kapsulleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 5, 6);
            sepetManager.Ekle2("Elma", "Kirmizi elma", 10, 7);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 15, 8);

        }

    }
}

//Do not repeat yourself - DRY - Clean code - Best Practice
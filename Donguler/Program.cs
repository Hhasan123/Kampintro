using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım gelistirici kampı kursu";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "java";

            //array-dizi
            string[] kurslar = new string[] { "Yazılım gelistirici kampı kursu", "Programlamaya baslangic icin temel kurs", "java" };


            for (int i = 0; i <= kurslar.Length-1; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

        }
    }
}

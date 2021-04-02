using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do Not Repeat Yourself - Kendini Tekrar Etme
            //Type Safety - Tip Güvenliği
            //Alias - Değer Tutucu
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }

            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Eşittir");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar Butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);



        }
    }
}

using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety= tip güvenliği
            string KategoriEtiketi = "Kategori";
            //DRY= Dont Repeat Yourself=kendini tekrar etme
            Console.WriteLine(KategoriEtiketi);
            bool sistemegiris = true;
            if (sistemegiris==true)
            {
                Console.WriteLine("Kontrol Paneli");
            }
            else
            {
                Console.WriteLine("Giriş yapınız");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace OOP_My
{
    class Program
    {
        static void Main(string[] args)
        {
            IKredi konutKredi = new KonutKrediManager();
            IKredi arabaKredi = new ArabaKrediManager();
            BasvuruManager basvuru = new BasvuruManager();
       
            List<IKredi> kredis = new List<IKredi> {konutKredi,arabaKredi };
            //foreach (var item in kredis)
            //{
            //    item.Hesapla();
            //}
            basvuru.OnBilgilendirme(kredis);
            basvuru.BasvuruYap(arabaKredi);
        }
    }
}

using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program

    {
        //interfaceler de implemente ettiği classların refrans numarasını tutabilir.
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKredi = new IhtiyacKrediManager();
            IKrediManager tasitKredi = new TasitKrediManager();
            IKrediManager konutKredi = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ıhtiyacKredi);

            List<IKrediManager> krediler = new List<IKrediManager>() {
            ıhtiyacKredi,
            tasitKredi,
            konutKredi
            };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}

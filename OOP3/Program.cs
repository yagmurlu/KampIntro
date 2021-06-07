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
            ILoggerService fileLogerService = new FileLoggerService();
            ILoggerService dataLogerService = new DatabaseLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
           // basvuruManager.BasvuruYap(ıhtiyacKredi, dataLogerService);// altdaji kodla aynı işlevi görür.
            basvuruManager.BasvuruYap(ıhtiyacKredi, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {
            ıhtiyacKredi,
            tasitKredi,
            konutKredi
            };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}

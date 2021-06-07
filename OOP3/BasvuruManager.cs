using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        // method injection
        //birden fazla loger yolamak istediğimizde list tutarız
        //bir tane olsaydı =>public void BasvuruYap(IKrediManager krediManager ,ILoggerService loggerService)
        public void BasvuruYap(IKrediManager krediManager ,List<ILoggerService> loggerService)
        {
            
            krediManager.Hesapla();
            // loggerService.Log();// =>Bir tane log yolladığımız için bu yeterliydi
            //Birden fazla loger yollayacağımız için foreach kullanmalıyız
            foreach (var logger in loggerService)
            {
                logger.Log();
            }

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

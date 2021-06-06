using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_My
{
    class BasvuruManager
    {
        public void BasvuruYap(IKredi kredi)
        {
            kredi.Hesapla();
        }
        public void OnBilgilendirme(List<IKredi> kredis)
        {
            foreach (var item in kredis)
            {
                item.Hesapla();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class DortIslem
    {
        public void Topla(int sayı1,int sayı2)
        {
            int toplam = sayı1 + sayı2;
            Console.WriteLine("Toplam: "+toplam);
        }
        public void Cıkarma(int sayı1, int sayı2)
        {
            int cıkarma = sayı1 - sayı2;
            Console.WriteLine("Toplam: " + cıkarma);
        }
        public void Carpma(int sayı1, int sayı2)
        {
            int carpma = sayı1 * sayı2;
            Console.WriteLine("Toplam: " + carpma);
        }
        public void Bolme(int sayı1, int sayı2)
        {
            int bolme = sayı1 / sayı2;
            Console.WriteLine("Toplam: " + bolme);
        }
    }
}

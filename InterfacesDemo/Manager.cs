using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Manager : IWorker ,IWorkerHuman
    {
        public void Eat()
        {
            Console.WriteLine("Yönetici Yemek Yiyor!!");
        }

        public void Salary()
        {
            Console.WriteLine("Yönetici Maaşı Hesaplandı!!");
        }

        public void Work()
        {
            Console.WriteLine("Yönetici Çalışıyor!!");
        }
    }
}

using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ortak Interface deki work methodu çağırılıdı
            IWorker[] workers = new IWorker[]
            {
                new Manager(),
                new Robot(),
            };
            foreach (var work in workers)
            {
                work.Work();
            }

            //******************************************************************************
            //Yalnızca insanlara ait özelliklerin bulunduğu interface içi methodlar çağırıldı
            IWorkerHuman[] humen = new IWorkerHuman[]
            {
                new Manager()
            };
            
            foreach (var manager in humen)
            {
                manager.Eat();
                manager.Salary();
            }
            
        }
    }
}

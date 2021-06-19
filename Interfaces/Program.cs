using System;

namespace Interfaces
{
    //Interface ler new lenemez!!!
    class Program
    {
        static void Main(string[] args)
        {
            //MANAGER kullanımı
            OracleDal oracleDal = new OracleDal();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(oracleDal);
            customerManager.Update(oracleDal);
            Console.WriteLine("-----------------------------------------------------");
            ICustomerDal[] customerDals = new ICustomerDal[]
            {
                new OracleDal(),
                new SqlServerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                
            }
        }
    }
}

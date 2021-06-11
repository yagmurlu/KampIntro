using System;

namespace Interfaces
{
    //Interface ler new lenemez!!!
    class Program
    {
        static void Main(string[] args)
        {
            //OracleDal oracleDal = new OracleDal();
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(oracleDal);

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

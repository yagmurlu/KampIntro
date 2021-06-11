using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class OracleDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SqlServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added!");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated!");
        }
    }
}

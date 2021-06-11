using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //CRUD işlemlerini DAL sınıfında yaparız.
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }
}

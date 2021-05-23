using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" "+"Sepete eklendi");
        }

        public void Add2(int urunid,string urunAd)
        {
            Console.WriteLine("sepete eklendi : "+urunAd);
        }
    }
}

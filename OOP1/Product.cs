using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //entity
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string PoductName { get; set; }
        //ürün fiyat
        public double UnitPrice { get; set; }
        //ürün stok adeti
        public int UnitsInStock { get; set; }
    }
}

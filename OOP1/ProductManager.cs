using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
       // Product product = new Product();

        public void Add(Product product)
        {
            Console.WriteLine(product.PoductName+ " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.PoductName="Şal" +" güncellendi.");
        }
        public int Topla(int sayı1,int sayı2)
        {
            return sayı1 + sayı2;
        }
        public void Topla2(int sayı1, int sayı2)
        {
            Console.WriteLine(sayı1+sayı2);
        }
    }
}

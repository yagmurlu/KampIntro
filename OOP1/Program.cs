using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//mobilya olsun
            product1.PoductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitPrice = 30,
                PoductName = "Çanta",
                UnitsInStock = 10
            };
            //case sensitve = büyük küçük harf duyarlılığı
            //PascalCase
            //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
            

        }
    }
}

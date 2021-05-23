using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.ProductPrice = 5;
            product1.ProductDescription = "Amasya elması";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.ProductPrice = 20;
            product2.ProductDescription = "Diyarbakır karpuzu";

            Product[] products = new Product[]
            {
                product1,product2
            };
            //type-safe==tip güvenliği
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.ProductPrice);
                Console.WriteLine(product.ProductDescription);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("----------Methods---------------");
            //ıntance---class örneği oluşturma
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add2(1,"Kalem");

        }

    }
}
//best practise=doğru uygulama teknikleri
//clean code
//DRY
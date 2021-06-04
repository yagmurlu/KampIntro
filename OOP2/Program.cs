using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.ID = 1;
            customer1.CustomerNo = "122345";
            customer1.FirstName="Yağmur";
            customer1.LastName = "Demiroğ";
            customer1.TcNo = "12345678911";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.ID=2;
            customer2.CustomerNo = "54321";
            customer2.SirketAdı = "Kodlama Io";
            customer2.VergiNo = "6556432";



            //Gerçek Müşteri -Tüzel Müşteri => birbirlerinin yerine kullanılamazlar
            //SOLID=> L

            // NEW görürsek ondan sonrası referans sınıfıdır
            // Burada Customer sınıfı hem tüzel hemde gerçek müşterinini referansını tutuyor.

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();
            CustomerManager cm = new CustomerManager();
            cm.Add(customer1);
            cm.Add(customer2);
            cm.Add(customer3);
            cm.Add(customer4);
        }

    }
}

using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //new leme yaptığımızda constructor method çalışır.
            Customer customer = new Customer(1, "Yağmur", "Tümtürk", "Ankara");
            Console.WriteLine(customer.Name);
            Customer customer1 = new Customer() 
            {
                Id=2,
                Name="Sertap",
                Surname="Öz",
                City="İzmir"
            };
            Console.WriteLine(customer1.Name);
        }
    }
    class Customer
    {
        public Customer()//default Constructor==parametrsi olmayan contsructor a denir.
        {
            Console.WriteLine("Yapıcı blok");
        }
        public Customer(int ıd, string name, string surname, string city)//genericc constructor
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            City = city;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}

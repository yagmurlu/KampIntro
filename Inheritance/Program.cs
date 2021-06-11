using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Student{FirstName="Yağmur",School="NEÜ"},
                new Woker{FirstName="Ali",Departman="Bilişim"},
                
            };
            foreach (var people in persons)
            {
                Console.WriteLine(people.FirstName);
               
            }
        }
    }
}

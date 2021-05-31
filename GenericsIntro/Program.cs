using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>(); 
            names.Add("Aleyna");
            Console.WriteLine(names.Lenght);
            names.Add("Yağmur");
            Console.WriteLine(names.Lenght);
            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

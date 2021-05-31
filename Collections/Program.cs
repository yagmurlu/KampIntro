using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Yağmur","Kağan","Yasemin","Emre"};
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            List<string> names2 = new List<string> { "Aleyna","Yağmur","Gül"};
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("İlker");
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[0]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Dictonary
{
    public class Program
    {
        static void Main(string[] args)
        {

            // DICTONARY KULLANIMI//////////////////////////
            Dictionary<int,string> city = new Dictionary<int,string>();
            city.Add(1, "Adana");
            city.Add(6, "Ankara");
            foreach (KeyValuePair<int,string> sehir in city)
            {
                Console.WriteLine("Plaka:{0} Şehir:{1}",sehir.Key,sehir.Value);
            }
            //////////////////////////////////////////////////


            MyDictonary<int, string> ogrenci = new MyDictonary<int,string>();
            ogrenci.Add(1, "Yağmur");
            Console.WriteLine(ogrenci.Count);
            ogrenci.Add(2, "Aleyna");
            Console.WriteLine(ogrenci.Count);
            ogrenci.Add(10, "Faruk");
            Console.WriteLine(ogrenci.Count);

            foreach (var okul in ogrenci.Value)
            {
                Console.WriteLine(okul);
            }
        }
    }
}

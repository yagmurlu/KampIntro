using System;

namespace DegerVeReferansTıpler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayı2 = 30;
            sayi1 = sayı2;
            sayı2 = 65;
            Console.WriteLine(sayi1);
            //int,decimal,float,double,bool=değer tip  ---stack de gerçekleşir
            //array,class,ınterface=referans tip  ---heap da gerçekleşir.//adresi yolu tutulur.

        }
    }
}

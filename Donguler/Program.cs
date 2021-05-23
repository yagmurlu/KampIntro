using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[]
            {"elma",
            "armut",
            "kivi"
            };
            for (int i = 0; i < meyveler.Length; i++)
            {
                Console.WriteLine(meyveler[i]);
            }
            //yukardaki for ile aynı görevde
            // foreach dizileri daha kolay dolaşmamızı sağlar
            foreach (string i in meyveler)
            {
                Console.WriteLine(i);
            }
        }
    }
}

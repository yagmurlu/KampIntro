using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            MyList<int> names2 = new MyList<int>();
            names.Add("Aleyna");
            names2.Add(10);
        }
    }
}

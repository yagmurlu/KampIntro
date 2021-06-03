using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> city = new MyList<string>();
            city.Add("Ankara");
            city.Add("Ankara");
            city.Add("Ankara");
            city.Add("Ankara");

            Console.WriteLine(city.Count);
            MyList<string> city2 = new MyList<string>();
            city2.Add("İzmir");
            city2.Add("İzmir");
            city2.Add("İzmir");
            city2.Add("İzmir");
            city2.Add("İzmir");
            city2.Add("İzmir");
            Console.WriteLine(city2.Count);
        }
    }
    class MyList<T>//Generic class
    {
        T[] _array;
        T[] _tempArray;//geçici dizi
        public MyList()//constructor =>listler ir array olduğu için diziye eleman sayısını belirtmeliyiz.
        {
            _array = new T[0];
        }
        
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];//eleman sayısnı 1 arttırız.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;//diziye sondan ekleme
        }
        //count bir propperty dir. sadece get ile çalışır.
        public int Count//propfull +tab+tab//arrayin eleman sayısını verir.
        {
            get { return _array.Length; }
           
        }
      
    }
}

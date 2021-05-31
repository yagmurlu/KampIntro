using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>// buradki T verdiğimiz tipe den geliyor
    {
        T[] items;
        //classı new"lersem oto. çalışır.
        public MyList()//CTOR TAB TAB// constructor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//geçici dizi//elemanlar silinmesin diye
            items = new T[items.Length + 1];//dizinin eleman sayısını  1 artır 
            for (int i = 0; i < tempArray.Length; i++)
                //items a eski değeleri geri verir
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;//eklenmek istenilen elemanı ekledim.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    public class MyDictonary<X,Y>
    {
        X[] _array1;
        Y[] _array2;
        X[] _tempArray1;
        Y[] _tempArray2;

        public MyDictonary()//constructor
        {
            _array1 = new X[0];
            _array2 = new Y[0];
        }
        public void Add(X item, Y item2)
        {
            _tempArray1 = _array1;
            _tempArray2 = _array2;
            _array1 = new X[_array1.Length + 1];
            _array2 = new Y[_array2.Length + 1];

            for (int i = 0; i < _tempArray1.Length; i++)
            {
                _array1[i] = _tempArray1[i];
                for (int j = 0; j < _tempArray2.Length; j++)
                {
                    _array2[j] = _tempArray2[j];
                }
            }
            _array1[_array1.Length - 1] = item;
            _array2[_array2.Length - 1] = item2;
        }
        public int Count
        {
            get { return _array1.Length; }
        }
        public X[] Key
        {
            get { return _array1; }
        }
        public Y[] Value
        {
            get { return _array2; }
        }
    }
}

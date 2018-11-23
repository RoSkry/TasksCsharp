using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyListApp
{
    public class MyList<T>:IEnumerable<T>
    {
        public int Length { get; set; }
        private T[] _collection;
        public MyList()
        {
            _collection = new T[] { };
        }
        public MyList(params T[] collection)
        {
            _collection = collection;
        }
        public void Add(T value)
        {
            T[] temp = _collection;
            Array.Resize(ref _collection,_collection.Length+1);
            for (int i = 0; i < temp.Length; i++)
            {
                _collection[i] = temp[i];
            }
            _collection[_collection.Length - 1] = value;
        }
        public bool Remove(T value)
        {
            for (int i = 0; i < _collection.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(_collection[i],value))
                {
                    T temp = _collection[i];
                    _collection[i] = _collection[_collection.Length - 1];
                    _collection[_collection.Length - 1] = temp;
                    Array.Resize(ref _collection,_collection.Length - 1);
                    return true;   
                }
                

            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

    





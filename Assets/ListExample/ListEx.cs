using System;
using System.Linq;

namespace DZ.ListExample
{
    public class ListEx<T>
    {
        private T[] _mainArray;
        private int _count;

        public int Count
        {
            get => _count;
        }

        public ListEx(int capacity = 4)
        {
            _mainArray = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count == _mainArray.Length)
            {
                var temp = new T[_mainArray.Length * 2];
                _mainArray.CopyTo(temp, 0);
                _mainArray = temp;
            }

            _mainArray[_count] = item;
            _count++;
        }

        public void Clear()
        {
            _mainArray = new T[4];
            _count = 0;
        }

        public T[] ToArray()
        {
            var result = new T[_count];
            Array.Copy(_mainArray, 0, result, 0, _count);
            return result;
        }

        public bool Contains(T item) => _mainArray.Contains(item);


        public void CopyTo(T[] array, int arrayIndex) => _mainArray.CopyTo(array, arrayIndex);


        public bool Remove(T item)
        {
            var pos = Array.FindIndex(_mainArray, x => x.Equals(item));
            RemoveAt(pos + 1);
            return true;
        }


        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < _count && _count > 0)
            {
                var pos = index;
                if (pos == -1 || _count == 0)
                    return false;
                Array.Copy(_mainArray, pos, _mainArray, pos, _count - pos);
                _count--;
            }

            return false;
        }

        public T this[int index]
        {
            get => _mainArray[index];
            set => _mainArray[index] = value;
        }
    }
}
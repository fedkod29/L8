using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Problem_7_8
{
    internal class MyList <T> where T : IComparable<T>, IEquatable<T>
    {
        private T[] _list;
        private int _size;
        private int _capasity;

        public T this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                _list[index] = value;
            }
        }


        public int Size { get { return _size; } }
        public MyList(int capasity = 10)
        {
            if (capasity < 0) capasity = 1;
            this._capasity = capasity;
            _list = new T[_capasity];
        }


        public void Add(T newElement)
        {
            if (_size == _capasity)
                Resize();

            _list[_size] = newElement;
            _size++;
        }

        public void Remove(int index)
        {
            checkIndexOutRange(index);

            for (int i = index; i < _size - 1; i++)
                _list[i] = _list[i + 1];

            _list[_size-1] = default(T);
            _size--;
        }

        public void Print()
        {
            for(int i = 0; i < _size; i++)
                Console.WriteLine(_list[i]);
        }

        public void Swap(int index1, int index2)
        {
            checkIndexOutRange(index1);
            checkIndexOutRange(index2);

            T tmp = _list[index1];
            _list[index1] = _list[index2];
            _list[index2] = tmp;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;

            for (int i = 0; i < _size; i++)
                if (_list[i].CompareTo(element) > 0)
                    count++;

            return count;
        }

        public bool Contains(T element)
        {
            bool result = false;

            for (int i = 0; i < _size; i++)
                if (_list[i].Equals(element))
                    result = true;

            return result;
        }

        public T Max()
        {
            T max = _list[0];
            for (int i = 1; i < _size; i++)
                if (_list[i].CompareTo(max) > 0)
                    max = _list[i];

            return max;
        }
        public T Min()
        {
            T min = _list[0];
            for (int i = 1; i < _size; i++)
                if (_list[i].CompareTo(min) < 0)
                    min = _list[i];

            return min;
        }


        private void checkIndexOutRange(int index)
        {
            if (index < 0 || index > _size - 1)
                throw new ArgumentOutOfRangeException($"The current size of this array is {_size}");
        }
        private void Resize()
        {
            T[] resizeArr = new T[_capasity * 2];

            for(int i = 0; i < _capasity; i++)
                resizeArr[i] = _list[i];

            _list = resizeArr;
            _capasity = _capasity * 2;
        }
    }
}

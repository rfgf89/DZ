namespace DZ.QueueExample
{
    public class QueueEx<T>
    {
        private LinkedValue<T> _first;
        private LinkedValue<T> _last;
        private int _count = 0;
        
        public int Count
        {
            get => _count;
        }

        public void Enqueue(T obj)
        {
            if (_count == 0)
            {
                _first = new LinkedValue<T>(obj);
                _last = _first;
            }
            else
            {
                var temp = new LinkedValue<T>(obj);
                _last.nextValue = temp;
                temp.preValue = _last;
                _last = temp;
            }

            _count++;
        }

        public object Dequeue()
        {
            if (_count == 0)
                return null;
            T result;
            if (_count == 1)
                result = _last.value;
            else
            {
                result = _first.value;
                _first.nextValue.preValue = null;
                _first = _first.nextValue;
            }
            _count--;
            return result;
        }

        public object Peek() => _first;
        
        public void Clear()
        {
            _first = null;
            _last = null;
            _count = 0;
        }

        public bool Contains(object obj)
        {
            var temp = _first;
            while (true)
            {
                if (temp == null)
                    return false;
                if (temp.value.Equals(obj))
                    return true;
                temp = temp.nextValue;
            }
        }

        
        public T[] ToArray()
        {
            if (_count == 0)
                return null;
            var result = new T[_count];
            var curr = _first;
            
            for (int i = 0; i < _count; i++)
            {
                result[i] = curr.value;
                curr = curr.nextValue;
            }

            return result;
        }

    }
}
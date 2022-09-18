namespace DZ.StackExample
{
    public class StackEx<T>
    {
        private StackValue<T> _lastValue;
        private int _count;

        public int Count
        {
            get => _count;
        }
        
        public void Push(T value) 
        {
            _lastValue = new StackValue<T>(value, _lastValue);
            _count++;
        }

        public object Pop() 
        {
            if (_count == 0)
                return null;
            T result = _lastValue.GetValue();
            _lastValue = _lastValue.GetLast();
            _count--;
            return result;
        }

        public object Peek()
        {
            if (_count == 0)
                return null;
            return _lastValue.GetValue();
        } 

        public void Clear()
        {
            _lastValue = null;
            _count = 0;
        }

        public bool Contains(T obj)
        {
            var temp = _lastValue;
            while (true)
            {
                if (temp == null)
                    return false;
                if (temp.GetValue().Equals(obj))
                    return true;
                temp = temp.GetLast();

            }
        }

        public T[] ToArray()
        {
            if (_count == 0)
                return null;
            var result = new T[_count];
            var curr = _lastValue;
            for (int i = 0; i < _count; i++)
            {
                result[i] = curr.GetValue();
                curr = _lastValue.GetLast();
            }

            return result;
        }
        
    }
}
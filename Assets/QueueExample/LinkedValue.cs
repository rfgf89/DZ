namespace DZ.QueueExample
{
    public class LinkedValue<T>
    {
        public T value { get; }
        public LinkedValue<T> preValue;
        public LinkedValue<T> nextValue;
        public LinkedValue(T value)
        {
            this.value = value;
        }

        

    }
}
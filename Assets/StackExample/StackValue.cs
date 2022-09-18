namespace DZ.StackExample
{
    public class StackValue<T>
    {
        private T currentValue;
        private StackValue<T> stackPreValue;

        public StackValue(T currentValue, StackValue<T> stackPreValue)
        {
            this.currentValue = currentValue;
            this.stackPreValue = stackPreValue;
        }

        public StackValue<T> GetLast() => stackPreValue;
        public T GetValue() => currentValue;

    }
}
namespace AdvancedGenerics
{
    public class Box<T>
    {
        private T _value;

        public Box(T value)
        {
            _value = value;
        }

        public string Describe()
        {
            return $"This box contains a value of type {typeof(T)}: {_value}";
        }

        public T Get()
        {
            return _value;
        }

        public void Set(T value)
        {
            // Note: In a real-world scenario, you might want to make _value mutable.
            _value = value;
        }

    }
}

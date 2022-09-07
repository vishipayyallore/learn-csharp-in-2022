namespace SimpleStack.V3
{

    public class SimpleStackGeneric<T>
    {

        private readonly T[] _items;
        private int _currentIndex = -1;

        public SimpleStackGeneric() => _items = new T[10];

        public int Count => _currentIndex + 1;

        public void Push(T value) => _items[++_currentIndex] = value;

        public T Pop() => _items[_currentIndex--];
    }

}

namespace SimpleStack.V2
{

    // Boxing and Unboxing ;)
    public class SimpleStackObject
    {

        private readonly object[] _items;
        private int _currentIndex = -1;

        public SimpleStackObject() => _items = new object[10];

        public int Count => _currentIndex + 1;

        public void Push(object value) => _items[++_currentIndex] = value;

        public object Pop() => _items[_currentIndex--];
    }

}

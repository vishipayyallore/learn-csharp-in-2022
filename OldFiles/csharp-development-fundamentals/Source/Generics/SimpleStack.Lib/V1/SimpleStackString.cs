namespace SimpleStack.Lib.V1
{

    public class SimpleStackString
    {

        private readonly string[] _items;
        private int _currentIndex = -1;

        public SimpleStackString() => _items = new string[10];

        public int Count => _currentIndex + 1;

        public void Push(string value) => _items[++_currentIndex] = value;

        public string Pop() => _items[_currentIndex--];
    }

}

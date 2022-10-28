using CharactersDemo.Flyweights;

using static System.Console;

namespace CharactersDemo.ConcreteFlyweight
{
    /// <summary>
    /// Concrete Flyweight
    /// </summary>
    public class CharacterB : ICharacter
    {
        private readonly char _actualCharacter = 'b';
        private string _fontFamily = string.Empty;
        private int _fontSize;

        public void Draw(string fontFamily, int fontSize)
        {
            _fontFamily = fontFamily;
            _fontSize = fontSize;

            WriteLine($"Drawing {_actualCharacter}, {_fontFamily} {_fontSize}");
        }
    }

}

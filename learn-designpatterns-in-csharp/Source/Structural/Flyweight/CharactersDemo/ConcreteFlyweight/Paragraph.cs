﻿using CharactersDemo.Flyweights;

using static System.Console;

namespace CharactersDemo.ConcreteFlyweight
{

    /// <summary>
    /// Unshared Concrete Flyweight
    /// </summary>
    public class Paragraph : ICharacter
    {
        private int _location;
        private List<ICharacter> _characters = new();

        public Paragraph(List<ICharacter> characters, int location)
        {
            _characters = characters;
            _location = location;
        }

        public void Draw(string fontFamily, int fontSize)
        {
            WriteLine($"Drawing in paragraph at location {_location}");
            foreach (var character in _characters)
            {
                character.Draw(fontFamily, fontSize);
            }
        }
    }

}

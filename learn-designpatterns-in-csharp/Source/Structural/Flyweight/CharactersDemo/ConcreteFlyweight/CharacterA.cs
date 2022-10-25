﻿using CharactersDemo.Flyweights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersDemo.ConcreteFlyweight
{

    /// <summary>
    /// Concrete Flyweight
    /// </summary>
    public class CharacterA : ICharacter
    {
        private char _actualCharacter = 'a';
        private string _fontFamily = string.Empty;
        private int _fontSize;

        public void Draw(string fontFamily, int fontSize)
        {
            _fontFamily = fontFamily;
            _fontSize = fontSize;
            Console.WriteLine($"Drawing {_actualCharacter}, {_fontFamily} {_fontSize}");
        }
    }

    /// <summary>
    /// Concrete Flyweight
    /// </summary>
    public class CharacterB : ICharacter
    {
        private char _actualCharacter = 'b';
        private string _fontFamily = string.Empty;
        private int _fontSize;

        public void Draw(string fontFamily, int fontSize)
        {
            _fontFamily = fontFamily;
            _fontSize = fontSize;
            Console.WriteLine($"Drawing {_actualCharacter}, {_fontFamily} {_fontSize}");
        }
    }

}

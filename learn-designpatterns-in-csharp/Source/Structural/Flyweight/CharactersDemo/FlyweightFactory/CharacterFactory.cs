using CharactersDemo.ConcreteFlyweight;
using CharactersDemo.Flyweights;

namespace CharactersDemo.FlyweightFactory
{

    /// <summary>
    /// FlyweightFactory
    /// </summary>
    public class CharacterFactory
    {
        private readonly Dictionary<char, ICharacter> _characters = new();

        public ICharacter? GetCharacter(char characterIdentifier)
        {
            // Coes the character dictionary contain the one we need? 
            if (_characters.ContainsKey(characterIdentifier))
            {
                Console.WriteLine("Character reuse");
                return _characters[characterIdentifier];
            }

            // The character isn't in the dictionary. 
            // Create it, store it, return it.
            Console.WriteLine("Character construction");
            switch (characterIdentifier)
            {
                case 'a':
                    _characters[characterIdentifier] = new CharacterA();
                    return _characters[characterIdentifier];
                case 'b':
                    _characters[characterIdentifier] = new CharacterB();
                    return _characters[characterIdentifier];
                    // and so on...               
            }

            return null;
        }

        public ICharacter CreateParagraph(List<ICharacter> characters, int location)
        {
            return new Paragraph(characters, location);
        }
    }

}

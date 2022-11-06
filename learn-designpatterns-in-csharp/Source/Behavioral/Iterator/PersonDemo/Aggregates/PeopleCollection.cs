using PersonDemo.Iterators;
using PersonDemo.Models;

namespace PersonDemo.Aggregates
{
    /// <summary>
    /// ConcreteAggregate
    /// </summary>
    public class PeopleCollection : List<Person>, IPeopleCollection
    {
        public IPeopleIterator CreateIterator()
        {
            return new PeopleIterator(this);
        }
    }

}

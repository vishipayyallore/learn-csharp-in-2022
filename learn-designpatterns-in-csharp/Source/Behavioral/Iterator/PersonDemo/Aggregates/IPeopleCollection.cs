using PersonDemo.Iterators;

namespace PersonDemo.Aggregates
{

    /// <summary>
    /// Aggregate
    /// </summary>
    public interface IPeopleCollection
    {
        IPeopleIterator CreateIterator();
    }

}

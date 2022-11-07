﻿using PersonDemo.Models;

namespace PersonDemo.Iterators
{

    /// <summary>
    /// Iterator
    /// </summary>
    public interface IPeopleIterator
    {
        Person First();

        Person Next();

        bool IsDone { get; }

        Person CurrentItem { get; }
    }

}

﻿namespace GenericRepository.Lib.Repositories.V2
{

    public class GenericRepository<T>
    {

        private readonly List<T> _items = new();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

    }

}

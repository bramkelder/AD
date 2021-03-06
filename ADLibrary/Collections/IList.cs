﻿namespace ADLibrary.Collections
{
    /// <summary>
    /// Interface for all our lists. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IList<T> : ICollection<T>
    {
        void add(T item);
        T get(int index);
        int indexOf(T item);
        T removeAt(int index);
        void remove(T item);
        void insert(T item, int index);
    }
}

using System;

namespace Sort
{
    public interface ISorter<T> where T : IComparable<T>
    {
        string Name { get; }

        T[] Sort(T[] array);
    }
}

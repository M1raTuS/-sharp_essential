﻿namespace Lesson_10._2
{
    public interface IMyList<T> 
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}